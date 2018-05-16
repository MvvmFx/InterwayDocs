using System;

namespace Codisa.InterwayDocs.Framework
{
    public static class UiResources
    {
        public static string GetUiTranslation(this string resource)
        {
            return Get(resource);
        }

        public static Func<string, string> Get { get; set; }
    }
}