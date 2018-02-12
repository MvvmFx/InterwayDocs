using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Codisa.InterwayDocs.Configuration
{

    /// <summary>
    /// PropertyFriendlyName (editable child object).<br/>
    /// This is a generated base class of <see cref="PropertyFriendlyName"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="PropertyFriendlyNameColl"/> collection.
    /// </remarks>
    [Serializable]
    public partial class PropertyFriendlyName : BusinessBase<PropertyFriendlyName>
    {

        #region State Fields

        [NotUndoable, NonSerialized]
        internal int configurationId = 0;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="UICulture"/> property.
        /// </summary>
        [NotUndoable]
        public static readonly PropertyInfo<string> UICultureProperty = RegisterProperty<string>(p => p.UICulture, "UICulture");
        /// <summary>
        /// Gets or sets the UICulture.
        /// </summary>
        /// <value>The UICulture.</value>
        public string UICulture
        {
            get { return GetProperty(UICultureProperty); }
            set { SetProperty(UICultureProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="FriendlyName"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> FriendlyNameProperty = RegisterProperty<string>(p => p.FriendlyName, "Friendly Name");
        /// <summary>
        /// Gets or sets the Friendly Name.
        /// </summary>
        /// <value>The Friendly Name.</value>
        public string FriendlyName
        {
            get { return GetProperty(FriendlyNameProperty); }
            set { SetProperty(FriendlyNameProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="PropertyFriendlyName"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="PropertyFriendlyName"/> object.</returns>
        internal static PropertyFriendlyName NewPropertyFriendlyName()
        {
            return DataPortal.CreateChild<PropertyFriendlyName>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="PropertyFriendlyName"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="PropertyFriendlyName"/> object.</returns>
        internal static PropertyFriendlyName GetPropertyFriendlyName(SafeDataReader dr)
        {
            PropertyFriendlyName obj = new PropertyFriendlyName();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.Fetch(dr);
            obj.MarkOld();
            // check all object rules and property rules
            obj.BusinessRules.CheckRules();
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyFriendlyName"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public PropertyFriendlyName()
        {
            // Use factory methods and do not use direct creation.

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="PropertyFriendlyName"/> object properties.
        /// </summary>
        [RunLocal]
        protected override void Child_Create()
        {
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="PropertyFriendlyName"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(UICultureProperty, dr.GetString("UICulture"));
            LoadProperty(FriendlyNameProperty, dr.GetString("FriendlyName"));
            // parent properties
            configurationId = dr.GetInt32("ConfigurationId");
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="PropertyFriendlyName"/> object.
        /// </summary>
        /// <param name="parent">The parent object.</param>
        private void Child_Update(PropertyConfiguration parent)
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager(Database.InterwayDocsConnection, false))
            {
                using (var cmd = new SqlCommand("dbo.UpdatePropertyFriendlyName", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ConfigurationId", parent.ConfigurationId).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@UICulture", ReadProperty(UICultureProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@FriendlyName", ReadProperty(FriendlyNameProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        #endregion

        #region DataPortal Hooks

        /// <summary>
        /// Occurs after setting all defaults for object creation.
        /// </summary>
        partial void OnCreate(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after setting query parameters and before the fetch operation.
        /// </summary>
        partial void OnFetchPre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after the fetch operation (object or collection is fully loaded and set up).
        /// </summary>
        partial void OnFetchPost(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after the low level fetch operation, before the data reader is destroyed.
        /// </summary>
        partial void OnFetchRead(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after setting query parameters and before the update operation.
        /// </summary>
        partial void OnUpdatePre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Insert, after the update operation, before setting back row identifiers (RowVersion) and Commit().
        /// </summary>
        partial void OnUpdatePost(DataPortalHookArgs args);

        #endregion

    }
}
