using Application = Wisej.Web.Application;

namespace Codisa.InterwayDocs.Framework
{
    public static class UnloadConfirmation
    {
        static UnloadConfirmation()
        {
            PrivateBeforeUnloadMessage = string.Empty;
        }

        private static string PrivateBeforeUnloadMessage
        {
            get { return Application.Session.BeforeUnloadMessage; }
            set { Application.Session.BeforeUnloadMessage = value; }
        }

        public static string BeforeUnloadMessage
        {
            get { return PrivateBeforeUnloadMessage; }
            set
            {
                if (PrivateBeforeUnloadMessage != value)
                {
                    if (value == null)
                        PrivateBeforeUnloadMessage = string.Empty;
                    else
                        PrivateBeforeUnloadMessage = value;

                    SetBeforeUnloadMessage();
                }
            }
        }

        private static void SetBeforeUnloadMessage()
        {
            if (string.IsNullOrWhiteSpace(PrivateBeforeUnloadMessage))
            {
                Application.Call("window.disableUnloadConfirmation");
            }
            else
            {
                Application.Call("window.enableUnloadConfirmation", PrivateBeforeUnloadMessage);
            }
        }

        public static void Restore()
        {
            SetBeforeUnloadMessage();
        }
    }
}