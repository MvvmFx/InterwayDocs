using System;
using System.Diagnostics;
#if WISEJ
using Wisej.Web;
#else
using System.Windows.Forms;
#endif
using NLog;

namespace Codisa.InterwayDocs
{
    public class AppLogger
    {
        #region Fields and Properties

        private static Logger _innerLogger;

        private static AppLogger Instance { get; set; }

        #endregion

        #region Constructors

        private AppLogger()
        {
            // force to use factory method

            _innerLogger = LogManager.GetLogger(Application.ProductName);

            try
            {
                EventLog.CreateEventSource("InterwayDocs", "Application");
            }
            catch (ArgumentException)
            {
            }
        }

        #endregion

        #region Factory methods

        public static AppLogger GetLogger()
        {
            if (Instance == null)
                Instance = new AppLogger();

            return Instance;
        }

        #endregion

        #region Implementation of ILog

        public void Trace(string message)
        {
            _innerLogger.Trace(message);
        }

        public void Debug(string message)
        {
            _innerLogger.Debug(message);
        }

        public void Info(string message)
        {
            _innerLogger.Info(message);
        }

        public void Warn(string message)
        {
            _innerLogger.Warn(message);
        }

        public void Error(string message)
        {
            _innerLogger.Error(message);
        }

        public void Fatal(string message)
        {
            _innerLogger.Fatal(message);
        }

        #endregion
    }
}