using System;
using Codisa.InterwayDocs.Business.SearchObjects;
using Codisa.InterwayDocs.Rules;

namespace Codisa.InterwayDocs.Business
{

    /// <summary>
    /// IncomingBookCriteriaGet criteria.
    /// </summary>
    [Serializable]
    public class IncomingBookCriteriaGet : SearchLocatableCriteriaBase<IncomingBookCriteriaGet>, IHaveArchiveLocation, IGenericCriteriaInformation
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="IncomingBookCriteriaGet"/> class.
        /// </summary>
        /// <remarks> A parameterless constructor is required by the MobileFormatter.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IncomingBookCriteriaGet()
        {
            var dateTypeList = CriteriaDateTypeList.GetCriteriaDateTypeList(false);
            LoadProperty(DateTypeListProperty, dateTypeList);
            LoadProperty(SelectedDateTypeIndexProperty, 0);
        }

        #endregion

    }

}
