using System;
using Csla;

namespace Codisa.InterwayDocs.Configuration
{
    public partial class PropertyRequiredList
    {

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="PropertyRequiredList"/> collection, based on given parameters.
        /// </summary>
        /// <param name="objectName">The ObjectName parameter of the PropertyRequiredList to fetch.</param>
        /// <returns>A reference to the fetched <see cref="PropertyRequiredList"/> collection.</returns>
        public static PropertyRequiredList GetPropertyRequiredList(string objectName)
        {
            var list = GetPropertyRequiredList();

            var result = new PropertyRequiredList();

            result.RaiseListChangedEvents = false;
            result.IsReadOnly = false;
            foreach (var entry in list)
            {
                if (entry.ObjectName == objectName)
                    result.Add(entry);
            }
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
