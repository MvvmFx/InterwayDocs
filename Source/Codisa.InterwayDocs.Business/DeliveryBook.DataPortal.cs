using System.Data;
using System.Data.SqlClient;
using Csla.Data;

namespace Codisa.InterwayDocs.Business
{
    public partial class DeliveryBook
    {

        #region Data Access

        /// <summary>
        /// Loads a <see cref="DeliveryBook"/> collection from the database, based on given criteria.
        /// </summary>
        /// <param name="crit">The fetch criteria.</param>
        protected void DataPortal_Fetch(DeliveryBookCriteriaGet crit)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Database.InterwayDocsConnection, false))
            {
                using (var cmd = new SqlCommand(GetDeliveryBookInlineQuery(crit), ctx.Connection))
                {
                    var fullText = string.Empty;

                    if (!string.IsNullOrEmpty(crit.FullText))
                        fullText = "%" + crit.FullText + "%";

                    cmd.CommandType = CommandType.Text;
                    if (!crit.CriteriaStartDate.IsEmpty)
                        cmd.Parameters.AddWithValue("@CriteriaStartDate", crit.CriteriaStartDate.DBValue).DbType = DbType.Date;
                    if (!crit.CriteriaEndDate.IsEmpty)
                        cmd.Parameters.AddWithValue("@CriteriaEndDate", crit.CriteriaEndDate.DBValue).DbType = DbType.Date;
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
        /// Loads all <see cref="DeliveryBook"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            IsReadOnly = false;
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(DeliveryInfo.GetDeliveryInfo(dr));
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

    }
}