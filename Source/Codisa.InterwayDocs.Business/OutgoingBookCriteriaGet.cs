using System;
using Codisa.InterwayDocs.Business.SearchObjects;
using Codisa.InterwayDocs.Rules;

namespace Codisa.InterwayDocs.Business
{

    /// <summary>
    /// OutgoingBookCriteriaGet criteria.
    /// </summary>
    [Serializable]
    public class OutgoingBookCriteriaGet : SearchLocatableCriteriaBase<OutgoingBookCriteriaGet>, IHaveArchiveLocation, IGenericCriteriaInformation
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
}
