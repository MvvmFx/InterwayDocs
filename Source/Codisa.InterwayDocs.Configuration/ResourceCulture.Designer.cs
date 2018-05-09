using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Codisa.InterwayDocs.Configuration
{

    /// <summary>
    /// ResourceCulture (editable child object).<br/>
    /// This is a generated <see cref="ResourceCulture"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="ResourceCultureColl"/> collection.
    /// </remarks>
    [Serializable]
    public partial class ResourceCulture : BusinessBase<ResourceCulture>
    {

        #region State Fields

        [NotUndoable, NonSerialized]
        internal int resourceId = 0;

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
        /// Maintains metadata about <see cref="Translation"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TranslationProperty = RegisterProperty<string>(p => p.Translation, "Translation");
        /// <summary>
        /// Gets or sets the Translation.
        /// </summary>
        /// <value>The Translation.</value>
        public string Translation
        {
            get { return GetProperty(TranslationProperty); }
            set { SetProperty(TranslationProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="ResourceCulture"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="ResourceCulture"/> object.</returns>
        internal static ResourceCulture NewResourceCulture()
        {
            return DataPortal.CreateChild<ResourceCulture>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="ResourceCulture"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="ResourceCulture"/> object.</returns>
        internal static ResourceCulture GetResourceCulture(SafeDataReader dr)
        {
            ResourceCulture obj = new ResourceCulture();
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
        /// Initializes a new instance of the <see cref="ResourceCulture"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ResourceCulture()
        {
            // Use factory methods and do not use direct creation.

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads default values for the <see cref="ResourceCulture"/> object properties.
        /// </summary>
        [RunLocal]
        protected override void Child_Create()
        {
            var args = new DataPortalHookArgs();
            OnCreate(args);
            base.Child_Create();
        }

        /// <summary>
        /// Loads a <see cref="ResourceCulture"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(UICultureProperty, dr.GetString("UICulture"));
            LoadProperty(TranslationProperty, dr.GetString("Translation"));
            // parent properties
            resourceId = dr.GetInt32("ResourceId");
            var args = new DataPortalHookArgs(dr);
            OnFetchRead(args);
        }

        /// <summary>
        /// Inserts a new <see cref="ResourceCulture"/> object in the database.
        /// </summary>
        /// <param name="parent">The parent object.</param>
        private void Child_Insert(Resource parent)
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager(Database.InterwayDocsConnection, false))
            {
                using (var cmd = new SqlCommand("dbo.AddResourceCulture", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ResourceId", parent.ResourceId).DbType = DbType.Int32;
                    cmd.Parameters.AddWithValue("@UICulture", ReadProperty(UICultureProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Translation", ReadProperty(TranslationProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnInsertPre(args);
                    cmd.ExecuteNonQuery();
                    OnInsertPost(args);
                }
            }
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="ResourceCulture"/> object.
        /// </summary>
        private void Child_Update()
        {
            if (!IsDirty)
                return;

            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager(Database.InterwayDocsConnection, false))
            {
                using (var cmd = new SqlCommand("dbo.UpdateResourceCulture", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UICulture", ReadProperty(UICultureProperty)).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@Translation", ReadProperty(TranslationProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnUpdatePre(args);
                    cmd.ExecuteNonQuery();
                    OnUpdatePost(args);
                }
            }
        }

        /// <summary>
        /// Self deletes the <see cref="ResourceCulture"/> object from database.
        /// </summary>
        private void Child_DeleteSelf()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager(Database.InterwayDocsConnection, false))
            {
                using (var cmd = new SqlCommand("dbo.DeleteResourceCulture", ctx.Connection))
                {
                    cmd.Transaction = ctx.Transaction;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@UICulture", ReadProperty(UICultureProperty)).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd);
                    OnDeletePre(args);
                    cmd.ExecuteNonQuery();
                    OnDeletePost(args);
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
