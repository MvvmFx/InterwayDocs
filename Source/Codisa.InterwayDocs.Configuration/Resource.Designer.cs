using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Codisa.InterwayDocs.Configuration
{

    /// <summary>
    /// Resource (editable child object).<br/>
    /// This is a generated <see cref="Resource"/> business object.
    /// </summary>
    /// <remarks>
    /// This class contains one child collection:<br/>
    /// - <see cref="ResourceCultures"/> of type <see cref="ResourceCultureColl"/> (1:M relation to <see cref="ResourceCulture"/>)<br/>
    /// This class is an item of <see cref="ResourceColl"/> collection.
    /// </remarks>
    [Serializable]
    public partial class Resource : BusinessBase<Resource>
    {

        #region Static Fields

        private static int _lastId;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="ResourceId"/> property.
        /// </summary>
        [NotUndoable]
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
        /// Gets or sets the Resource Type.
        /// </summary>
        /// <value>The Resource Type.</value>
        public string ResourceType
        {
            get { return GetProperty(ResourceTypeProperty); }
            set { SetProperty(ResourceTypeProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="ResourceName"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> ResourceNameProperty = RegisterProperty<string>(p => p.ResourceName, "Resource Name");
        /// <summary>
        /// Gets or sets the Resource Name.
        /// </summary>
        /// <value>The Resource Name.</value>
        public string ResourceName
        {
            get { return GetProperty(ResourceNameProperty); }
            set { SetProperty(ResourceNameProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about child <see cref="ResourceCultures"/> property.
        /// </summary>
        public static readonly PropertyInfo<ResourceCultureColl> ResourceCulturesProperty = RegisterProperty<ResourceCultureColl>(p => p.ResourceCultures, "Resource Cultures", RelationshipTypes.Child);
        /// <summary>
        /// Gets the Resource Cultures ("parent load" child property).
        /// </summary>
        /// <value>The Resource Cultures.</value>
        public ResourceCultureColl ResourceCultures
        {
            get { return GetProperty(ResourceCulturesProperty); }
            private set { LoadProperty(ResourceCulturesProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="Resource"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="Resource"/> object.</returns>
        internal static Resource NewResource()
        {
            return DataPortal.CreateChild<Resource>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="Resource"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="Resource"/> object.</returns>
        internal static Resource GetResource(SafeDataReader dr)
        {
            Resource obj = new Resource();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.Fetch(dr);
            obj.LoadProperty(ResourceCulturesProperty, ResourceCultureColl.NewResourceCultureColl());
            obj.MarkOld();
            // check all object rules and property rules
            obj.BusinessRules.CheckRules();
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Resource"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Resource()
        {
            // Use factory methods and do not use direct creation.

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="Resource"/> object properties.
        /// </summary>
        [RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(ResourceIdProperty, System.Threading.Interlocked.Decrement(ref _lastId));
            LoadProperty(ResourceCulturesProperty, DataPortal.CreateChild<ResourceCultureColl>());
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="Resource"/> object from the given SafeDataReader.
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
            var resourceCultureColl = ResourceCultureColl.GetResourceCultureColl(dr);
            resourceCultureColl.LoadItems((ResourceColl)Parent);
        }

        /// <summary>
        /// Inserts a new <see cref="Resource"/> object in the database.
        /// </summary>
        private void Child_Insert()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager(Database.InterwayDocsConnection, false))
            {
                using (var cmd = new SqlCommand("dbo.AddResource", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ResourceId", ReadProperty(ResourceIdProperty)).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@ResourceType", ReadProperty(ResourceTypeProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ResourceName", ReadProperty(ResourceNameProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                    LoadProperty(ResourceIdProperty, (int) cmd.Parameters["@ResourceId"].Value);
                }
                // flushes all pending data operations
                FieldManager.UpdateChildren(this);
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="Resource"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager(Database.InterwayDocsConnection, false))
            {
                using (var cmd = new SqlCommand("dbo.UpdateResource", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ResourceId", ReadProperty(ResourceIdProperty)).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@ResourceType", ReadProperty(ResourceTypeProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@ResourceName", ReadProperty(ResourceNameProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
                // flushes all pending data operations
                FieldManager.UpdateChildren(this);
            }
        }

        /// <summary>
        /// Self deletes the <see cref="Resource"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager(Database.InterwayDocsConnection, false))
            {
                // flushes all pending data operations
                FieldManager.UpdateChildren(this);
                using (var cmd = new SqlCommand("dbo.DeleteResource", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ResourceId", ReadProperty(ResourceIdProperty)).DbType = DbType.Int32;
                    var args = new DataPortalHookArgs(cmd);
                    OnDeletePre(args);
                    cmd.ExecuteNonQuery();
                    OnDeletePost(args);
                }
            }
            // removes all previous references to children
            LoadProperty(ResourceCulturesProperty, DataPortal.CreateChild<ResourceCultureColl>());
        }

        #endregion

        #region DataPortal Hooks

        /// <summary>
        /// Occurs after setting all defaults for object creation.
        /// </summary>
        partial void OnCreate(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Delete, after setting query parameters and before the delete operation.
        /// </summary>
        partial void OnDeletePre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Delete, after the delete operation, before Commit().
        /// </summary>
        partial void OnDeletePost(DataPortalHookArgs args);

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

        /// <summary>
        /// Occurs in DataPortal_Insert, after setting query parameters and before the insert operation.
        /// </summary>
        partial void OnInsertPre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs in DataPortal_Insert, after the insert operation, before setting back row identifiers (ID and RowVersion) and Commit().
        /// </summary>
        partial void OnInsertPost(DataPortalHookArgs args);

        #endregion

    }
}
