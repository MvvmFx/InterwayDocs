using System;
using System.Collections.Generic;
using System.ComponentModel;
#if WISEJ
using Wisej.Base;
using Wisej.Web;
#else
using System.Windows.Forms;
#endif
using Codisa.InterwayDocs.Business;
using Codisa.InterwayDocs.Configuration;
using Codisa.InterwayDocs.Framework;
using MvvmFx.CaliburnMicro;
using ApplicationContext = MvvmFx.CaliburnMicro.ApplicationContext;

namespace Codisa.InterwayDocs.Incoming
{
    public class IncomingDetailViewModel : ScreenWithModel<IncomingRegister>, IDetailViewModel, IHaveConfigurationList
    {
        #region Fields

#if WINFORMS
        private static PropertyConfigurationList _configurationList;
#else
        private static PropertyConfigurationList _configurationList
        {
            get { return ApplicationBase.Session.Codisa_InterwayDocs_IncomingDetailViewModel_ConfigurationList; }
            set { ApplicationBase.Session.Codisa_InterwayDocs_IncomingDetailViewModel_ConfigurationList = value; }
        }
#endif

        private int _registerId;
        private readonly bool _isCreating;
        private readonly bool _showEmpty;

        private DateTime _refreshDateTime;
        private IncomingBookViewModel _parent;

        // state
        private bool _isViewAttached;
        private bool _isCancelling;
        private bool _isSaving;
        private bool _isShutdown;

        #endregion

        #region Properties

        public PropertyConfigurationList ConfigurationList
        {
            get
            {
                if (_configurationList == null)
                    _configurationList = PropertyConfigurationList.GetPropertyConfigurationList("IncomingRegister",
                        ApplicationContext.UICulture);

                return _configurationList;
            }
        }

        public IBookViewModel ParentViewModel
        {
            get { return _parent; }
        }

        public List<Control> ViewNamedElements
        {
            get { return (GetView() as IHaveNamedElements)?.NamedElements; }
            set
            {
                var view = GetView() as IHaveNamedElements;
                if (view != null)
                    view.NamedElements = value;

                if (_showEmpty)
                    ShowEmptyRegister();
            }
        }

        public string Audit
        {
            get
            {
                if (_isCreating)
                    return string.Empty;

                return AuditFormater.Format(Model.CreateDate, Model.ChangeDate);
            }
        }

#if WISEJ
        /// <summary>
        /// Gets a value indicating whether the Model has been changed.
        /// </summary>
        public override bool IsDirty
        {
            get { return base.IsDirty; }
            protected set
            {
                if (base.IsDirty != value)
                {
                    base.IsDirty = value;
                    if (!Model.IsReadOnly)
                    {
                        if (value)
                            UnloadConfirmation.BeforeUnloadMessage = "Save before closing.";
                    }
                }
            }
        }
#endif

        #endregion

        #region Initializers

        private IncomingDetailViewModel()
        {
            // force to use parametrized constructor
        }

        public IncomingDetailViewModel(bool createDocument) :
            this()
        {
            _isCreating = createDocument;
            _showEmpty = !createDocument;

            SetUpEvents();
        }

        public IncomingDetailViewModel(int registerId) :
            this()
        {
            _registerId = registerId;

            SetUpEvents();
        }

