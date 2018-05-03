using System.Collections.Generic;
using System.Linq;
using Csla;

namespace Codisa.InterwayDocs.Configuration
{
    public partial class PropertyRequiredList
    {

        #region Private Fields

        private static PropertyRequiredList _list;

        private static readonly object LockObject = new object();

        #endregion

        #region Cache Management Methods

        /// <summary>
        /// Clears the in-memory DocClassNVL cache so it is reloaded on the next request.
        /// </summary>
        public static void InvalidateCache()
        {
            _list = null;
        }

        internal static bool IsCached
        {
            get { return _list != null; }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="PropertyRequiredList"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="PropertyRequiredList"/> collection.</returns>
        public static PropertyRequiredList GetPropertyRequiredList()
        {
            lock (LockObject)
            {
                if (_list == null)
                    _list = DataPortal.Fetch<PropertyRequiredList>();

                return _list;
            }
        }

        /// <summary>
        /// Factory method. Loads a <see cref="PropertyRequiredList"/> collection, based on given parameters.
        /// </summary>
        /// <param name="objectName">The ObjectName parameter of the PropertyRequiredList to fetch.</param>
        /// <returns>A reference to the fetched <see cref="PropertyRequiredList"/> collection.</returns>
        public static PropertyRequiredList GetPropertyRequiredList(string objectName)
        {
            if (!IsCached)
                GetPropertyRequiredList();

            List<PropertyRequiredInfo> list = _list
                .Where(propertyConfigurationInfo => propertyConfigurationInfo.ObjectName == objectName)
                .Select(propertyConfigurationInfo => propertyConfigurationInfo).ToList();

            var result = new PropertyRequiredList {RaiseListChangedEvents = false, IsReadOnly = false};
            result.AddRange(list);
            result.IsReadOnly = true;
            return result;
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