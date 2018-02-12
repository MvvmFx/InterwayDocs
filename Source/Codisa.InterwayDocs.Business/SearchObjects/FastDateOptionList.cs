using System;
using Csla;
using Csla.Core;

namespace Codisa.InterwayDocs.Business.SearchObjects
{
    /// <summary>
    /// FastDateOptionList (read only list).<br/>
    /// This is a generated base class of <see cref="FastDateOptionList"/> business object.
    /// This class is a root collection.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="FastDateOptionInfo"/> objects.
    /// </remarks>
    [Serializable]
    public class FastDateOptionList : ReadOnlyBindingListBase<FastDateOptionList, FastDateOptionInfo>
    {
        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="FastDateOptionList" /> collection.
        /// </summary>
        /// <param name="fastDateOptions">The fast date option.</param>
        /// <returns>
        /// A reference to the fetched <see cref="FastDateOptionList" /> collection.
        /// </returns>
        public static FastDateOptionList GetFastDateOptionList(FastDateOptions fastDateOptions)
        {
            return DataPortal.Fetch<FastDateOptionList>(fastDateOptions);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="FastDateOptionList"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public FastDateOptionList()
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

        #region Data Access

        /// <summary>
        /// Loads a <see cref="FastDateOptionList" /> collection from the database.
        /// </summary>
        /// <param name="fastDateOptions">The fast date options.</param>
        protected void DataPortal_Fetch(FastDateOptions fastDateOptions)
        {
            IsReadOnly = false;
            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;

            var dictionary = fastDateOptions.GetDictionary();
            foreach (var entry in dictionary)
            {
                AddNameValuePair(entry.Key, entry.Value);
            }

            RaiseListChangedEvents = rlce;
            IsReadOnly = true;
        }

        private void AddNameValuePair(string fastDateOptionName, string fastDateOptionDescription)
        {
            Add(FastDateOptionInfo.GetFastDateOptionInfo(fastDateOptionName, fastDateOptionDescription));
        }

        #endregion
    }
}