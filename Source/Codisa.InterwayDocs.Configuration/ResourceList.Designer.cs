using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Codisa.InterwayDocs.Configuration
{

    /// <summary>
    /// ResourceList (read only list).<br/>
    /// This is a generated <see cref="ResourceList"/> business object.
    /// This class is a root collection.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="ResourceInfo"/> objects.
    /// </remarks>
    [Serializable]
    public partial class ResourceList : ReadOnlyBindingListBase<ResourceList, ResourceInfo>
    {

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceList"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ResourceList()
        {
            // Use factory methods and do not use direct creation.

            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            AllowNew = false;
            AllowEdit = false;
            AllowRemove = false;
            RaiseListChangedEvents = rlce;
        }

        #endregion

        #region Nested Criteria

        /// <summary>
        /// CriteriaGet criteria.
        /// </summary>
        [Serializable]
        protected class CriteriaGet
        {

            /// <summary>
            /// Gets the Resource Type.
            /// </summary>
            /// <value>The Resource Type.</value>
            public string ResourceType { get; private set; }

            /// <summary>
            /// Gets the UICulture.
            /// </summary>
            /// <value>The UICulture.</value>
            public string UICulture { get; private set; }

            /// <summary>
            /// Initializes a new instance of the <see cref="CriteriaGet"/> class.
            /// </summary>
            /// <remarks> A parameterless constructor is required by the MobileFormatter.</remarks>
            [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
            public CriteriaGet()
            {
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="CriteriaGet"/> class.
            /// </summary>
            /// <param name="resourceType">The ResourceType.</param>
            /// <param name="uICulture">The UICulture.</param>
            public CriteriaGet(string resourceType, string uICulture)
            {
                ResourceType = resourceType;
                UICulture = uICulture;
            }

            /// <summary>
            /// Determines whether the specified <see cref="System.Object"/> is equal to this instance.
            /// </summary>
            /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
            /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
            public override bool Equals(object obj)
            {
                if (obj is CriteriaGet)
                {
                    var c = (CriteriaGet) obj;
                    if (!ResourceType.Equals(c.ResourceType))
                        return false;
                    if (!UICulture.Equals(c.UICulture))
                        return false;
                    return true;
                }
                return false;
            }

            /// <summary>
            /// Returns a hash code for this instance.
            /// </summary>
            /// <returns>An hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
            public override int GetHashCode()
            {
                return string.Concat("CriteriaGet", ResourceType.ToString(), UICulture.ToString()).GetHashCode();
            }
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="ResourceList"/> collection from the database, based on given criteria.
        /// </summary>
        /// <param name="crit">The fetch criteria.</param>
        protected void DataPortal_Fetch(CriteriaGet crit)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Database.InterwayDocsConnection, false))
            {
                using (var cmd = new SqlCommand("dbo.GetResourceList", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ResourceType", crit.ResourceType).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@UICulture", crit.UICulture).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd, crit);
                    OnFetchPre(args);
                    CachedList.LoadCollection(cmd);
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
        /// Loads all <see cref="ResourceList"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            IsReadOnly = false;
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(ResourceInfo.GetResourceInfo(dr));
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
