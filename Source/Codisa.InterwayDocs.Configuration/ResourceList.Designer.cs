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

        #region Collection Business Methods

        /// <summary>
        /// Adds a new <see cref="ResourceInfo"/> item to the collection.
        /// </summary>
        /// <param name="item">The item to add.</param>
        /// <remarks>
        /// There is no valid Parent property (inexistant or null).
        /// The Add method is redefined so it takes care of filling the ParentList property.
        /// </remarks>
        public new void Add(ResourceInfo item)
        {
            item.ParentList = this;
            base.Add(item);
        }

        /// <summary>
        /// Determines whether a <see cref="ResourceInfo"/> item is in the collection.
        /// </summary>
        /// <param name="resourceId">The ResourceId of the item to search for.</param>
        /// <returns><c>true</c> if the ResourceInfo is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(int resourceId)
        {
            foreach (var resourceInfo in this)
            {
                if (resourceInfo.ResourceId == resourceId)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Find Methods

        /// <summary>
        /// Finds a <see cref="ResourceInfo"/> item of the <see cref="ResourceList"/> collection, based on item key properties.
        /// </summary>
        /// <param name="resourceId">The ResourceId.</param>
        /// <returns>A <see cref="ResourceInfo"/> object.</returns>
        public ResourceInfo FindResourceInfoByParentProperties(int resourceId)
        {
            for (var i = 0; i < this.Count; i++)
            {
                if (this[i].ResourceId.Equals(resourceId))
                {
                    return this[i];
                }
            }

            return null;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="ResourceList"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="ResourceList"/> collection.</returns>
        public static ResourceList GetResourceList()
        {
            return DataPortal.Fetch<ResourceList>();
        }

        #endregion

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

        #region Data Access

        /// <summary>
        /// Loads a <see cref="ResourceList"/> collection from the database.
        /// </summary>
        protected void DataPortal_Fetch()
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Database.InterwayDocsConnection, false))
            {
                using (var cmd = new SqlCommand("dbo.GetResourceList", ctx.Connection))
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
                if (this.Count > 0)
                    this[0].FetchChildren(dr);
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
