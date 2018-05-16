using System;

namespace Codisa.InterwayDocs.Business
{
    public static class BusinessResources
    {
        public static string GetTranslation(this string resource)
        {
            return Get(resource);
        }

        public static Func<string, string> Get { get; set; }
    }
}