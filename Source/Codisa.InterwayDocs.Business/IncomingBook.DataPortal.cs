using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Csla.Data;

namespace Codisa.InterwayDocs.Business
{
    public partial class IncomingBook
    {

        #region Data Access

        /// <summary>
        /// Loads a <see cref="IncomingBook"/> collection from the database, based on given criteria.
        /// </summary>
        /// <param name="crit">The fetch criteria.</param>
        protected void DataPortal_Fetch(IncomingBookCriteriaGet crit)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Database.InterwayDocsConnection, false))
            {
                using (var cmd = new SqlCommand(GetIncomingBookInlineQuery(crit), ctx.Connection))
                {
                    var archiveLocation = string.Empty;
                    var fullText = string.Empty;

                    if (!string.IsNullOrEmpty(crit.ArchiveLocation))
                        archiveLocation = "%" + crit.ArchiveLocation + "%";

                    if (!string.IsNullOrEmpty(crit.FullText))
                        fullText = "%" + crit.FullText + "%";

                    cmd.CommandType = CommandType.Text;
                    if (!crit.CriteriaStartDate.IsEmpty)
                        cmd.Parameters.AddWithValue("@CriteriaStartDate", crit.CriteriaStartDate.DBValue).DbType = DbType.Date;
                    if (!crit.CriteriaEndDate.IsEmpty)
                        cmd.Parameters.AddWithValue("@CriteriaEndDate", crit.CriteriaEndDate.DBValue).DbType = DbType.Date;
                    if (!string.IsNullOrEmpty(crit.ArchiveLocation))
                        cmd.Parameters.AddWithValue("@ArchiveLocation", archiveLocation).DbType = DbType.String;
                    if (!string.IsNullOrEmpty(crit.FullText))
                        cmd.Parameters.AddWithValue("@FullText", fullText).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd, crit);
                    OnFetchPre(args);
                    LoadCollection(cmd);
                    OnFetchPost(args);
                }
            }
        }

        private void LoadCollection(SqlCommand cmd)
        {
            using (var dr = new SafeDataReader(cmd.ExecuteReader()))
            {
                Fetch(dr);
            }
        }

        /// <summary>
        /// Loads all <see cref="IncomingBook"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            IsReadOnly = false;
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(IncomingInfo.GetIncomingInfo(dr));
            }
            RaiseListChangedEvents = rlce;
            IsReadOnly = true;
        }

        #endregion

        #region DataPortal Hooks

        /// <summary>
        /// Occurs after setting query parameters and before the fetch operation.
        /// </summary>
        partial void OnFetchPre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after the fetch operation (object or collection is fully loaded and set up).
        /// </summary>
        partial void OnFetchPost(DataPortalHookArgs args);

        #endregion

        #region IncomingRegisterSaved nested class

        /// <summary>
        /// Nested class to manage the Saved events of <see cref="IncomingRegister"/>
        /// to update the list of <see cref="IncomingInfo"/> objects.
        /// </summary>
        private static class IncomingRegisterSaved
        {
            private static List<WeakReference> _references;

            private static bool Found(object obj)
            {
                return _references.Any(reference => Equals(reference.Target, obj));
            }

            /// <summary>
            /// Registers a IncomingBook instance to handle Saved events.
            /// to update the list of <see cref="IncomingInfo"/> objects.
            /// </summary>
            /// <param name="obj">The IncomingBook instance.</param>
            public static void Register(IncomingBook obj)
            {
                var mustRegister = _references == null;

                if (mustRegister)
                    _references = new List<WeakReference>();

                if (SingleInstanceSavedHandler)
                    _references.Clear();

                if (!Found(obj))
                    _references.Add(new WeakReference(obj));

                if (mustRegister)
                    IncomingRegister.IncomingRegisterSaved += IncomingRegisterSavedHandler;
            }

            /// <summary>
            /// Handles Saved events of <see cref="IncomingRegister"/>.
            /// </summary>
            /// <param name="sender">The sender of the event.</param>
            /// <param name="e">The <see cref="Csla.Core.SavedEventArgs"/> instance containing the event data.</param>
            public static void IncomingRegisterSavedHandler(object sender, Csla.Core.SavedEventArgs e)
            {
                foreach (var reference in _references)
                {
                    if (reference.IsAlive)
                        ((IncomingBook) reference.Target).IncomingRegisterSavedHandler(sender, e);
                }
            }

            /// <summary>
            /// Removes event handling and clears all registered IncomingBook instances.
            /// </summary>
            public static void Unregister()
            {
                IncomingRegister.IncomingRegisterSaved -= IncomingRegisterSavedHandler;
                _references = null;
            }
        }

        #endregion

    }
}
