using Codisa.InterwayDocs.Business.SearchObjects;
#if WISEJ
using Wisej.Base;
#endif

namespace Codisa.InterwayDocs.Framework
{
    internal class CommonBookCriteriaFacade : CommonBookCriteria
    {
#if WINFORMS
        private static CommonBookCriteria _facade;
#else
        private static CommonBookCriteria _facade
        {
            get { return ApplicationBase.Session.Codisa_InterwayDocs_Framework_CommonBookCriteriaFacade; }
            set { ApplicationBase.Session.Codisa_InterwayDocs_Framework_CommonBookCriteriaFacade = value; }
        }
#endif

        public CommonBookCriteriaFacade()
        {
            _facade = new CommonBookCriteria();
        }

        public static CommonBookCriteria Instance
        {
            get
            {
                if (_facade == null)
                    _facade = new CommonBookCriteria();

                return _facade;
            }
        }
    }
}