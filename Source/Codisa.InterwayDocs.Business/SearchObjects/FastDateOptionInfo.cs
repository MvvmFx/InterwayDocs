using System;
using Csla;

namespace Codisa.InterwayDocs.Business.SearchObjects
{

    /// <summary>
    /// FastDateOptionInfo (read only object).<br/>
    /// This is a generated base class of <see cref="FastDateOptionInfo"/> business object.
    /// </summary>
    /// <remarks>
    /// This class is an item of <see cref="FastDateOptionList"/> collection.
    /// </remarks>
    [Serializable]
    public class FastDateOptionInfo : ReadOnlyBase<FastDateOptionInfo>
    {

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="FastDateOptionName"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> FastDateOptionNameProperty = RegisterProperty<string>(p => p.FastDateOptionName, "Fast Date Option Name");

        /// <summary>
        /// Gets the name of the fast date option.
        /// </summary>
        /// <value>The name of the fast date option.</value>
        public string FastDateOptionName
        {
            get { return GetProperty(FastDateOptionNameProperty); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="FastDateOptionDescription"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> FastDateOptionDescriptionProperty = RegisterProperty<string>(p => p.FastDateOptionDescription, "Fast Date Option Description");

        /// <summary>
        /// Gets the fast date option description.
        /// </summary>
        /// <value>The fast date option description.</value>
        public string FastDateOptionDescription
        {
            get { return GetProperty(FastDateOptionDescriptionProperty); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="FastDateOptionInfo" /> object from the given SafeDataReader.
        /// </summary>
        /// <param name="fastDateOptionName">Name of the fast date option.</param>
        /// <param name="fastDateOptionDescription">The fast date option description.</param>
        /// <returns>
        /// A reference to the fetched <see cref="FastDateOptionInfo" /> object.
        /// </returns>
        internal static FastDateOptionInfo GetFastDateOptionInfo(string fastDateOptionName, string fastDateOptionDescription)
        {
            FastDateOptionInfo obj = new FastDateOptionInfo();
            obj.Fetch(fastDateOptionName, fastDateOptionDescription);
            return obj;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="FastDateOptionInfo"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public FastDateOptionInfo()
        {
            // Use factory methods and do not use direct creation.
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="FastDateOptionInfo" /> object from the given SafeDataReader.
        /// </summary>
        /// <param name="fastDateOptionName">Name of the fast date option.</param>
        /// <param name="fastDateOptionDescription">The fast date option description.</param>
        private void Fetch(string fastDateOptionName, string fastDateOptionDescription)
        {
            // Value properties
            LoadProperty(FastDateOptionNameProperty, fastDateOptionName);
            LoadProperty(FastDateOptionDescriptionProperty, fastDateOptionDescription);
        }

        #endregion

    }
}
