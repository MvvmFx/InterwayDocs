using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Codisa.InterwayDocs.Configuration
{

    /// <summary>
    /// PropertyRequiredInfo (read only object).<br/>
    /// This is a generated base class of <see cref="PropertyRequiredInfo"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="PropertyRequiredList"/> collection.
    /// </remarks>
    [Serializable]
    public partial class PropertyRequiredInfo : ReadOnlyBase<PropertyRequiredInfo>
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

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="PropertyRequiredInfo"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="PropertyRequiredInfo"/> object.</returns>
        internal static PropertyRequiredInfo GetPropertyRequiredInfo(SafeDataReader dr)
        {
            PropertyRequiredInfo obj = new PropertyRequiredInfo();
            obj.Fetch(dr);
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyRequiredInfo"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public PropertyRequiredInfo()
        {
            // Use factory methods and do not use direct creation.
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="PropertyRequiredInfo"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(ObjectNameProperty, dr.GetString("ObjectName"));
            LoadProperty(NameProperty, dr.GetString("Name"));
            LoadProperty(IsRequiredProperty, dr.GetBoolean("IsRequired"));
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
