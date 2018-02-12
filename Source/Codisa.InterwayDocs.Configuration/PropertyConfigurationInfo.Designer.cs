using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Codisa.InterwayDocs.Configuration
{

    /// <summary>
    /// PropertyConfigurationInfo (read only object).<br/>
    /// This is a generated base class of <see cref="PropertyConfigurationInfo"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="PropertyConfigurationList"/> collection.
    /// </remarks>
    [Serializable]
    public partial class PropertyConfigurationInfo : ReadOnlyBase<PropertyConfigurationInfo>
    {

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="ObjectName"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> ObjectNameProperty = RegisterProperty<string>(p => p.ObjectName, "Object Name");
        /// <summary>
        /// Gets the Object Name.
        /// </summary>
        /// <value>The Object Name.</value>
        public string ObjectName
        {
            get { return GetProperty(ObjectNameProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Name"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(p => p.Name, "Name");
        /// <summary>
        /// Gets the Name.
        /// </summary>
        /// <value>The Name.</value>
        public string Name
        {
            get { return GetProperty(NameProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="UICulture"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> UICultureProperty = RegisterProperty<string>(p => p.UICulture, "UI Culture");
        /// <summary>
        /// Gets the UI Culture.
        /// </summary>
        /// <value>The UI Culture.</value>
        public string UICulture
        {
            get { return GetProperty(UICultureProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="FriendlyName"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> FriendlyNameProperty = RegisterProperty<string>(p => p.FriendlyName, "Friendly Name");
        /// <summary>
        /// Gets the Friendly Name.
        /// </summary>
        /// <value>The Friendly Name.</value>
        public string FriendlyName
        {
            get { return GetProperty(FriendlyNameProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IsRequired"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool> IsRequiredProperty = RegisterProperty<bool>(p => p.IsRequired, "Is Required");
        /// <summary>
        /// Gets the Is Required.
        /// </summary>
        /// <value><c>true</c> if Is Required; otherwise, <c>false</c>.</value>
        public bool IsRequired
        {
            get { return GetProperty(IsRequiredProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IsReadOnly"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool> IsReadOnlyProperty = RegisterProperty<bool>(p => p.IsReadOnly, "Is Read Only");
        /// <summary>
        /// Gets the Is Read Only.
        /// </summary>
        /// <value><c>true</c> if Is Read Only; otherwise, <c>false</c>.</value>
        public bool IsReadOnly
        {
            get { return GetProperty(IsReadOnlyProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IsVisible"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool> IsVisibleProperty = RegisterProperty<bool>(p => p.IsVisible, "Is Visible");
        /// <summary>
        /// Gets the Is Visible.
        /// </summary>
        /// <value><c>true</c> if Is Visible; otherwise, <c>false</c>.</value>
        public bool IsVisible
        {
            get { return GetProperty(IsVisibleProperty); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="PropertyConfigurationInfo"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="PropertyConfigurationInfo"/> object.</returns>
        internal static PropertyConfigurationInfo GetPropertyConfigurationInfo(SafeDataReader dr)
        {
            PropertyConfigurationInfo obj = new PropertyConfigurationInfo();
            obj.Fetch(dr);
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyConfigurationInfo"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public PropertyConfigurationInfo()
        {
            // Use factory methods and do not use direct creation.
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="PropertyConfigurationInfo"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(ObjectNameProperty, dr.GetString("ObjectName"));
            LoadProperty(NameProperty, dr.GetString("Name"));
            LoadProperty(UICultureProperty, dr.GetString("UICulture"));
            LoadProperty(FriendlyNameProperty, dr.GetString("FriendlyName"));
            LoadProperty(IsRequiredProperty, dr.GetBoolean("IsRequired"));
            LoadProperty(IsReadOnlyProperty, dr.GetBoolean("IsReadOnly"));
            LoadProperty(IsVisibleProperty, dr.GetBoolean("IsVisible"));
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
