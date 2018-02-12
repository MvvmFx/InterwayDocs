namespace Codisa.InterwayDocs.Framework
{
    public interface IDetailView : IHaveNamedElements, IRefreshTranslation
    {
        void ShowEmptyRegister();
        void ToggleDetailPanel();
        void SetSizeDetailPanel();
    }
}