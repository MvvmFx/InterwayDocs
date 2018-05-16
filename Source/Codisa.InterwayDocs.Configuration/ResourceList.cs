using System.Collections.Generic;
using System.Linq;
using Csla;

namespace Codisa.InterwayDocs.Configuration
{
    public partial class ResourceList
    {

        #region Private Fields

        private static readonly ResourceList CachedList = new ResourceList();

        #endregion

        #region Cache Management Methods

        /// <summary>
        /// Clears the in-memory ResourceList cache so it is reloaded on the next request.
        /// </summary>
        public static void InvalidateCache()
        {
            CachedList.Clear();
        }

        /// <summary>
        /// Determines whether a <see cref="ResourceInfo"/> item is in the collection.
        /// </summary>
        /// <param name="resourceType">The ResourceType of the item to search for.</param>
        /// <param name="uICulture">The UICulture of the item to search for.</param>
        /// <returns><c>true</c> if the ResourceInfo is a collection item; otherwise, <c>false</c>.</returns>
        public static bool CacheContainsObject(string resourceType, string uICulture)
        {
            return CachedList.Any(resourceInfo =>
                resourceInfo.ResourceType == resourceType &&
                resourceInfo.UICulture == uICulture);
        }

        /// <summary>
        /// Determines whether a <see cref="ResourceInfo"/> item is in the collection.
        /// </summary>
        /// <param name="resourceType">The ResourceType of the item to search for.</param>
        /// <param name="uICulture">The UICulture of the item to search for.</param>
        /// <returns><c>true</c> if the ResourceInfo is a collection item; otherwise, <c>false</c>.</returns>
        public static ResourceList GetCachedList(string resourceType, string uICulture)
        {
            /*List<ResourceInfo> list = (from resourceInfo in _list
                where resourceInfo.ResourceType == resourceType &&
                      resourceInfo.UICulture == uICulture
                select resourceInfo).ToList();*/

            /*var list = new List<ResourceInfo>();
            foreach (var resourceInfo in _list)
            {
                if (resourceInfo.ResourceType == resourceType && resourceInfo.UICulture == uICulture)
                {
                    list.Add(resourceInfo);
                }
            }*/

            List<ResourceInfo> list = CachedList
                .Where(resourceInfo => resourceInfo.ResourceType == resourceType &&
                                       resourceInfo.UICulture == uICulture)
                .Select(resourceInfo => resourceInfo).ToList();

            var result = new ResourceList {RaiseListChangedEvents = false, IsReadOnly = false};
            result.AddRange(list);
            result.IsReadOnly = true;
            return result;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="ResourceList"/> collection, based on given parameters.
        /// </summary>
        /// <param name="resourceType">The ResourceType parameter of the ResourceList to fetch.</param>
        /// <param name="uICulture">The UICulture parameter of the ResourceList to fetch.</param>
        /// <returns>A reference to the fetched <see cref="ResourceList"/> collection.</returns>
        public static ResourceList GetResourceList(string resourceType, string uICulture)
        {
            if (!CacheContainsObject(resourceType, uICulture))
                DataPortal.Fetch<ResourceList>(new CriteriaGet(resourceType, uICulture));

            return GetCachedList(resourceType, uICulture);
        }

        #endregion

        #region OnDeserialized actions

        /*/// <summary>
        /// This method is called on a newly deserialized object
        /// after deserialization is complete.
        /// </summary>
        protected override void OnDeserialized()
        {
            base.OnDeserialized();
            // add your custom OnDeserialized actions here.
        }*/

        #endregion

        #region Implementation of DataPortal Hooks

        //partial void OnFetchPre(DataPortalHookArgs args)
        //{
        //    throw new NotImplementedException();
        //}

        //partial void OnFetchPost(DataPortalHookArgs args)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

    }
}