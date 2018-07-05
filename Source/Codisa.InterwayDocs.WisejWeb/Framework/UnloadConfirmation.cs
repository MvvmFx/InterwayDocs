using Wisej.Base;

namespace Codisa.InterwayDocs.Framework
{
    public static class UnloadConfirmation
    {
        private static bool PrivateEnableUnloadConfirmation
        {
            get
            {
                if (ApplicationBase.Session.EnableUnloadConfirmation == null)
                    PrivateEnableUnloadConfirmation = false;

                return ApplicationBase.Session.EnableUnloadConfirmation;
            }
            set { ApplicationBase.Session.EnableUnloadConfirmation = value; }
        }

        public static bool EnableUnloadConfirmation
        {
            get { return PrivateEnableUnloadConfirmation; }
            set
            {
                if (PrivateEnableUnloadConfirmation != value)
                {
                    PrivateEnableUnloadConfirmation = value;
                    ApplicationBase.EnableUnloadConfirmation = value;
                }
            }
        }

        public static void Restore()
        {
            ApplicationBase.EnableUnloadConfirmation = PrivateEnableUnloadConfirmation;
        }
    }
}