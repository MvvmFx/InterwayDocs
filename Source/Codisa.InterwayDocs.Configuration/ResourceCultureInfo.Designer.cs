using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Codisa.InterwayDocs.Configuration
{

    /// <summary>
    /// ResourceCultureInfo (read only list).<br/>
    /// This is a generated <see cref="ResourceCultureInfo"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is child of <see cref="ResourceInfo"/> read only object.<br/>
    /// The items of the collection are <see cref="ResourceCultureList"/> objects.
    /// </remarks>
    [Serializable]
    public partial class ResourceCultureInfo : ReadOnlyBindingListBase<ResourceCultureInfo, ResourceCultureList>
    {

        #region Collection Business Methods

        /// <summary>
        /// Determines whether a <see cref="ResourceCultureList"/> item is in the collection.
        /// </summary>
        /// <param name="uICulture">The UICulture of the item to search for.</param>
        /// <returns><c>true</c> if the ResourceCultureList is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(string uICulture)
        {
            foreach (var resourceCultureList in this)
            {
                if (resourceCultureList.UICulture == uICulture)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="ResourceCultureInfo"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="ResourceCultureInfo"/> object.</returns>
        internal static ResourceCultureInfo GetResourceCultureInfo(SafeDataReader dr)
        {
            ResourceCultureInfo obj = new ResourceCultureInfo();
            obj.Fetch(dr);
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceCultureInfo"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ResourceCultureInfo()
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
        /// Loads all <see cref="ResourceCultureInfo"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            IsReadOnly = false;
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            var args = new DataPortalHookArgs(dr);
            OnFetchPre(args);
            while (dr.Read())
            {
                Add(ResourceCultureList.GetResourceCultureList(dr));
            }
            OnFetchPost(args);
            RaiseListChangedEvents = rlce;
            IsReadOnly = true;
        }

        /// <summary>
        /// Loads <see cref="ResourceCultureList"/> items on the ResourceCultures collection.
        /// </summary>
        /// <param name="collection">The grand parent <see cref="ResourceList"/> collection.</param>
        internal void LoadItems(ResourceList collection)
        {
            foreach (var item in this)
            {
                var obj = collection.FindResourceInfoByParentProperties(item.resourceId);
                obj.ResourceCultures.IsReadOnly = false;
                var rlce = obj.ResourceCultures.RaiseListChangedEvents;
                obj.ResourceCultures.RaiseListChangedEvents = false;
                obj.ResourceCultures.Add(item);
                obj.ResourceCultures.RaiseListChangedEvents = rlce;
                obj.ResourceCultures.IsReadOnly = true;
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
