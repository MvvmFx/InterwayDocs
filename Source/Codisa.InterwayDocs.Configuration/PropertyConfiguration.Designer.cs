using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Codisa.InterwayDocs.Configuration
{

    /// <summary>
    /// PropertyConfiguration (editable child object).<br/>
    /// This is a generated base class of <see cref="PropertyConfiguration"/> business object.
    /// </summary>
    /// <remarks>
    /// This class contains one child collection:<br/>
    /// - <see cref="FriendlyNames"/> of type <see cref="PropertyFriendlyNameColl"/> (1:M relation to <see cref="PropertyFriendlyName"/>)<br/>
    /// This class is an item of <see cref="PropertyConfigurationColl"/> collection.
    /// </remarks>
    [Serializable]
    public partial class PropertyConfiguration : BusinessBase<PropertyConfiguration>
    {

        #region Static Fields

        private static int _lastId;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="ConfigurationId"/> property.
        /// </summary>
        [NotUndoable]
        public static readonly PropertyInfo<int> ConfigurationIdProperty = RegisterProperty<int>(p => p.ConfigurationId, "Configuration Id");
        /// <summary>
        /// Gets the Configuration Id.
        /// </summary>
        /// <value>The Configuration Id.</value>
        public int ConfigurationId
        {
            get { return GetProperty(ConfigurationIdProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ObjectName"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> ObjectNameProperty = RegisterProperty<string>(p => p.ObjectName, "Object Name");
        /// <summary>
        /// Gets or sets the Object Name.
        /// </summary>
        /// <value>The Object Name.</value>
        public string ObjectName
        {
            get { return GetProperty(ObjectNameProperty); }
            set { SetProperty(ObjectNameProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Name"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> NameProperty = RegisterProperty<string>(p => p.Name, "Name");
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>The Name.</value>
        public string Name
        {
            get { return GetProperty(NameProperty); }
            set { SetProperty(NameProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IsRequired"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool> IsRequiredProperty = RegisterProperty<bool>(p => p.IsRequired, "Is Required");
        /// <summary>
        /// Gets or sets the Is Required.
        /// </summary>
        /// <value><c>true</c> if Is Required; otherwise, <c>false</c>.</value>
        public bool IsRequired
        {
            get { return GetProperty(IsRequiredProperty); }
            set { SetProperty(IsRequiredProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IsReadOnly"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool> IsReadOnlyProperty = RegisterProperty<bool>(p => p.IsReadOnly, "Is Read Only");
        /// <summary>
        /// Gets or sets the Is Read Only.
        /// </summary>
        /// <value><c>true</c> if Is Read Only; otherwise, <c>false</c>.</value>
        public bool IsReadOnly
        {
            get { return GetProperty(IsReadOnlyProperty); }
            set { SetProperty(IsReadOnlyProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="IsVisible"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool> IsVisibleProperty = RegisterProperty<bool>(p => p.IsVisible, "Is Visible");
        /// <summary>
        /// Gets or sets the Is Visible.
        /// </summary>
        /// <value><c>true</c> if Is Visible; otherwise, <c>false</c>.</value>
        public bool IsVisible
        {
            get { return GetProperty(IsVisibleProperty); }
            set { SetProperty(IsVisibleProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ListOrder"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> ListOrderProperty = RegisterProperty<int>(p => p.ListOrder, "List Order");
        /// <summary>
        /// Gets or sets the List Order.
        /// </summary>
        /// <value>The List Order.</value>
        public int ListOrder
        {
            get { return GetProperty(ListOrderProperty); }
            set { SetProperty(ListOrderProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about child <see cref="FriendlyNames"/> property.
        /// </summary>
        public static readonly PropertyInfo<PropertyFriendlyNameColl> FriendlyNamesProperty = RegisterProperty<PropertyFriendlyNameColl>(p => p.FriendlyNames, "Friendly Names", RelationshipTypes.Child);
        /// <summary>
        /// Gets the Friendly Names ("parent load" child property).
        /// </summary>
        /// <value>The Friendly Names.</value>
        public PropertyFriendlyNameColl FriendlyNames
        {
            get { return GetProperty(FriendlyNamesProperty); }
            private set { LoadProperty(FriendlyNamesProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="PropertyConfiguration"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="PropertyConfiguration"/> object.</returns>
        internal static PropertyConfiguration NewPropertyConfiguration()
        {
            return DataPortal.CreateChild<PropertyConfiguration>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="PropertyConfiguration"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="PropertyConfiguration"/> object.</returns>
        internal static PropertyConfiguration GetPropertyConfiguration(SafeDataReader dr)
        {
            PropertyConfiguration obj = new PropertyConfiguration();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.Fetch(dr);
            obj.LoadProperty(FriendlyNamesProperty, PropertyFriendlyNameColl.NewPropertyFriendlyNameColl());
            obj.MarkOld();
            // check all object rules and property rules
            obj.BusinessRules.CheckRules();
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyConfiguration"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public PropertyConfiguration()
        {
            // Use factory methods and do not use direct creation.

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="PropertyConfiguration"/> object properties.
        /// </summary>
        [RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(ConfigurationIdProperty, System.Threading.Interlocked.Decrement(ref _lastId));
            LoadProperty(FriendlyNamesProperty, DataPortal.CreateChild<PropertyFriendlyNameColl>());
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="PropertyConfiguration"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(ConfigurationIdProperty, dr.GetInt32("ConfigurationId"));
            LoadProperty(ObjectNameProperty, dr.GetString("ObjectName"));
            LoadProperty(NameProperty, dr.GetString("Name"));
            LoadProperty(IsRequiredProperty, dr.GetBoolean("IsRequired"));
            LoadProperty(IsReadOnlyProperty, dr.GetBoolean("IsReadOnly"));
            LoadProperty(IsVisibleProperty, dr.GetBoolean("IsVisible"));
            LoadProperty(ListOrderProperty, dr.GetInt32("ListOrder"));
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
            var propertyFriendlyNameColl = PropertyFriendlyNameColl.GetPropertyFriendlyNameColl(dr);
            propertyFriendlyNameColl.LoadItems((PropertyConfigurationColl)Parent);
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="PropertyConfiguration"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager(Database.InterwayDocsConnection, false))
            {
                using (var cmd = new SqlCommand("dbo.UpdatePropertyConfiguration", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ConfigurationId", ReadProperty(ConfigurationIdProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@IsRequired", ReadProperty(IsRequiredProperty)).DbType = DbType.Boolean;
                    cmd.Parameters.AddWithValue("@IsReadOnly", ReadProperty(IsReadOnlyProperty)).DbType = DbType.Boolean;
                    cmd.Parameters.AddWithValue("@IsVisible", ReadProperty(IsVisibleProperty)).DbType = DbType.Boolean;
                    cmd.Parameters.AddWithValue("@ListOrder", ReadProperty(ListOrderProperty)).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                // flushes all pending data operations
                FieldManager.UpdateChildren(this);
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
