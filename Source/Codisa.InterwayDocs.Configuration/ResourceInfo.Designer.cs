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
    /// This class contains one child collection:<br/>
    /// - <see cref="ResourceCultures"/> of type <see cref="ResourceCultureInfo"/> (1:M relation to <see cref="ResourceCultureList"/>)<br/>
    /// This class is an item of <see cref="ResourceList"/> collection.
    /// </remarks>
    [Serializable]
    public partial class ResourceInfo : ReadOnlyBase<ResourceInfo>
    {

        #region ParentList Property

        /// <summary>
        /// Maintains metadata about <see cref="ParentList"/> property.
        /// </summary>
        [NotUndoable, NonSerialized]
        public static readonly PropertyInfo<ResourceList> ParentListProperty = RegisterProperty<ResourceList>(p => p.ParentList);
        /// <summary>
        /// Provide access to the parent list reference for use in child object code.
        /// </summary>
        /// <value>The parent list reference.</value>
        public ResourceList ParentList
        {
            get { return ReadProperty(ParentListProperty); }
            internal set { LoadProperty(ParentListProperty, value); }
        }

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="ResourceId"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> ResourceIdProperty = RegisterProperty<int>(p => p.ResourceId, "Resource Id");
        /// <summary>
        /// Gets the Resource Id.
        /// </summary>
        /// <value>The Resource Id.</value>
        public int ResourceId
        {
            get { return GetProperty(ResourceIdProperty); }
        }

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
        /// Maintains metadata about child <see cref="ResourceCultures"/> property.
        /// </summary>
        public static readonly PropertyInfo<ResourceCultureInfo> ResourceCulturesProperty = RegisterProperty<ResourceCultureInfo>(p => p.ResourceCultures, "Resource Cultures");
        /// <summary>
        /// Gets the Resource Cultures ("parent load" child property).
        /// </summary>
        /// <value>The Resource Cultures.</value>
        public ResourceCultureInfo ResourceCultures
        {
            get { return GetProperty(ResourceCulturesProperty); }
            private set { LoadProperty(ResourceCulturesProperty, value); }
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
            obj.LoadProperty(ResourceCulturesProperty, new ResourceCultureInfo());
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
            LoadProperty(ResourceIdProperty, dr.GetInt32("ResourceId"));
            LoadProperty(ResourceTypeProperty, dr.GetString("ResourceType"));
            LoadProperty(ResourceNameProperty, dr.GetString("ResourceName"));
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Loads child objects from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        internal void FetchChildren(SafeDataReader dr)
        {
            dr.NextResult();
            var resourceCultureInfo = ResourceCultureInfo.GetResourceCultureInfo(dr);
            resourceCultureInfo.LoadItems(ParentList);
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
