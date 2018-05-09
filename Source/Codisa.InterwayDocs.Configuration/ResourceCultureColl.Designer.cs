using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Codisa.InterwayDocs.Configuration
{

    /// <summary>
    /// ResourceCultureColl (editable child list).<br/>
    /// This is a generated <see cref="ResourceCultureColl"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is child of <see cref="Resource"/> editable child object.<br/>
    /// The items of the collection are <see cref="ResourceCulture"/> objects.
    /// </remarks>
    [Serializable]
    public partial class ResourceCultureColl : BusinessBindingListBase<ResourceCultureColl, ResourceCulture>
    {

        #region Collection Business Methods

        /// <summary>
        /// Removes a <see cref="ResourceCulture"/> item from the collection.
        /// </summary>
        /// <param name="uICulture">The UICulture of the item to be removed.</param>
        public void Remove(string uICulture)
        {
            foreach (var resourceCulture in this)
            {
                if (resourceCulture.UICulture == uICulture)
                {
                    Remove(resourceCulture);
                    break;
                }
            }
        }

        /// <summary>
        /// Determines whether a <see cref="ResourceCulture"/> item is in the collection.
        /// </summary>
        /// <param name="uICulture">The UICulture of the item to search for.</param>
        /// <returns><c>true</c> if the ResourceCulture is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(string uICulture)
        {
            foreach (var resourceCulture in this)
            {
                if (resourceCulture.UICulture == uICulture)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Determines whether a <see cref="ResourceCulture"/> item is in the collection's DeletedList.
        /// </summary>
        /// <param name="uICulture">The UICulture of the item to search for.</param>
        /// <returns><c>true</c> if the ResourceCulture is a deleted collection item; otherwise, <c>false</c>.</returns>
        public bool ContainsDeleted(string uICulture)
        {
            foreach (var resourceCulture in DeletedList)
            {
                if (resourceCulture.UICulture == uICulture)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="ResourceCultureColl"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="ResourceCultureColl"/> collection.</returns>
        internal static ResourceCultureColl NewResourceCultureColl()
        {
            return DataPortal.CreateChild<ResourceCultureColl>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="ResourceCultureColl"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="ResourceCultureColl"/> object.</returns>
        internal static ResourceCultureColl GetResourceCultureColl(SafeDataReader dr)
        {
            ResourceCultureColl obj = new ResourceCultureColl();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.Fetch(dr);
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceCultureColl"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ResourceCultureColl()
        {
            // Use factory methods and do not use direct creation.

            // show the framework that this is a child object
            MarkAsChild();

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
        /// Loads all <see cref="ResourceCultureColl"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            var args = new DataPortalHookArgs(dr);
            OnFetchPre(args);
            while (dr.Read())
            {
                Add(ResourceCulture.GetResourceCulture(dr));
            }
            OnFetchPost(args);
            RaiseListChangedEvents = rlce;
        }

        /// <summary>
        /// Loads <see cref="ResourceCulture"/> items on the ResourceCultures collection.
        /// </summary>
        /// <param name="collection">The grand parent <see cref="ResourceColl"/> collection.</param>
        internal void LoadItems(ResourceColl collection)
        {
            foreach (var item in this)
            {
                var obj = collection.FindResourceByParentProperties(item.resourceId);
                var rlce = obj.ResourceCultures.RaiseListChangedEvents;
                obj.ResourceCultures.RaiseListChangedEvents = false;
                obj.ResourceCultures.Add(item);
                obj.ResourceCultures.RaiseListChangedEvents = rlce;
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
