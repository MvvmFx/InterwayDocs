using Codisa.InterwayDocs.Rules;

namespace Codisa.InterwayDocs.Business.SearchObjects
{
    public interface IGenericCriteriaInformation : ICriteriaDates
    {
        CriteriaDateTypeList DateTypeList { get; set; }

        string SelectedDateTypeName { get; set; }

        string StartDate { get; set; }
        string EndDate { get; set; }

        void GetCommonCriteria(FastDateOptions fastDateOptions, CommonBookCriteria commonBookCriteria);
        void StoreCommonCriteria(CommonBookCriteria commonBookCriteria);
    }
}