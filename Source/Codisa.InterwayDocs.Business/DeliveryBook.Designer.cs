using System;
using Codisa.InterwayDocs.Business.SearchObjects;
using Csla;

namespace Codisa.InterwayDocs.Business
{

    /// <summary>
    /// DeliveryBook (read only list).<br/>
    /// This is a generated base class of <see cref="DeliveryBook"/> business object.
    /// This class is a root collection.
    /// </summary>
    /// <remarks>
    /// The items of the collection are <see cref="DeliveryInfo"/> objects.
    /// </remarks>
    [Serializable]
    public partial class DeliveryBook : ReadOnlyBindingListBase<DeliveryBook, DeliveryInfo>
    {

        #region Collection Business Methods

        /// <summary>
        /// Determines whether a <see cref="DeliveryInfo"/> item is in the collection.
        /// </summary>
        /// <param name="registerId">The RegisterId of the item to search for.</param>
        /// <returns><c>true</c> if the DeliveryInfo is a collection item; otherwise, <c>false</c>.</returns>
        public bool Contains(int registerId)
        {
            foreach (var deliveryInfo in this)
            {
                if (deliveryInfo.RegisterId == registerId)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Loads a <see cref="DeliveryBook"/> collection, based on given parameters.
        /// </summary>
        /// <param name="crit">The fetch criteria.</param>
        /// <returns>A reference to the fetched <see cref="DeliveryBook"/> collection.</returns>
        public static DeliveryBook GetDeliveryBook(DeliveryBookCriteriaGet crit)
        {
            return DataPortal.Fetch<DeliveryBook>(crit);
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryBook"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public DeliveryBook()
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

    #region Criteria

    /// <summary>
    /// DeliveryBookCriteriaGet criteria.
    /// </summary>
    [Serializable]
    public partial class DeliveryBookCriteriaGet : SearchCriteriaBase<DeliveryBookCriteriaGet>, IGenericCriteriaInformation
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryBookCriteriaGet"/> class.
        /// </summary>
        /// <remarks> A parameterless constructor is required by the MobileFormatter.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public DeliveryBookCriteriaGet()
        {
            var dateTypeList = CriteriaDateTypeList.GetCriteriaDateTypeList(false);
            LoadProperty(DateTypeListProperty, dateTypeList);
            LoadProperty(SelectedDateTypeIndexProperty, 0);
        }

        #endregion

    }

    #endregion

}