        private void SetUpEvents()
        {
            PropertyChanged += OnPropertyChanged;
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();
            LoadModel();
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Parent")
            {
                PropertyChanged -= OnPropertyChanged;

                try
                {
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "OperationError".GetUiTranslation(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                _parent = Parent as IncomingBookViewModel;
                if (_parent != null)
                {
                    if (_registerId > 0)
                        _parent.LastRegisterId = _registerId;
                    else if (_showEmpty)
                        _parent.LastRegisterId = -1;
                }
            }
        }

        protected override void OnViewAttached(object view, object context)
        {
            base.OnViewAttached(view, context);

            _isViewAttached = true;

            if (_isCreating)
            {
                EditDetail();
            }
            else if (!_showEmpty)
            {
                if (!ParentViewModel.IsDetailPanelOpen)
                    ToggleDetailPanel();

                SetReadOnlyButtons();
            }
        }

        private void Populate()
        {
            // _configurationList id lazy loaded by ConfigurationList getter
        }

        private void LoadModel()
        {
            if (_isCreating)
            {
                DoRefresh(IncomingRegister.NewIncomingRegister);

                DisplayName = "NewRegister".GetUiTranslation();
#if WISEJ
                UnloadConfirmation.BeforeUnloadMessage = "Save before closing.";
#endif
            }
            else if (_showEmpty)
            {
                DoRefresh(IncomingRegister.NewIncomingRegister);
            }
            else
            {
                DoRefresh(() => IncomingRegister.GetIncomingRegister(_registerId));
                _refreshDateTime = DateTime.Now;

                DisplayName = string.Format("RegisterNumber".GetUiTranslation(), Model.RegisterId);
            }

            _registerId = Model.RegisterId;
        }

        #endregion

        #region Translations

        public static void ClearConfigurationList()
        {
            _configurationList = null;
        }

        public void RefreshTranslation()
        {
            var view = GetView() as IRefreshTranslation;
            if (view != null)
                view.RefreshTranslation();

            if (_isCreating)
            {
                DisplayName = "NewRegister".GetUiTranslation();
            }
            else if (_showEmpty)
            {
                ShowEmptyRegister();
            }
            else
            {
                DisplayName = string.Format("RegisterNumber".GetUiTranslation(), Model.RegisterId);
                NotifyOfPropertyChange("Audit");
            }
        }

        #endregion

        #region Set up buttons

        private void SetEditButtons()
        {
            Model.IsReadOnly = false;
            CanCreateRegister = false;
            CanEditDetail = false;
            CanCancel = true;
            CanToggleDetailPanel = false;
        }

        private void SetReadOnlyButtons()
        {
#if WISEJ
            UnloadConfirmation.BeforeUnloadMessage = string.Empty;
#endif
            CanCreateRegister = true;
            CanEditDetail = true;
            CanCancel = false;
            CanToggleDetailPanel = true;
        }

        private void SetEmptyRegisterButtons()
        {
#if WISEJ
            UnloadConfirmation.BeforeUnloadMessage = string.Empty;
#endif
            CanCreateRegister = true;
            CanEditDetail = false;
            CanCancel = false;
            CanToggleDetailPanel = true;
        }

        private void ShowEmptyRegister()
        {
            DisplayName = "NoAvailableRegisters".GetUiTranslation();
            SetEmptyRegisterButtons();

            if (!ParentViewModel.IsDetailPanelOpen)
                SetSizeDetailPanel();

            if (_isViewAttached)
            {
                (GetView() as IDetailView)?.ShowEmptyRegister();
            }
        }

        public void SetSizeDetailPanel()
        {
            if (_isViewAttached)
            {
                (GetView() as IDetailView)?.SetSizeDetailPanel();
            }
        }

        #endregion

        #region Close check

        public override void CanClose(Action<bool> callback)
        {
            if (Model.IsReadOnly || !IsDirty || _isCancelling || _isSaving)
            {
                callback(true);
            }
            else
            {
                _isShutdown = false;
                DoCloseCheck(callback);
            }
        }

        public IResult GetShutdownTask()
        {
            if (Model.IsReadOnly || !IsDirty)
                return null;

            _isShutdown = true;
            return new ApplicationCloseCheck(this, DoCloseCheck);
        }

        protected void DoCloseCheck(Action<bool> callback)
        {
            var result = MessageBox.Show("CloseOrCancel".GetUiTranslation(), "UnsavedRegister".GetUiTranslation(),
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            var close = result == DialogResult.Yes;

            callback(close);

            if (!close)
            {
                CloseCheckHelper(close);
            }
        }

        private void CloseCheckHelper(bool doClose)
        {
            if (!_isShutdown)
                (_parent.GetView() as IBookView)?.CancelClose(doClose, _registerId);
        }

        #endregion

        #region Actions methods and guard properties

        public void ToggleDetailPanel()
        {
            if (_isViewAttached)
            {
                (GetView() as IDetailView)?.ToggleDetailPanel();
            }
        }

        private bool _canToggleDetailPanel = true;

        public bool CanToggleDetailPanel
        {
            get { return _canToggleDetailPanel; }
            set
            {
                if (_canToggleDetailPanel != value)
                {
                    _canToggleDetailPanel = value;
                    NotifyOfPropertyChange("CanToggleDetailPanel");
                }
            }
        }

        public void WhenEmptyCreateRegister()
        {
            CreateRegister();
        }

        public void CreateRegister()
        {
            _parent?.CreateNew(true);
        }

        private bool _canCreateRegister = true;

        public bool CanCreateRegister
        {
            get { return _canCreateRegister; }
            set
            {
                if (_canCreateRegister != value)
                {
                    _canCreateRegister = value;
                    NotifyOfPropertyChange("CanCreateRegister");
                }
            }
        }

        public void EditDetail()
        {
            if (!ParentViewModel.IsDetailPanelOpen)
                ToggleDetailPanel();

            SetEditButtons();
        }

        private bool _canEditDetail = true;

        public bool CanEditDetail
        {
            get { return _canEditDetail; }
            set
            {
                if (_canEditDetail != value)
                {
                    _canEditDetail = value;
                    NotifyOfPropertyChange("CanEditDetail");
                    NotifyOfPropertyChange("CanPrintDetail");
                }
            }
        }

        private bool _canCancel1;

        public new bool CanCancel
        {
            get { return _canCancel1; }
            set
            {
                if (_canCancel1 != value)
                {
                    _canCancel1 = value;
                    NotifyOfPropertyChange("CanCancel");
                }
            }
        }

        public new void Cancel()
        {
            _isCancelling = true;
            base.Cancel();

            CloseCheckHelper(true);

            if (_parent != null && _parent.LastRegisterId > 0)
            {
                _parent.ListItemId = _parent.LastRegisterId;
                SetReadOnlyButtons();
            }
            else if (_parent != null && _parent.LastRegisterId < 0 && _parent.ListItemId > 0)
            {
                var previousListItemId = _parent.ListItemId;
                _parent.ListItemId = -1;
                _parent.ListItemId = previousListItemId;

                SetReadOnlyButtons();
            }
            else
            {
                Model.IsReadOnly = true;
                ShowEmptyRegister();
            }

            _isCancelling = false;
        }

        public new void Save()
        {
            //IsBusy = true;

            _isSaving = true;
            base.Save();

            if (Error != null)
            {
                MessageBox.Show(Error.Message, "SaveError".GetUiTranslation(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _refreshDateTime = DateTime.Now;

            if (_parent != null)
                _parent.ListItemId = Model.RegisterId;

            if (ViewNamedElements != null)
                ViewModelBinder.RebindProperties(this);

            NotifyOfPropertyChange("Audit");
            SetReadOnlyButtons();
            _isSaving = false;

            //IsBusy = false;

            ParentViewModel.AutoRefreshDocuments();
        }

        public void PrintDetail()
        {
            PrintRecord.DoPrintRecord(this, _refreshDateTime, 4, "IncomingRegisterShortName".GetUiTranslation(),
                "IncomingRegisterReportName".GetUiTranslation(), Model.RegisterId);
        }

        public bool CanPrintDetail
        {
            get { return _canEditDetail; }
        }

        #endregion
    }
}