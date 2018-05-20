using Wisej.Base;

namespace Codisa.InterwayDocs.Framework
{
    public static class UnloadConfirmation
    {
        static UnloadConfirmation()
        {
            PrivateEnableUnloadConfirmation = false;
        }

        private static bool PrivateEnableUnloadConfirmation
        {
            get { return ApplicationBase.Session.EnableUnloadConfirmation; }
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