using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using Codisa.InterwayDocs.Configuration;
using Codisa.InterwayDocs.Framework;
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

        #endregion

        #region Initializers

        public MainForm()
        {
            InitializeComponent();

            var workingAreaHeight = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
            var heightDifference = workingAreaHeight - Height;
            Height += heightDifference;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetResources();

            var languages = LanguageList.GetLanguageList();
            foreach (var lang in languages)
            {
                language.Items.Add(lang.Name);
            }

            language.SelectedIndex = languages.FindLanguageInfoByUICulture(ApplicationContext.UICulture).Index;
        }

        private void language_SelectedIndexChanged(object sender, EventArgs e)
        {
            var languages = LanguageList.GetLanguageList();
            var uICultureIndex = languages.FindLanguageInfoByUICulture(ApplicationContext.UICulture).Index;

            if (uICultureIndex == language.SelectedIndex)
                return;

            ApplicationContext.UICulture = languages[language.SelectedIndex].UICulture;

            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(ApplicationContext.UICulture);

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
                    MenuItemColorHelper(true, false, false);
                    break;
                case "OutgoingBook":
                    MenuItemColorHelper(false, true, false);
                    break;
                case "DeliveryBook":
                    MenuItemColorHelper(false, false, true);
                    break;
            }
        }

        private void MenuItemColorHelper(bool incoming, bool outgoing, bool delivery)
        {
            SetMenuItemColours(openIncomingBook, incoming);
            SetMenuItemColours(openOutgoingBook, outgoing);
            SetMenuItemColours(openDeliveryBook, delivery);
        }

        private void SetMenuItemColours(ToolStripItem item, bool active)
        {
            if (active)
            {
                item.BackColor = SystemColors.MenuHighlight;
                item.ForeColor = Color.White;
            }
            else
            {
                item.BackColor = SystemColors.Control;
                item.ForeColor = SystemColors.ControlText;
            }
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
            SetResources();

            language.SelectedIndex = LanguageList.GetLanguageList()
                .FindLanguageInfoByUICulture(ApplicationContext.UICulture).Index;
        }

        private void SetResources()
        {
            openIncomingBook.Text = "LabelIncoming".GetUiTranslation();
            openOutgoingBook.Text = "LabelOutgoing".GetUiTranslation();
            openDeliveryBook.Text = "LabelDelivery".GetUiTranslation();
            toolsMenuItem.Text = "LabelTools".GetUiTranslation();
            backup.Text = "ToolsBackupLabel".GetUiTranslation();
            restore.Text = "ToolsRestoreLabel".GetUiTranslation();
            export.Text = "ToolsExportlabel".GetUiTranslation();
            import.Text = "ToolsImportLabel".GetUiTranslation();
            helpMenuItem.Text = "LabelHelp".GetUiTranslation();
            about.Text = "LabelAboutApplication".GetUiTranslation();
            pdfManual.Text = "LabelDocumentation".GetUiTranslation();
            languageLabel.Text = "Language".GetUiTranslation();
        }

        #endregion
    }
}