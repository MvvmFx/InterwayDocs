using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Codisa.InterwayDocs.Configuration
{

    /// <summary>
    /// PropertyConfigurationList (read only list).<br/>
    /// This is a generated base class of <see cref="PropertyConfigurationList"/> business object.
    /// This class is a root collection.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="PropertyConfigurationInfo"/> objects.
    /// </remarks>
    [Serializable]
    public partial class PropertyConfigurationList : ReadOnlyBindingListBase<PropertyConfigurationList, PropertyConfigurationInfo>
    {

        #region Collection Business Methods

        /// <summary>
        /// Determines whether a <see cref="PropertyConfigurationInfo"/> item is in the collection.
        /// </summary>
        /// <param name="objectName">The ObjectName of the item to search for.</param>
        /// <param name="name">The Name of the item to search for.</param>
        /// <param name="uICulture">The UICulture of the item to search for.</param>
        /// <returns><c>true</c> if the PropertyConfigurationInfo is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(string objectName, string name, string uICulture)
        {
            foreach (var propertyConfigurationInfo in this)
            {
                if (propertyConfigurationInfo.ObjectName == objectName && propertyConfigurationInfo.Name == name && propertyConfigurationInfo.UICulture == uICulture)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Find Methods

        /// <summary>
        /// Finds a <see cref="PropertyConfigurationInfo"/> item of the <see cref="PropertyConfigurationList"/> collection, based on a given Name.
        /// </summary>
        /// <param name="name">The Name.</param>
        /// <returns>A <see cref="PropertyConfigurationInfo"/> object.</returns>
        public PropertyConfigurationInfo FindPropertyConfigurationInfoByName(string name)
        {
            for (var i = 0; i < this.Count; i++)
            {
                if (this[i].Name.Equals(name))
                {
                    return this[i];
                }
            }

            return null;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="PropertyConfigurationList"/> collection, based on given parameters.
        /// </summary>
        /// <param name="objectName">The ObjectName parameter of the PropertyConfigurationList to fetch.</param>
        /// <param name="uICulture">The UICulture parameter of the PropertyConfigurationList to fetch.</param>
        /// <returns>A reference to the fetched <see cref="PropertyConfigurationList"/> collection.</returns>
        public static PropertyConfigurationList GetPropertyConfigurationList(string objectName, string uICulture)
        {
            return DataPortal.Fetch<PropertyConfigurationList>(new CriteriaGet(objectName, uICulture));
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyConfigurationList"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public PropertyConfigurationList()
        {
            // Use factory methods and do not use direct creation.

            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            AllowNew = false;
            AllowEdit = false;
            AllowRemove = false;
            RaiseListChangedEvents = rlce;
        }

        #endregion

        #region Criteria

        /// <summary>
        /// CriteriaGet criteria.
        /// </summary>
        [Serializable]
        protected class CriteriaGet
        {

            /// <summary>
            /// Gets the Object Name.
            /// </summary>
            /// <value>The Object Name.</value>
            public string ObjectName { get; private set; }

            /// <summary>
            /// Gets the UICulture.
            /// </summary>
            /// <value>The UICulture.</value>
            public string UICulture { get; private set; }

            /// <summary>
            /// Initializes a new instance of the <see cref="CriteriaGet"/> class.
            /// </summary>
            /// <remarks> A parameterless constructor is required by the MobileFormatter.</remarks>
            [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
            public CriteriaGet()
            {
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="CriteriaGet"/> class.
            /// </summary>
            /// <param name="objectName">The ObjectName.</param>
            /// <param name="uICulture">The UICulture.</param>
            public CriteriaGet(string objectName, string uICulture)
            {
                ObjectName = objectName;
                UICulture = uICulture;
            }

            /// <summary>
            /// Determines whether the specified <see cref="System.Object"/> is equal to this instance.
            /// </summary>
            /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
            /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
            public override bool Equals(object obj)
            {
                if (obj is CriteriaGet)
                {
                    var c = (CriteriaGet) obj;
                    if (!ObjectName.Equals(c.ObjectName))
                        return false;
                    if (!UICulture.Equals(c.UICulture))
                        return false;
                    return true;
                }
                return false;
            }

            /// <summary>
            /// Returns a hash code for this instance.
            /// </summary>
            /// <returns>An hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
            public override int GetHashCode()
            {
                return string.Concat("CriteriaGet", ObjectName.ToString(), UICulture.ToString()).GetHashCode();
            }
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="PropertyConfigurationList"/> collection from the database, based on given criteria.
        /// </summary>
        /// <param name="crit">The fetch criteria.</param>
        protected void DataPortal_Fetch(CriteriaGet crit)
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Database.InterwayDocsConnection, false))
            {
                using (var cmd = new SqlCommand("dbo.GetPropertyConfigurationList", ctx.Connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ObjectName", crit.ObjectName).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@UICulture", crit.UICulture).DbType = DbType.String;
                    var args = new DataPortalHookArgs(cmd, crit);
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
            }
        }

        /// <summary>
        /// Loads all <see cref="PropertyConfigurationList"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            IsReadOnly = false;
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            while (dr.Read())
            {
                Add(PropertyConfigurationInfo.GetPropertyConfigurationInfo(dr));
            }
            RaiseListChangedEvents = rlce;
            IsReadOnly = true;
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
