using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Codisa.InterwayDocs.Configuration
{

    /// <summary>
    /// PropertyConfigurationColl (editable root list).<br/>
    /// This is a generated base class of <see cref="PropertyConfigurationColl"/> business object.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="PropertyConfiguration"/> objects.
    /// </remarks>
    [Serializable]
    public partial class PropertyConfigurationColl : BusinessBindingListBase<PropertyConfigurationColl, PropertyConfiguration>
    {

        #region Find Methods

        /// <summary>
        /// Finds a <see cref="PropertyConfiguration"/> item of the <see cref="PropertyConfigurationColl"/> collection, based on item key properties.
        /// </summary>
        /// <param name="configurationId">The ConfigurationId.</param>
        /// <returns>A <see cref="PropertyConfiguration"/> object.</returns>
        public PropertyConfiguration FindPropertyConfigurationByParentProperties(int configurationId)
        {
            for (var i = 0; i < this.Count; i++)
            {
                if (this[i].ConfigurationId.Equals(configurationId))
                {
                    return this[i];
                }
            }

            return null;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="PropertyConfigurationColl"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="PropertyConfigurationColl"/> collection.</returns>
        public static PropertyConfigurationColl NewPropertyConfigurationColl()
        {
            return DataPortal.Create<PropertyConfigurationColl>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="PropertyConfigurationColl"/> collection.
        /// </summary>
        /// <returns>A reference to the fetched <see cref="PropertyConfigurationColl"/> collection.</returns>
        public static PropertyConfigurationColl GetPropertyConfigurationColl()
        {
            return DataPortal.Fetch<PropertyConfigurationColl>();
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyConfigurationColl"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public PropertyConfigurationColl()
        {
            // Use factory methods and do not use direct creation.

            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            AllowNew = true;
            AllowEdit = true;
            AllowRemove = true;
            RaiseListChangedEvents = rlce;
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="PropertyConfigurationColl"/> collection from the database.
        /// </summary>
        protected void DataPortal_Fetch()
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Database.InterwayDocsConnection, false))
            {
                using (var cmd = new SqlCommand("dbo.GetPropertyConfigurationColl", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    var args = new DataPortalHookArgs(cmd);
                    OnFetchPre(args);
                    LoadCollection(cmd);
                    OnFetchPost(args);
                }
            }
        }

        private void LoadCollection(SqlCommand cmd)
        {
            using (var dr = new SafeDataReader(cmd.ExecuteReader()))
            {
                Fetch(dr);
                if (this.Count > 0)
                    this[0].FetchChildren(dr);
            }
        }

        /// <summary>
        /// Loads all <see cref="PropertyConfigurationColl"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(PropertyConfiguration.GetPropertyConfiguration(dr));
            }
            RaiseListChangedEvents = rlce;
        }

        /// <summary>
        /// Updates in the database all changes made to the <see cref="PropertyConfigurationColl"/> object.
        /// </summary>
        protected override void DataPortal_Update()
        {
            using (var ctx = TransactionManager<SqlConnection, SqlTransaction>.GetManager(Database.InterwayDocsConnection, false))
            {
                base.Child_Update();
                ctx.Commit();
            }
        }

        #endregion

        #region DataPortal Hooks

        /// <summary>
        /// Occurs after setting query parameters and before the fetch operation.
        /// </summary>
        partial void OnFetchPre(DataPortalHookArgs args);

        /// <summary>
        /// Occurs after the fetch operation (object or collection is fully loaded and set up).
        /// </summary>
        partial void OnFetchPost(DataPortalHookArgs args);

        #endregion

    }
}
