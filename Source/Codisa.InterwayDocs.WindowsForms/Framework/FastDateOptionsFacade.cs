using Codisa.InterwayDocs.Business.SearchObjects;
#if WISEJ
using Wisej.Base;
#endif

namespace Codisa.InterwayDocs.Framework
{
    internal class FastDateOptionsFacade : FastDateOptions
    {
#if WINFORMS
        private static FastDateOptions _facade;
#else
        private static FastDateOptions _facade
        {
            get { return ApplicationBase.Session.Codisa_InterwayDocs_Framework_FastDateOptionsFacade; }
            set { ApplicationBase.Session.Codisa_InterwayDocs_Framework_FastDateOptionsFacade = value; }
        }
#endif

        public static FastDateOptions Instance
        {
            get
            {
                if (_facade == null)
                    _facade = new FastDateOptions();

                return _facade;
            }
        }
    }
}