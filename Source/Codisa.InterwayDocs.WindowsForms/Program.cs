using System;
using System.Configuration;
using System.Globalization;
using Codisa.InterwayDocs.Framework;
#if WISEJ
using MvvmFx.CaliburnMicro.WisejWeb.Toolable;
using Wisej.Base;
using Wisej.Web;
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
            Setup.Run(typeof(PanelEx));
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
                if (string.IsNullOrEmpty(uiCulture))
                    uiCulture = ApplicationBase.CurrentCulture.ToString();
                else
                {
                    uiCulture = uiCulture.Substring(0, 2);

                    if (uiCulture == "en")
                        uiCulture += "-GB";

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
                    continue;
                }

                var translatableForm = form as IRefreshTranslation;
                if (translatableForm != null)
                    translatableForm.RefreshTranslation();
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
            ApplicationContext.UICulture = ApplicationBase.CurrentCulture.ToString().Substring(0, 2);

            var uiCulture = ApplicationContext.UICulture;

            if (ApplicationBase.CurrentCulture.ToString() == "en")
            {
                uiCulture += "-GB";

                ApplicationBase.Navigate(ApplicationBase.StartupUri + "?lang=" + uiCulture);
            }

            RefreshTranslation();
        }
#endif
    }
}