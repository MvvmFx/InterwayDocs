using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Codisa.InterwayDocs.Configuration
{

    /// <summary>
    /// ResourceInfo (read only object).<br/>
    /// This is a generated <see cref="ResourceInfo"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="ResourceList"/> collection.
    /// </remarks>
    [Serializable]
    public partial class ResourceInfo : ReadOnlyBase<ResourceInfo>
    {

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="ResourceType"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> ResourceTypeProperty = RegisterProperty<string>(p => p.ResourceType, "Resource Type");
        /// <summary>
        /// Gets the Resource Type.
        /// </summary>
        /// <value>The Resource Type.</value>
        public string ResourceType
        {
            get { return GetProperty(ResourceTypeProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ResourceName"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> ResourceNameProperty = RegisterProperty<string>(p => p.ResourceName, "Resource Name");
        /// <summary>
        /// Gets the Resource Name.
        /// </summary>
        /// <value>The Resource Name.</value>
        public string ResourceName
        {
            get { return GetProperty(ResourceNameProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="UICulture"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> UICultureProperty = RegisterProperty<string>(p => p.UICulture, "UICulture");
        /// <summary>
        /// Gets the UICulture.
        /// </summary>
        /// <value>The UICulture.</value>
        public string UICulture
        {
            get { return GetProperty(UICultureProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Translation"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TranslationProperty = RegisterProperty<string>(p => p.Translation, "Translation");
        /// <summary>
        /// Gets the Translation.
        /// </summary>
        /// <value>The Translation.</value>
        public string Translation
        {
            get { return GetProperty(TranslationProperty); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="ResourceInfo"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="ResourceInfo"/> object.</returns>
        internal static ResourceInfo GetResourceInfo(SafeDataReader dr)
        {
            ResourceInfo obj = new ResourceInfo();
            obj.Fetch(dr);
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceInfo"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ResourceInfo()
        {
            // Use factory methods and do not use direct creation.
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="ResourceInfo"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(ResourceTypeProperty, dr.GetString("ResourceType"));
            LoadProperty(ResourceNameProperty, dr.GetString("ResourceName"));
            LoadProperty(UICultureProperty, dr.GetString("UICulture"));
            LoadProperty(TranslationProperty, dr.GetString("Translation"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        #endregion

        #region DataPortal Hooks

        /// <summary>
        /// Occurs after the low level fetch operation, before the data reader is destroyed.
        /// </summary>
        partial void OnFetchRead(DataPortalHookArgs args);

        #endregion

    }
}
