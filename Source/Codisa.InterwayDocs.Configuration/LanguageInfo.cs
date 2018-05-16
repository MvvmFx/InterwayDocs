using System;
using Csla;

namespace Codisa.InterwayDocs.Configuration
{
    public partial class LanguageInfo
    {

        #region OnDeserialized actions

        /*/// <summary>
        /// This method is called on a newly deserialized object
        /// after deserialization is complete.
        /// </summary>
        /// <param name="context">Serialization context object.</param>
        protected override void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
        {
            base.OnDeserialized(context);
            // add your custom OnDeserialized actions here.
        }*/

        #endregion

        #region Static Fields

        private static int _lastIndex = -1;

        #endregion

        #region Implementation of DataPortal Hooks

        partial void OnFetchRead(DataPortalHookArgs args)
        {
            LoadProperty(IndexProperty, System.Threading.Interlocked.Increment(ref _lastIndex));
        }

        #endregion

    }
}