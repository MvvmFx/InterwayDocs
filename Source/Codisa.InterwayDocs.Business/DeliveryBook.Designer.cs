using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Csla;
using Csla.Data;
using Codisa.InterwayDocs.Business.SearchObjects;

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

        #region Event handler properties

        [NotUndoable]
        private static bool _singleInstanceSavedHandler = true;

        /// <summary>
        /// Gets or sets a value indicating whether only a single instance should handle the Saved event.
        /// </summary>
        /// <value>
        /// <c>true</c> if only a single instance should handle the Saved event; otherwise, <c>false</c>.
        /// </value>
        public static bool SingleInstanceSavedHandler
        {
            get { return _singleInstanceSavedHandler; }
            set { _singleInstanceSavedHandler = value; }
        }

        #endregion

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
            DeliveryRegisterSaved.Register(this);

            var rlce = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            AllowNew = false;
            AllowEdit = false;
            AllowRemove = false;
            RaiseListChangedEvents = rlce;
        }

        #endregion

        #region Saved Event Handler

        /// <summary>
        /// Handle Saved events of <see cref="DeliveryRegister"/> to update the list of <see cref="DeliveryInfo"/> objects.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The <see cref="Csla.Core.SavedEventArgs"/> instance containing the event data.</param>
        internal void DeliveryRegisterSavedHandler(object sender, Csla.Core.SavedEventArgs e)
        {
            var obj = (DeliveryRegister)e.NewObject;
            if (((DeliveryRegister)sender).IsNew)
            {
                IsReadOnly = false;
                var rlce = RaiseListChangedEvents;
                RaiseListChangedEvents = true;
                Add(DeliveryInfo.LoadInfo(obj));
                RaiseListChangedEvents = rlce;
                IsReadOnly = true;
            }
            else if (((DeliveryRegister)sender).IsDeleted)
            {
                for (int index = 0; index < this.Count; index++)
                {
                    var child = this[index];
                    if (child.RegisterId == obj.RegisterId)
                    {
                        IsReadOnly = false;
                        var rlce = RaiseListChangedEvents;
                        RaiseListChangedEvents = true;
                        this.RemoveItem(index);
                        RaiseListChangedEvents = rlce;
                        IsReadOnly = true;
                        break;
                    }
                }
            }
            else
            {
                for (int index = 0; index < this.Count; index++)
                {
                    var child = this[index];
                    if (child.RegisterId == obj.RegisterId)
                    {
                        child.UpdatePropertiesOnSaved(obj);
                        var listChangedEventArgs = new ListChangedEventArgs(ListChangedType.ItemChanged, index);
                        OnListChanged(listChangedEventArgs);
                        break;
                    }
                }
            }
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
