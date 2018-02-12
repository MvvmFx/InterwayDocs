using Csla;

namespace Codisa.InterwayDocs.Rules
{
    public interface ICriteriaDates
    {
        string FullText { get; set; }

        int SelectedFastDateIndex { get; set; }
        int SelectedDateTypeIndex { get; set; }

        SmartDate CriteriaStartDate { get; set; }
        SmartDate CriteriaEndDate { get; set; }
    }
}