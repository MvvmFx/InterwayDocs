using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Codisa.InterwayDocs.Configuration
{

    /// <summary>
    /// LanguageColl (editable root list).<br/>
    /// This is a generated <see cref="LanguageColl"/> business object.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="Language"/> objects.
    /// </remarks>
    [Serializable]
    public partial class LanguageColl : BusinessBindingListBase<LanguageColl, Language>
    {

        #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="Language"/> item from the collection.
        /// </summary>
        /// <param name="uICulture">The UICulture of the item to be removed.</param>
        public void Remove(string uICulture)
        {
            foreach (var language in this)
            {
                if (language.UICulture == uICulture)
                {
                    Remove(language);
                    break;
                }
            }
        }

        /// <summary>
        /// Determines whether a <see cref="Language"/> item is in the collection.
        /// </summary>
        /// <param name="uICulture">The UICulture of the item to search for.</param>
        /// <returns><c>true</c> if the Language is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(string uICulture)
        {
            foreach (var language in this)
            {
                if (language.UICulture == uICulture)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether a <see cref="Language"/> item is in the collection's DeletedList.
        /// </summary>
        /// <param name="uICulture">The UICulture of the item to search for.</param>
        /// <returns><c>true</c> if the Language is a deleted collection item; otherwise, <c>false</c>.</returns>
        public bool ContainsDeleted(string uICulture)
        {
            foreach (var language in DeletedList)
            {
                if (language.UICulture == uICulture)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="LanguageColl"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="LanguageColl"/> collection.</returns>
        public static LanguageColl NewLanguageColl()
        {
            return DataPortal.Create<LanguageColl>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="LanguageColl"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="LanguageColl"/> collection.</returns>
        public static LanguageColl GetLanguageColl()
        {
            return DataPortal.Fetch<LanguageColl>();
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageColl"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public LanguageColl()
        {
            // Use factory methods and do not use direct creation.

            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            AllowNew = true;
            AllowEdit = true;
            AllowRemove = true;
            RaiseListChangedEvents = rlce;
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="LanguageColl"/> collection from the database.
        /// </summary>
        protected void DataPortal_Fetch()
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Database.InterwayDocsConnection, false))
            {
                using (var cmd = new SqlCommand("dbo.GetLanguageColl", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    var args = new DataPortalHookArgs(cmd);
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
        /// Loads all <see cref="LanguageColl"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(Language.GetLanguage(dr));
            }
            RaiseListChangedEvents = rlce;
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="LanguageColl"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager(Database.InterwayDocsConnection, false))
            {
                base.Child_Update();
                ctx.Commit();
            }
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

    }
}
