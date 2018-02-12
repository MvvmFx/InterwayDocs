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
using Codisa.InterwayDocs.Rules;

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
            OutgoingRegisterSaved.Register(this);

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
        /// Handle Saved events of <see cref="OutgoingRegister"/> to update the list of <see cref="OutgoingInfo"/> objects.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The <see cref="Csla.Core.SavedEventArgs"/> instance containing the event data.</param>
        internal void OutgoingRegisterSavedHandler(object sender, Csla.Core.SavedEventArgs e)
        {
            var obj = (OutgoingRegister)e.NewObject;
            if (((OutgoingRegister)sender).IsNew)
            {
                IsReadOnly = false;
                var rlce = RaiseListChangedEvents;
                RaiseListChangedEvents = true;
                Add(OutgoingInfo.LoadInfo(obj));
                RaiseListChangedEvents = rlce;
                IsReadOnly = true;
            }
            else if (((OutgoingRegister)sender).IsDeleted)
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
    /// OutgoingBookCriteriaGet criteria.
    /// </summary>
    [Serializable]
    public partial class OutgoingBookCriteriaGet : SearchLocatableCriteriaBase<OutgoingBookCriteriaGet>, IHaveArchiveLocation, IGenericCriteriaInformation
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OutgoingBookCriteriaGet"/> class.
        /// </summary>
        /// <remarks> A parameterless constructor is required by the MobileFormatter.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public OutgoingBookCriteriaGet()
        {
            var dateTypeList = CriteriaDateTypeList.GetCriteriaDateTypeList(true);
            LoadProperty(DateTypeListProperty, dateTypeList);
            LoadProperty(SelectedDateTypeIndexProperty, 0);
        }

        #endregion

    }

    #endregion

}
