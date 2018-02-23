using Codisa.InterwayDocs.Business.SearchObjects;
using MvvmFx.CaliburnMicro;

namespace Codisa.InterwayDocs.Framework
{
    public interface IBookViewModel : IViewAware, IHaveModel, IRefreshTranslation
    {
        bool IsDetailPanelOpen { get; set; }
        bool IsDetailPanelStateOpen { get; set; }
        IGenericCriteriaInformation Criteria { get; set; }
        IMainFormViewModel RootViewModel { get; set; }
        void AutoRefreshDocuments();
    }
}