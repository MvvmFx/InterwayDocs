using System.Collections.Generic;
using System.Linq;
using Csla;

namespace Codisa.InterwayDocs.Configuration
{
    public partial class PropertyConfigurationList
    {

        #region Private Fields

        private static readonly PropertyConfigurationList CachedList = new PropertyConfigurationList();

        private static readonly object LockObject = new object();

        #endregion

        #region Cache Management Methods

        /// <summary>
        /// Clears the in-memory PropertyConfigurationList cache so it is reloaded on the next request.
        /// </summary>
        public static void InvalidateCache()
        {
            CachedList.Clear();
        }

        /// <summary>
        /// Determines whether a <see cref="PropertyConfigurationInfo"/> item is in the collection.
        /// </summary>
        /// <param name="objectName">The ObjectName of the item to search for.</param>
        /// <param name="uICulture">The UICulture of the item to search for.</param>
        /// <returns><c>true</c> if the PropertyConfigurationInfo is a collection item; otherwise, <c>false</c>.</returns>
        public static bool CacheContainsObject(string objectName, string uICulture)
        {
            return CachedList.Any(propertyConfigurationInfo =>
                propertyConfigurationInfo.ObjectName == objectName &&
                propertyConfigurationInfo.UICulture == uICulture);
        }

        /// <summary>
        /// Determines whether a <see cref="PropertyConfigurationInfo"/> item is in the collection.
        /// </summary>
        /// <param name="objectName">The ObjectName of the item to search for.</param>
        /// <param name="uICulture">The UICulture of the item to search for.</param>
        /// <returns><c>true</c> if the PropertyConfigurationInfo is a collection item; otherwise, <c>false</c>.</returns>
        public static PropertyConfigurationList GetCachedList(string objectName, string uICulture)
        {
            /*List<PropertyConfigurationInfo> list = (from propertyConfigurationInfo in _list
                where propertyConfigurationInfo.ObjectName == objectName &&
                      propertyConfigurationInfo.UICulture == uICulture
                select propertyConfigurationInfo).ToList();*/


            /*var list = new List<PropertyConfigurationInfo>();
            foreach (var propertyConfigurationInfo in _list)
            {
                if (propertyConfigurationInfo.ObjectName == objectName && propertyConfigurationInfo.UICulture == uICulture)
                {
                    list.Add(propertyConfigurationInfo);
                }
            }*/

            List<PropertyConfigurationInfo> list = CachedList
                .Where(propertyConfigurationInfo => propertyConfigurationInfo.ObjectName == objectName &&
                                                    propertyConfigurationInfo.UICulture == uICulture)
                .Select(propertyConfigurationInfo => propertyConfigurationInfo).ToList();

            var result = new PropertyConfigurationList {RaiseListChangedEvents = false, IsReadOnly = false};
            result.AddRange(list);
            result.IsReadOnly = true;
            return result;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="PropertyConfigurationList"/> collection, based on given parameters.
        /// </summary>
        /// <param name="objectName">The ObjectName parameter of the PropertyConfigurationList to fetch.</param>
        /// <param name="uICulture">The UICulture parameter of the PropertyConfigurationList to fetch.</param>
        /// <returns>A reference to the fetched <see cref="PropertyConfigurationList"/> collection.</returns>
        public static PropertyConfigurationList GetPropertyConfigurationList(string objectName, string uICulture)
        {
            lock (LockObject)
            {
                if (!CacheContainsObject(objectName, uICulture))
                    DataPortal.Fetch<PropertyConfigurationList>(new CriteriaGet(objectName, uICulture));

                return GetCachedList(objectName, uICulture);
            }
        }

        #endregion

    }
}