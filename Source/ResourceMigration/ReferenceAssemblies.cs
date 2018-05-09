using Codisa.InterwayDocs.Business.SearchObjects;
using Codisa.InterwayDocs.Configuration;
using Codisa.InterwayDocs.Rules;

namespace ResourceMigration
{
    static class ReferenceAssemblies
    {

        public static void Perform()
        {
            var form = new Codisa.InterwayDocs.MainForm();
            var list = new FastDateOptionList();
            var info = new PropertyConfigurationList();
            var rule = new ThreePartsFullText(PropertyConfigurationInfo.UICultureProperty);
        }
    }
}
