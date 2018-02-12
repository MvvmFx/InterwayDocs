using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MvvmFx.CaliburnMicro;
using MvvmFx.Windows.Data;

namespace Codisa.InterwayDocs.Setup
{
    public partial class MainForm : Form, IHaveDataContext, IMainForm
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
                case "Database":
                    BackColorHelper(SystemColors.MenuHighlight, SystemColors.Control, SystemColors.Control);
                    break;
                case "ObjectProperties":
                    BackColorHelper(SystemColors.Control, SystemColors.MenuHighlight, SystemColors.Control);
                    break;
                case "OtherCustomizations":
                    BackColorHelper(SystemColors.Control, SystemColors.Control, SystemColors.MenuHighlight);
                    break;
            }
        }

        private void BackColorHelper(Color incoming, Color outgoing, Color delivery)
        {
            openDatabase.BackColor = incoming;
            openObjectProperties.BackColor = outgoing;
            openOtherCustomizations.BackColor = delivery;
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

        private void about_Click(object sender, EventArgs e)
        {
            var about = new AboutForm();
            about.ShowDialog();
        }

    }
}