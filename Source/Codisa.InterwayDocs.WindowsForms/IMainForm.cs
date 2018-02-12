using System.Collections.Generic;
#if WISEJ
using Wisej.Web;
#else
using System.Windows.Forms;
#endif
using Codisa.InterwayDocs.Framework;
using MvvmFx.CaliburnMicro;

namespace Codisa.InterwayDocs
{
    public interface IMainForm : IHaveDataContext, IHaveBusyIndicator, IRefreshTranslation
    {
        void MarkActiveMenuItem(string menuItem);
        void BindMenuItems(List<Control> namedElements);
    }
}