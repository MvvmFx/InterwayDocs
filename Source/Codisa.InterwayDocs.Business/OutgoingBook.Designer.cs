using System;
using Codisa.InterwayDocs.Business.SearchObjects;
using Codisa.InterwayDocs.Rules;
using Csla;

namespace Codisa.InterwayDocs.Business
{

    /// <summary>
    /// OutgoingBook (read only list).<br/>
    /// This is a generated base class of <see cref="OutgoingBook"/> business object.
    /// This class is a root collection.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="OutgoingInfo"/> objects.
    /// </remarks>
    [Serializable]
    public partial class OutgoingBook : ReadOnlyBindingListBase<OutgoingBook, OutgoingInfo>
    {

        #region Collection Business Methods

        /// <summary>
        /// Determines whether a <see cref="OutgoingInfo"/> item is in the collection.
        /// </summary>
        /// <param name="registerId">The RegisterId of the item to search for.</param>
        /// <returns><c>true</c> if the OutgoingInfo is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(int registerId)
        {
            foreach (var outgoingInfo in this)
            {
                if (outgoingInfo.RegisterId == registerId)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="OutgoingBook"/> collection, based on given parameters.
        /// </summary>
        /// <param name="crit">The fetch criteria.</param>
        /// <returns>A reference to the fetched <see cref="OutgoingBook"/> collection.</returns>
        public static OutgoingBook GetOutgoingBook(OutgoingBookCriteriaGet crit)
        {
            return DataPortal.Fetch<OutgoingBook>(crit);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="OutgoingBook"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public OutgoingBook()
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

    }
}
