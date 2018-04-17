using System;
using System.Collections.Generic;
using System.Threading;
#if WISEJ
using Wisej.Web;
#else
using System.Windows.Forms;
#endif
using Codisa.InterwayDocs.Properties;
using MvvmFx.CaliburnMicro;
using MvvmFx.Logging;

namespace Codisa.InterwayDocs
{
#if WISEJ
    internal class AppBootstrapper : PageBootstrapper<IMainFormViewModel>
#else
    internal class AppBootstrapper : Bootstrapper<IMainFormViewModel>
#endif
    {
        private static SimpleContainer _container;

        protected override void Configure()
        {
            _container = new SimpleContainer();

            _container
                .Singleton<IMainFormViewModel, MainFormViewModel>()
                .PerRequest<IWindowManager, WindowManager>();

            ConventionManager.AddElementConvention<DataGridView>("Name", null, "CellDoubleClick");

            /*ConventionManager.AddElementConvention<DataGridView>("Name", null, "CellDoubleClick").CreateAction =
                (element, methodName, parameters) =>
                {
                    return new ActionMessage(element, "CellDoubleClick", methodName, parameters);
                };*/

            /*ConventionManager.AddElementConvention<DataGridView>("Name", null, "CellDoubleClick").ApplyBinding =
                (viewModel, path, property, control, convention) => { return true; };*/
        }

        protected override object GetInstance(Type service, string key)
        {
            var instance = _container.GetInstance(service, key);

            if (null != instance)
            {
                return instance;
            }

            throw new ArgumentException(string.Format("Could not locate any instances of contract {0}.", service.Name));
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            foreach (var instance in _container.GetAllInstances(service))
            {
                yield return instance;
            }
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }

        protected override void StartRuntime()
        {
            Csla.SmartDate.CustomParser = CslaContrib.SmartDateExtendedParser.ExtendedParser;
            LogManager.GetLog = type => new DebugLogger(type);
            base.StartRuntime();
        }

        /*protected override void OnStartup(object sender, StartupEventArgs e)
        {
            base.OnStartup(sender, e);
        }

        protected override void OnExit(object sender, EventArgs e)
        {
            base.OnExit(sender, e);
        }*/

        protected override void AppDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;
            if (ex != null)
            {
                var message = Environment.NewLine + ex.InnerException.Message;
                if (message != "\r\nExit")
                    MessageBox.Show(message, Resources.AppDomain_UnhandledException);
            }
            else
                MessageBox.Show(e.ExceptionObject.ToString(), Resources.AppDomain_UnhandledException);
        }

        protected override void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            var ex = e.Exception;
            if (ex != null)
            {
                var message = Environment.NewLine + ex.InnerException.Message;
                MessageBox.Show(message, Resources.Application_ThreadException);
            }
            else
                MessageBox.Show(e.Exception.Message, Resources.Application_ThreadException);
        }
    }
}