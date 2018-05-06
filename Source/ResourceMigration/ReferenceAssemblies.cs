using System;
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
            var info = new PropertyConfiguration();
            var rule = new ThreePartsFullText(PropertyConfiguration.ConfigurationIdProperty);
        }
    }
}
