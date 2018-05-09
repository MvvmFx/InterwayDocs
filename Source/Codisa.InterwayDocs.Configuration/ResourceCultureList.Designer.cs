using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Codisa.InterwayDocs.Configuration
{

    /// <summary>
    /// ResourceCultureList (read only object).<br/>
    /// This is a generated <see cref="ResourceCultureList"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="ResourceCultureInfo"/> collection.
    /// </remarks>
    [Serializable]
    public partial class ResourceCultureList : ReadOnlyBase<ResourceCultureList>
    {

        #region State Fields

        [NotUndoable, NonSerialized]
        internal int resourceId = 0;

        #endregion

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="UICulture"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> UICultureProperty = RegisterProperty<string>(p => p.UICulture, "UICulture");
        /// <summary>
        /// Gets the UICulture.
        /// </summary>
        /// <value>The UICulture.</value>
        public string UICulture
        {
            get { return GetProperty(UICultureProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="Translation"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> TranslationProperty = RegisterProperty<string>(p => p.Translation, "Translation");
        /// <summary>
        /// Gets the Translation.
        /// </summary>
        /// <value>The Translation.</value>
        public string Translation
        {
            get { return GetProperty(TranslationProperty); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="ResourceCultureList"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="ResourceCultureList"/> object.</returns>
        internal static ResourceCultureList GetResourceCultureList(SafeDataReader dr)
        {
            ResourceCultureList obj = new ResourceCultureList();
            obj.Fetch(dr);
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceCultureList"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ResourceCultureList()
        {
            // Use factory methods and do not use direct creation.
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="ResourceCultureList"/> object from the given SafeDataReader.
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

        #endregion

        #region DataPortal Hooks

        /// <summary>
        /// Occurs after the low level fetch operation, before the data reader is destroyed.
        /// </summary>
        partial void OnFetchRead(DataPortalHookArgs args);

        #endregion

    }
}
