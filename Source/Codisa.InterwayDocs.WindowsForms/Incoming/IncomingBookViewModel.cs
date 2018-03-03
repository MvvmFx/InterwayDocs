using System;
using System.ComponentModel;
using System.Linq;
#if WISEJ
using Wisej.Base;
using Wisej.Web;
#else
using System.Windows.Forms;
#endif
using Codisa.InterwayDocs.Business;
using Codisa.InterwayDocs.Business.SearchObjects;
using Codisa.InterwayDocs.Configuration;
using Codisa.InterwayDocs.Framework;
using Codisa.InterwayDocs.Properties;
using MvvmFx.CaliburnMicro;
using ApplicationContext = MvvmFx.CaliburnMicro.ApplicationContext;

namespace Codisa.InterwayDocs.Incoming
{
    public class IncomingBookViewModel : ConductorWithModel<IncomingDetailViewModel, IncomingBook>,
        IBookViewModel, IHaveConfigurationList
    {
        #region Fields

#if WINFORMS
        private static PropertyConfigurationList _configurationList;
#else
        private static PropertyConfigurationList _configurationList
        {
            get { return ApplicationBase.Session.Codisa_InterwayDocs_IncomingBookViewModel_ConfigurationList; }
            set { ApplicationBase.Session.Codisa_InterwayDocs_IncomingBookViewModel_ConfigurationList = value; }
        }
#endif

        private bool _isViewAttached;
        private bool _isRefreshingTranslations;
        private DateTime _todayDate;
        private DateTime _refreshDateTime;
        private IncomingBookCriteriaGet _refreshCriteria;

        #endregion

        #region Properties

        public IGenericCriteriaInformation Criteria { get; set; }

        public PropertyConfigurationList ConfigurationList
        {
            get
            {
                if (_configurationList == null)
                    _configurationList = PropertyConfigurationList.GetPropertyConfigurationList("IncomingInfo",
                        ApplicationContext.UICulture);

                return _configurationList;
            }
        }

        public IMainFormViewModel RootViewModel { get; set; }

        public bool IsDetailPanelOpen
        {
            get { return RootViewModel.IsDetailPanelOpen; }
            set { RootViewModel.IsDetailPanelOpen = value; }
        }

        public bool IsDetailPanelStateOpen { get; set; } = true;

        private int _listItemId;

        public int ListItemId
        {
            get { return _listItemId; }
            set
            {
                // fix troubles when setting the time
                //if (_listItemId != value)
                //{
                _listItemId = value;
                if (_listItemId > 0)
                    ActivateItem(new IncomingDetailViewModel(_listItemId));

                NotifyOfPropertyChange("ListItemId");
                //}
            }
        }

        private int _lastRegisterId;

        public int LastRegisterId
        {
            get { return _lastRegisterId; }
            set
            {
                if (_lastRegisterId != value)
                {
                    _lastRegisterId = value;
                    NotifyOfPropertyChange("LastRegisterId");
                }
            }
        }

        private string _headerMessage;

        public string HeaderMessage
        {
            get { return _headerMessage; }
            set
            {
                if (_headerMessage != value)
                {
                    _headerMessage = value;
                    NotifyOfPropertyChange("HeaderMessage");
                }
            }
        }

        public int DateType
        {
            get { return Criteria.SelectedDateTypeIndex; }
            set
            {
                if (Criteria.SelectedDateTypeIndex != value)
                {
                    Criteria.SelectedDateTypeIndex = value;
                    NotifyOfPropertyChange("DateType");
                }
            }
        }

        private int _fastDate;

        public int FastDate
        {
            get { return _fastDate; }
            set
            {
                if (_fastDate != value)
                {
                    _fastDate = value;
                    ProcessFastDateOption();
                    NotifyOfPropertyChange("FastDate");
                }
            }
        }

        #endregion

        #region Initializers

        public IncomingBookViewModel()
        {
            PropertyChanged += OnPropertyChanged;
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Parent")
            {
                PropertyChanged -= OnPropertyChanged;
                RootViewModel = Parent as IMainFormViewModel;

                try
                {
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Resources.OperationError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Invoked when the Model changes, allowing event handlers to be unhooked from the old object and hooked on the new object.
        /// </summary>
        /// <param name="oldValue">Previous Model reference.</param>
        /// <param name="newValue">New Model reference.</param>
        protected override void OnModelChanged(IncomingBook oldValue, IncomingBook newValue)
        {
            if (oldValue != null)
                oldValue.ListChanged -= Model_ListChanged;

            if (newValue != null)
                newValue.ListChanged += Model_ListChanged;

            base.OnModelChanged(oldValue, newValue);
        }

        //Following Rocky's proposal to override OnModelChanged

        /*/// <summary>
        /// Method called after a refresh operation has completed and before the model is updated (when successful).
        /// </summary>
        /// <param name="model">The model.</param>
        protected override void OnRefreshing(IncomingBook model)
        {
            if (model != null)
                Model.ListChanged -= Model_ListChanged;

            base.OnRefreshing(model);
        }

        /// <summary>
        /// Method called after a refresh operation has completed (whether successful or not).
        /// </summary>
        protected override void OnRefreshed()
        {
            base.OnRefreshed();
            Model.ListChanged += Model_ListChanged;
        }*/

        private void Model_ListChanged(object sender, ListChangedEventArgs e)
        {
            HandleEmptyList();
        }

        protected override void OnViewAttached(object view, object context)
        {
            base.OnViewAttached(view, context);

            _isViewAttached = true;

            DisplayName = Resources.IncomingBookDisplayName;
            ResetHeaderMessage();
            FastDate = Criteria.SelectedFastDateIndex;
            if (!RootViewModel.IsSearchPanelOpen)
                ToggleSearchArea();
        }

        private void Populate()
        {
            Criteria = new IncomingBookCriteriaGet();

            ManageObjectLifetime = false;
        }

        private void HandleEmptyList()
        {
            if (Model != null)
            {
                if (Model.Count == 0)
                    CreateNew(false);

                CanPrintList = Model.Count != 0;
            }
        }

        #endregion

        #region Translations

        public static void ClearConfigurationList()
        {
            _configurationList = null;
        }

        public void RefreshTranslation()
        {
            _isRefreshingTranslations = true;

            var dateType = DateType;
            var fastDate = FastDate;
            var fullText = Criteria.FullText;
            var startDate = Criteria.StartDate;
            var endDate = Criteria.EndDate;

            FastDateOptionsFacade.Instance.RefreshDictionary();
            Criteria = new IncomingBookCriteriaGet();
            Criteria.FullText = fullText;
            Criteria.StartDate = startDate;
            Criteria.EndDate = endDate;

            DisplayName = Resources.IncomingBookDisplayName;
            ResetHeaderMessage();

            var view = GetView() as IRefreshTranslation;
            if (view != null)
                view.RefreshTranslation();

            DateType = dateType;
            FastDate = fastDate;

            ActiveItem.RefreshTranslation();

            _isRefreshingTranslations = false;
        }

        #endregion

        #region Date helpers

        private void GetTodayDate()
        {
            _todayDate = DateTime.Today;
        }

        private void GetCommonCriteria()
        {
            Criteria.GetCommonCriteria(FastDateOptionsFacade.Instance, CommonBookCriteriaFacade.Instance);
            FastDate = Criteria.SelectedFastDateIndex;
        }

        private void StoreCommonCriteria()
        {
            Criteria.SelectedFastDateIndex = FastDate;
            Criteria.StoreCommonCriteria(CommonBookCriteriaFacade.Instance);
        }

        private void ResetHeaderMessage()
        {
            var todayDate = _todayDate.Date.ToString(Resources.DateTimeFormat);
            var startDate = string.IsNullOrEmpty(Criteria.CriteriaStartDate)
                ? null
                : Criteria.CriteriaStartDate.Date.ToString(Resources.DateTimeFormat);
            var endDate = string.IsNullOrEmpty(Criteria.CriteriaEndDate)
                ? null
                : Criteria.CriteriaEndDate.Date.ToString(Resources.DateTimeFormat);

            var message = string.Empty;

            var ellipsisPresent = false;

            if (!string.IsNullOrEmpty(startDate))
            {
                message = startDate;
                if (startDate != todayDate && startDate != endDate)
                {
                    message += " ...";
                    ellipsisPresent = true;
                }
            }

            if (!string.IsNullOrEmpty(endDate) && startDate != endDate)
            {
                if (!ellipsisPresent)
                    message += "...";

                message += " ";

                message += Criteria.CriteriaEndDate.Date.ToString(Resources.DateTimeFormat);
            }

            HeaderMessage = message;
        }

        #endregion

        #region Refresh list

        public void AutoRefreshDocuments()
        {
            var listItemId = ListItemId;
            RefreshDocuments();
            ListItemId = listItemId;
        }

        public void RefreshDocuments()
        {
            DoRefresh(() => IncomingBook.GetIncomingBook(Criteria as IncomingBookCriteriaGet));
            StoreRefreshData();
            if (_isViewAttached)
            {
                var haveDataContext = GetView() as IHaveDataContext;
                if (haveDataContext != null)
                    haveDataContext.DataContext = this;
            }

            HandleEmptyList();
        }

        private void StoreRefreshData()
        {
            _refreshDateTime = DateTime.Now;
            _refreshCriteria = new IncomingBookCriteriaGet();
            var criteria = Criteria as IncomingBookCriteriaGet;
            if (criteria != null)
            {
                _refreshCriteria.FullText = criteria.FullText;
                _refreshCriteria.ArchiveLocation = criteria.ArchiveLocation;
                _refreshCriteria.StartDate = criteria.StartDate;
                _refreshCriteria.EndDate = criteria.EndDate;
                _refreshCriteria.SelectedDateTypeName = criteria.SelectedDateTypeName;
            }
        }

        #endregion

        #region Overrides

        protected override void OnError(Exception error)
        {
            MessageBox.Show(error.Message, Resources.OperationError, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>Called when activating.</summary>
        protected override void OnActivate()
        {
            GetTodayDate();
            GetCommonCriteria();
            RefreshDocuments();

            base.OnActivate();
        }

        /// <summary>Called when deactivating.</summary>
        /// <param name="close">Indicates whether this instance will be closed.</param>
        protected override void OnDeactivate(bool close)
        {
            if (close)
                Model.ListChanged -= Model_ListChanged;

            base.OnDeactivate(close);
        }

        #endregion

        #region Activate New Document

        public void CreateNew(bool doCreate)
        {
            ListItemId = -1;
            ActivateItem(new IncomingDetailViewModel(doCreate));
        }

        #endregion

        #region Actions methods and guard properties

        public void ProcessFastDateOption()
        {
            if (!_isViewAttached || _isRefreshingTranslations)
                return;

            if (FastDate != FastDateOptionsFacade.Instance.GetIndex("FreeSearch"))
                DoSearch();
            else
                ViewSearchAreaShow();
        }

        private void ViewSearchAreaShow()
        {
            if (_isViewAttached)
            {
                (GetView() as IBookView)?.ShowSearchArea();
            }
        }

        public void ToggleSearchArea()
        {
            if (_isViewAttached)
            {
                (GetView() as IBookView)?.ToggleSearchArea();
            }
        }

        public void Search()
        {
            FastDate = FastDateOptionsFacade.Instance.GetIndex("FreeSearch");
            DoSearch();
        }

        private void DoSearch()
        {
            StoreCommonCriteria();
            ResetHeaderMessage();
            RefreshDocuments();
        }

        public void PrintList()
        {
            PrintBook.DoPrintBook(this, ConfigurationList, _refreshCriteria, _refreshDateTime,
                6, Resources.IncomingBookShortName, Resources.IncomingBookDisplayName);
        }

        private bool _canPrintList;

        public bool CanPrintList
        {
            get { return _canPrintList; }
            set
            {
                if (_canPrintList != value)
                {
                    _canPrintList = value;
                    NotifyOfPropertyChange("CanPrintList");
                }
            }
        }

        public void DataGridView()
        {
            if (!IsDetailPanelOpen)
            {
                GetChildren().FirstOrDefault()?.ToggleDetailPanel();
            }
        }

        #endregion
    }
}