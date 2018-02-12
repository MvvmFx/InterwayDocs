using System.Collections.Generic;
using System.Windows.Forms;

namespace Codisa.InterwayDocs.Setup
{
    public interface IMainForm
    {
        void MarkActiveMenuItem(string menuItem);
        void BindMenuItems(List<Control> namedElements);
    }
}