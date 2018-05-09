using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Codisa.InterwayDocs.Configuration
{

    /// <summary>
    /// ResourceColl (editable root list).<br/>
    /// This is a generated <see cref="ResourceColl"/> business object.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="Resource"/> objects.
    /// </remarks>
    [Serializable]
    public partial class ResourceColl : BusinessBindingListBase<ResourceColl, Resource>
    {

        #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="Resource"/> item from the collection.
        /// </summary>
        /// <param name="resourceId">The ResourceId of the item to be removed.</param>
        public void Remove(int resourceId)
        {
            foreach (var resource in this)
            {
                if (resource.ResourceId == resourceId)
                {
                    Remove(resource);
                    break;
                }
            }
        }

        /// <summary>
        /// Determines whether a <see cref="Resource"/> item is in the collection.
        /// </summary>
        /// <param name="resourceId">The ResourceId of the item to search for.</param>
        /// <returns><c>true</c> if the Resource is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(int resourceId)
        {
            foreach (var resource in this)
            {
                if (resource.ResourceId == resourceId)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether a <see cref="Resource"/> item is in the collection's DeletedList.
        /// </summary>
        /// <param name="resourceId">The ResourceId of the item to search for.</param>
        /// <returns><c>true</c> if the Resource is a deleted collection item; otherwise, <c>false</c>.</returns>
        public bool ContainsDeleted(int resourceId)
        {
            foreach (var resource in DeletedList)
            {
                if (resource.ResourceId == resourceId)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Find Methods

        /// <summary>
        /// Finds a <see cref="Resource"/> item of the <see cref="ResourceColl"/> collection, based on item key properties.
        /// </summary>
        /// <param name="resourceId">The ResourceId.</param>
        /// <returns>A <see cref="Resource"/> object.</returns>
        public Resource FindResourceByParentProperties(int resourceId)
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
        /// Factory method. Creates a new <see cref="ResourceColl"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="ResourceColl"/> collection.</returns>
        public static ResourceColl NewResourceColl()
        {
            return DataPortal.Create<ResourceColl>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="ResourceColl"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="ResourceColl"/> collection.</returns>
        public static ResourceColl GetResourceColl()
        {
            return DataPortal.Fetch<ResourceColl>();
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceColl"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ResourceColl()
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
        /// Loads a <see cref="ResourceColl"/> collection from the database.
        /// </summary>
        protected void DataPortal_Fetch()
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Database.InterwayDocsConnection, false))
            {
                using (var cmd = new SqlCommand("dbo.GetResourceColl", ctx.Connection))
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
        /// Loads all <see cref="ResourceColl"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(Resource.GetResource(dr));
            }
            RaiseListChangedEvents = rlce;
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="ResourceColl"/> object.
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
