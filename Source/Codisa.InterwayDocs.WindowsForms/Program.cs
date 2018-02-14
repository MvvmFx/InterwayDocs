using System;
using System.Configuration;
using System.Globalization;
#if WISEJ
using Wisej.Base;
using Wisej.Web;
using System.Collections.Specialized;
#else
using System.Threading;
using System.Windows.Forms;
#endif
using Codisa.InterwayDocs.Properties;
using ApplicationContext = MvvmFx.CaliburnMicro.ApplicationContext;

namespace Codisa.InterwayDocs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
#if WINFORMS
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#else
            ApplicationBase.SessionTimeout += Application_SessionTimeout;
            ApplicationBase.ApplicationRefresh += ApplicationBase_ApplicationRefresh;
            MvvmFx.CaliburnMicro.WisejWeb.Toolable.Setup.Run();
#endif

            var uiCulture = ConfigurationManager.AppSettings["UICulture"];

            try
            {
#if WINFORMS
                if (string.IsNullOrEmpty(uiCulture))
                    uiCulture = Thread.CurrentThread.CurrentUICulture.ToString();
                else
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(uiCulture);
#else
                //CultureInfo currentCulture = ApplicationBase.CurrentCulture;
                //string configurationCulture = ApplicationBase.Configuration.Culture;

                if (string.IsNullOrEmpty(uiCulture))
                    uiCulture = ApplicationBase.CurrentCulture.ToString();
                else
                {
                    uiCulture = uiCulture.Substring(0, 2);
                    ApplicationBase.Navigate(ApplicationBase.StartupUri + "?lang=" + uiCulture);
                }
#endif
            }
            catch (ArgumentNullException)
            {
            }
            catch (CultureNotFoundException exception)
            {
                MessageBox.Show(exception.Message, Resources.LabelAlert, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ApplicationContext.UICulture = uiCulture.Substring(0, 2);

            new AppBootstrapper().Run();
        }

        internal static void RefreshTranslation()
        {
            Delivery.DeliveryBookViewModel.ClearConfigurationList();
            Delivery.DeliveryDetailViewModel.ClearConfigurationList();
            Incoming.IncomingBookViewModel.ClearConfigurationList();
            Incoming.IncomingDetailViewModel.ClearConfigurationList();
            Outgoing.OutgoingBookViewModel.ClearConfigurationList();
            Outgoing.OutgoingDetailViewModel.ClearConfigurationList();

            object model = null;
            foreach (Form form in Application.OpenForms)
            {
                if (form is IMainForm)
                {
                    model = (form as IMainForm).DataContext;
                    break;
                }
            }

            if (model != null && model is IMainFormViewModel)
            {
                (model as IMainFormViewModel).RefreshTranslation();
            }
        }

#if WISEJ
        private static void Application_SessionTimeout(object sender, System.ComponentModel.HandledEventArgs e)
        {
            // you can display a form and override the default session timeout dialog.
            e.Handled = true;
        }

        private static void ApplicationBase_ApplicationRefresh(object sender, EventArgs e)
        {
            //CultureInfo currentCulture = ApplicationBase.CurrentCulture;
            //string configurationCulture = ApplicationBase.Configuration.Culture;

            ApplicationContext.UICulture = ApplicationBase.CurrentCulture.ToString().Substring(0, 2);
            RefreshTranslation();
        }
#endif
    }
}