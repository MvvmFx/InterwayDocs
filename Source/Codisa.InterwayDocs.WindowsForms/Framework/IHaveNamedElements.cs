using System.Collections.Generic;
#if WISEJ
using Wisej.Web;
#else
using System.Windows.Forms;
#endif

namespace Codisa.InterwayDocs.Framework
{
    public interface IHaveNamedElements
    {
        List<Control> NamedElements { get; set; }
    }
}