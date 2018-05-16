using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace Codisa.InterwayDocs.Configuration
{

    /// <summary>
    /// LanguageInfo (read only object).<br/>
    /// This is a generated <see cref="LanguageInfo"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="LanguageList"/> collection.
    /// </remarks>
    [Serializable]
    public partial class LanguageInfo : ReadOnlyBase<LanguageInfo>
    {

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
        /// Maintains metadata about <see cref="Index"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> IndexProperty = RegisterProperty<int>(p => p.Index, "Index");
        /// <summary>
        /// Gets the Index.
        /// </summary>
        /// <value>The Index.</value>
        public int Index
        {
            get { return GetProperty(IndexProperty); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="LanguageInfo"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="LanguageInfo"/> object.</returns>
        internal static LanguageInfo GetLanguageInfo(SafeDataReader dr)
        {
            LanguageInfo obj = new LanguageInfo();
            obj.Fetch(dr);
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageInfo"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public LanguageInfo()
        {
            // Use factory methods and do not use direct creation.
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="LanguageInfo"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            LoadProperty(UICultureProperty, dr.GetString("UICulture"));
            LoadProperty(NameProperty, dr.GetString("Name"));
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
