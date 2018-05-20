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
using ApplicationContext = MvvmFx.CaliburnMicro.ApplicationContext;

namespace Codisa.InterwayDocs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
#if WINFORMS
        [STAThread]
#endif
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
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(uiCulture);
#else
                if (string.IsNullOrEmpty(uiCulture))
                    uiCulture = ApplicationBase.CurrentCulture.ToString();
                else
                    ApplicationBase.CurrentCulture = CultureInfo.GetCultureInfo(uiCulture);
#endif
            }
            catch (ArgumentNullException)
            {
            }
            catch (CultureNotFoundException exception)
            {
                MessageBox.Show(exception.Message, "LabelAlert".GetUiTranslation(), MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            ApplicationContext.UICulture = uiCulture.Substring(0, 2);

            TranslatedResources.ClearResources();
            Business.BusinessResources.Get = message =>
            {
                return TranslatedResources.GetResource(TranslatedResources.BusinessResourceList, message);
            };


            UiResources.Get = message =>
            {
                return TranslatedResources.GetResource(TranslatedResources.ResourceList, message);
            };

            new AppBootstrapper().Run();
        }

        internal static void RefreshTranslation()
        {
            TranslatedResources.ClearResources();

            Delivery.DeliveryBookViewModel.ClearConfigurationList();
            Delivery.DeliveryDetailViewModel.ClearConfigurationList();
            Incoming.IncomingBookViewModel.ClearConfigurationList();
            Incoming.IncomingDetailViewModel.ClearConfigurationList();
            Outgoing.OutgoingBookViewModel.ClearConfigurationList();
            Outgoing.OutgoingDetailViewModel.ClearConfigurationList();

            object model = null;

#if WISEJ
            foreach (Page page in Application.OpenPages)
            {
                if (page is IMainForm)
                {
                    model = (page as IMainForm).DataContext;
                    continue;
                }

                var translatableForm = page as IRefreshTranslation;
                if (translatableForm != null)
                    translatableForm.RefreshTranslation();
            }
#endif

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
            // disable culture change by ?lang= in URL
            var currentCulture = ((MainForm) Application.OpenPages[0]).CurrentCulture;

            if (ApplicationBase.CurrentCulture != currentCulture)
                ApplicationBase.CurrentCulture = currentCulture;

            UnloadConfirmation.Restore();
        }
#endif
    }
}