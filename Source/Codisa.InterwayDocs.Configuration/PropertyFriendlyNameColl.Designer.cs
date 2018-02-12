using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Codisa.InterwayDocs.Configuration
{

    /// <summary>
    /// PropertyFriendlyNameColl (editable child list).<br/>
    /// This is a generated base class of <see cref="PropertyFriendlyNameColl"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is child of <see cref="PropertyConfiguration"/> editable child object.<br/>
    /// The items of the collection are <see cref="PropertyFriendlyName"/> objects.
    /// </remarks>
    [Serializable]
    public partial class PropertyFriendlyNameColl : BusinessBindingListBase<PropertyFriendlyNameColl, PropertyFriendlyName>
    {

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="PropertyFriendlyNameColl"/> collection.
        /// </summary>
        /// <returns>A reference to the created <see cref="PropertyFriendlyNameColl"/> collection.</returns>
        internal static PropertyFriendlyNameColl NewPropertyFriendlyNameColl()
        {
            return DataPortal.CreateChild<PropertyFriendlyNameColl>();
        }

        /// <summary>
        /// Factory method. Loads a <see cref="PropertyFriendlyNameColl"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="PropertyFriendlyNameColl"/> object.</returns>
        internal static PropertyFriendlyNameColl GetPropertyFriendlyNameColl(SafeDataReader dr)
        {
            PropertyFriendlyNameColl obj = new PropertyFriendlyNameColl();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.Fetch(dr);
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyFriendlyNameColl"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public PropertyFriendlyNameColl()
        {
            // Use factory methods and do not use direct creation.

            // show the framework that this is a child object
            MarkAsChild();

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
        /// Loads all <see cref="PropertyFriendlyNameColl"/> collection items from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            var args = new DataPortalHookArgs(dr);
            OnFetchPre(args);
            while (dr.Read())
            {
                Add(PropertyFriendlyName.GetPropertyFriendlyName(dr));
            }
            OnFetchPost(args);
            RaiseListChangedEvents = rlce;
        }

        /// <summary>
        /// Loads <see cref="PropertyFriendlyName"/> items on the FriendlyNames collection.
        /// </summary>
        /// <param name="collection">The grand parent <see cref="PropertyConfigurationColl"/> collection.</param>
        internal void LoadItems(PropertyConfigurationColl collection)
        {
            foreach (var item in this)
            {
                var obj = collection.FindPropertyConfigurationByParentProperties(item.configurationId);
                var rlce = obj.FriendlyNames.RaiseListChangedEvents;
                obj.FriendlyNames.RaiseListChangedEvents = false;
                obj.FriendlyNames.Add(item);
                obj.FriendlyNames.RaiseListChangedEvents = rlce;
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
