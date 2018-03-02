using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Codisa.InterwayDocs.Framework;
using Codisa.InterwayDocs.Properties;
using MvvmFx.CaliburnMicro;
using MvvmFx.Bindings.Data;
using ApplicationContext = MvvmFx.CaliburnMicro.ApplicationContext;

namespace Codisa.InterwayDocs
{
    public partial class MainForm : Form, IMainForm
    {
        #region Fields and properties

        private readonly BindingManager _bindingManager = new BindingManager();

        private bool _isBindingSet;

        public static int HeightDifference { get; private set; }

        #endregion

        #region Initializers

        public MainForm()
        {
            InitializeComponent();

            var workingAreaHeight = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
            HeightDifference = workingAreaHeight - Height;
            Height += HeightDifference;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (var lang in Languages.LanguageList)
            {
                language.Items.Add(lang.Name);
            }

            language.SelectedIndex = Languages.GetIndexOfUICode(ApplicationContext.UICulture);
        }

        private void language_SelectedIndexChanged(object sender, EventArgs e)
        {
            var uICultureIndex = Languages.GetIndexOfUICode(ApplicationContext.UICulture);

            if (uICultureIndex == language.SelectedIndex)
                return;

            ApplicationContext.UICulture = Languages.LanguageList[language.SelectedIndex].UICode;

            Thread.CurrentThread.CurrentUICulture = new CultureInfo(ApplicationContext.UICulture);

            Program.RefreshTranslation();
        }

        #endregion

        #region IHaveBusyIndicator implementation

        public BusyIndicator Indicator
        {
            get { return busyIndicator; }
        }

        #endregion

        #region IHaveDataContext implementation

        public event EventHandler<DataContextChangedEventArgs> DataContextChanged = delegate { };

        private MainFormViewModel _viewModel;

        public object DataContext
        {
            get { return _viewModel; }
            set
            {
                if (value != _viewModel)
                {
                    _viewModel = value as MainFormViewModel;
                    DataContextChanged(this, new DataContextChangedEventArgs());
                }
            }
        }

        public void MarkActiveMenuItem(string menuItem)
        {
            switch (menuItem)
            {
                case "IncomingBook":
                    BackColorHelper(SystemColors.MenuHighlight, SystemColors.Control, SystemColors.Control);
                    break;
                case "OutgoingBook":
                    BackColorHelper(SystemColors.Control, SystemColors.MenuHighlight, SystemColors.Control);
                    break;
                case "DeliveryBook":
                    BackColorHelper(SystemColors.Control, SystemColors.Control, SystemColors.MenuHighlight);
                    break;
            }
        }

        private void BackColorHelper(Color incoming, Color outgoing, Color delivery)
        {
            openIncomingBook.BackColor = incoming;
            openOutgoingBook.BackColor = outgoing;
            openDeliveryBook.BackColor = delivery;
        }

        #endregion

        #region Bind menu items

        public void BindMenuItems(List<Control> namedElements)
        {
            if (_isBindingSet)
                return;

            // Binds the control visible and enabled properties.
            WinFormExtensionMethods.BindComponentProxyProperties(namedElements, _viewModel, _bindingManager);

            _isBindingSet = true;
        }

        #endregion

        #region Translations

        public void RefreshTranslation()
        {
            openIncomingBook.Text = Resources.LabelIncoming;
            openOutgoingBook.Text = Resources.LabelOutgoing;
            openDeliveryBook.Text = Resources.LabelDelivery;
            toolsMenuItem.Text = Resources.LabelTools;
            backup.Text = Resources.ToolsBackupLabel;
            restore.Text = Resources.ToolsRestoreLabel;
            export.Text = Resources.ToolsExportlabel;
            import.Text = Resources.ToolsImportLabel;
            helpMenuItem.Text = Resources.LabelHelp;
            about.Text = Resources.LabelAboutApplication;
            pdfManual.Text = Resources.LabelDocumentation;
            languageLabel.Text = Resources.Language;
        }

        #endregion
    }
}