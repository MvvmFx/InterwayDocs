using System;
using System.ComponentModel;
using System.Windows.Forms;
using Codisa.InterwayDocs.Business;
using Codisa.InterwayDocs.Business.SearchObjects;
using MvvmFx.CaliburnMicro;

namespace Codisa.InterwayDocs.WindowsForms.Framework
{
    public class BookViewModelBase<T, TC, TM> : ConductorWithModel<TC, TM>
        where T : IBookViewModel
        where TC : class
        where TM : class
    {
        #region Fields

        private bool _isViewAttached;
        private DateTime _todayDate;

        #endregion

        #region Properties

        public MainFormViewModel ParentViewModel { get; set; }

        public IGenericCriteriaInformation Criteria { get; set; }

        public bool ShowDetailPanel { get; set; } = true;

        private int _listItemId;

        public int ListItemId
        {
            get { return _listItemId; }
            set
            {
                if (_listItemId != value)
                {
                    _listItemId = value;
                    if (_listItemId > 0)
                        ActivateItem(new IncomingDetailViewModel(_listItemId));
                    NotifyOfPropertyChange("ListItemId");
                }
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

        public BookViewModelBase()
        {
            GetTodayDate();

            Criteria = new IncomingBookCriteriaGet();
            GetCommonCriteria();
            ResetDate();

            RefreshDocuments();

            ManageObjectLifetime = false;

            PropertyChanged += OnIncomingViewModelPropertyChanged;
            ViewAttached += OnIncomingViewModelViewAttached;
        }

        private void OnIncomingViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Parent")
            {
                PropertyChanged -= OnIncomingViewModelPropertyChanged;
                ParentViewModel = Parent as MainFormViewModel;
            }
        }

        private void OnIncomingViewModelViewAttached(object sender, ViewAttachedEventArgs e)
        {
            ViewAttached -= OnIncomingViewModelViewAttached;
            _isViewAttached = true;

            DisplayName = "Livro de correspondência recebida";
            ResetHeaderMessage();
            FastDate = Criteria.SelectedFastDateIndex;
            if (!ParentViewModel.ShowSearchPanel)
                SearchAreaToggle();
        }

        private void TriggerEmptyRegisterShow()
        {
            if (Model.Count == 0)
                CreateNew(false);
        }

        #endregion

        #region Date helpers

        private void GetTodayDate()
        {
            _todayDate = DateTime.Today;
        }

        private void ResetDate()
        {
            if (string.IsNullOrEmpty(Criteria.CriteriaEndDate))
            {
                if (string.IsNullOrEmpty(Criteria.CriteriaStartDate))
                    Criteria.CriteriaStartDate = _todayDate.Date;
            }
        }

        private void GetCommonCriteria()
        {
            Criteria.GetCommonCriteria();
            FastDate = Criteria.SelectedFastDateIndex;
        }

        private void StoreCommonCriteria()
        {
            Criteria.SelectedFastDateIndex = FastDate;
            Criteria.StoreCommonCriteria();
        }

        private void ResetHeaderMessage()
        {
            var todayDate = _todayDate.Date.ToString("d");
            var startDate = string.IsNullOrEmpty(Criteria.CriteriaStartDate.Date.ToString("d"))
                ? null
                : Criteria.CriteriaStartDate.Date.ToString("d");
            var endDate = string.IsNullOrEmpty(Criteria.CriteriaEndDate)
                ? null
                : Criteria.CriteriaEndDate.Date.ToString("d");

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

                message += Criteria.CriteriaEndDate.Date.ToString("d");
            }

            HeaderMessage = message;
        }

        #endregion

        #region Refresh list

        public void RefreshDocuments()
        {
            DoRefresh(() => IncomingBook.GetIncomingBook(Criteria as IncomingBookCriteriaGet));
            if (_isViewAttached)
            {
                var haveDataContext = GetView() as IHaveDataContext;
                if (haveDataContext != null)
                    haveDataContext.DataContext = this;
            }

            TriggerEmptyRegisterShow();
        }

        #endregion

        #region Overrides

        protected override void OnError(Exception error)
        {
            MessageBox.Show(error.Message, @"Erro de operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region Activate New Document

        public void CreateNew(bool doCreate)
        {
            foreach (var child in GetChildren())
            {
                if (child != null)
                    child.TryClose();
            }

            ListItemId = -1;
            ActivateItem(new IncomingDetailViewModel(doCreate));
        }

        #endregion

        #region Actions methods and guard properties

        public void ProcessFastDateOption()
        {
            if (!_isViewAttached)
                return;

            if (FastDate != FastDateOptions.GetIndex("DateRange"))
                DoSearch();
            else
                ViewSearchAreaShow();
        }

        private void ViewSearchAreaShow()
        {
            if (_isViewAttached)
            {
                var bookView = GetView() as IBookView;
                if (bookView != null)
                    bookView.ViewSearchAreaShow();
            }
        }

        public void SearchAreaToggle()
        {
            if (_isViewAttached)
            {
                var bookView = GetView() as IBookView;
                if (bookView != null)
                    bookView.ViewSearchAreaToggle();
            }
        }

        public void Search()
        {
            FastDate = FastDateOptions.GetIndex("DateRange");
            DoSearch();
        }

        private void DoSearch()
        {
            ResetDate();
            StoreCommonCriteria();
            ResetHeaderMessage();
            RefreshDocuments();
        }

        public void PrintList()
        {
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

        #endregion
    }
}