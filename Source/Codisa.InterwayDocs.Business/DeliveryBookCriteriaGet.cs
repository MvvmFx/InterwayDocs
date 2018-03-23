using System;
using Codisa.InterwayDocs.Business.SearchObjects;

namespace Codisa.InterwayDocs.Business
{

    /// <summary>
    /// DeliveryBookCriteriaGet criteria.
    /// </summary>
    [Serializable]
    public class DeliveryBookCriteriaGet : SearchCriteriaBase<DeliveryBookCriteriaGet>, IGenericCriteriaInformation
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
}
