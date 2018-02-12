namespace Codisa.InterwayDocs.Framework
{
    public interface IBookView : IRefreshTranslation
    {
        void ShowSearchArea();
        void ToggleSearchArea();
        void CancelClose(bool doClose, int rowId);
    }
}