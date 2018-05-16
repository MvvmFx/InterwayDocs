using System;
using System.Linq;
using System.Reflection;
#if WISEJ
using Wisej.Base;
#else
using System.Windows.Forms;
#endif
using Codisa.InterwayDocs.Configuration;
using ApplicationContext = MvvmFx.CaliburnMicro.ApplicationContext;

namespace Codisa.InterwayDocs.Framework
{
    public static class TranslatedResources
    {
#if WINFORMS
        private static ResourceList _resourceList;
        private static ResourceList _businessResourceList;
#else
        private static ResourceList _resourceList
        {
            get { return ApplicationBase.Session.ResourceList; }
            set { ApplicationBase.Session.ResourceList = value; }
        }

        private static ResourceList _businessResourceList
        {
            get { return ApplicationBase.Session.BusinessResourceList; }
            set { ApplicationBase.Session.BusinessResourceList = value; }
        }
#endif
        public static ResourceList ResourceList
        {
            get
            {
                if (_resourceList == null || _resourceList.Count == 0)
                    _resourceList = ResourceList.GetResourceList("InterwayDocs", ApplicationContext.UICulture);

                return _resourceList;
            }
        }

        public static ResourceList BusinessResourceList
        {
            get
            {
                if (_businessResourceList == null || _businessResourceList.Count == 0)
                    _businessResourceList =
                        ResourceList.GetResourceList("InterwayDocs.Business", ApplicationContext.UICulture);

                return _businessResourceList;
            }
        }

        public static void ClearResources()
        {
            _resourceList = null;
            _businessResourceList = null;
        }

        public static string GetResource(ResourceList list, string resourceName)
        {
            string translation = list
                .Where(resourceInfo => resourceInfo.ResourceName == resourceName)
                .Select(resourceInfo => resourceInfo.Translation)
                .SingleOrDefault();

            translation = ConvertEndOfLines(translation);

            if (translation != null)
                return translation;

            return resourceName;
        }

        private static string ConvertEndOfLines(string translation)
        {
            if (!string.IsNullOrWhiteSpace(translation))
            {
                var translationParts = translation.Split(new[] {"\\r\\n"}, StringSplitOptions.None);
                if (translationParts.Length > 1)
                {
                    translation = string.Empty;
                    for (int part = 0; part < translationParts.Length - 1; part++)
                    {
                        translation += translationParts[part] + Environment.NewLine;
                    }

                    translation += translationParts[translationParts.Length - 1];
                }
            }

            return translation;
        }
    }
}