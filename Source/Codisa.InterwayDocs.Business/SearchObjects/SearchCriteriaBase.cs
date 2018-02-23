using System;
using System.Diagnostics.CodeAnalysis;
using Codisa.InterwayDocs.Business.Properties;
using Codisa.InterwayDocs.Rules;
using Csla;

namespace Codisa.InterwayDocs.Business.SearchObjects
{
    /// <summary>
    /// SearchCriteriaBase criteria base class.
    /// </summary>
    [Serializable]
    public abstract class SearchCriteriaBase<T> : BusinessBase<T> where T : SearchCriteriaBase<T>,
        IGenericCriteriaInformation
    {
        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="StartDate"/> property.
        /// </summary>
        [SuppressMessage("ReSharper", "StaticMemberInGenericType")]
        public static readonly PropertyInfo<SmartDate> StartDateProperty = RegisterProperty<SmartDate>(p => p.StartDate, "Desde");

        /// <summary>
        /// Gets or sets the Start Date.
        /// </summary>
        /// <value>The Start Date.</value>
        public string StartDate
        {
            get { return GetPropertyConvert<SmartDate, string>(StartDateProperty); }
            set { SetPropertyConvert(StartDateProperty, value); }
        }

        /// <summary>
        /// Gets or sets the Start Date Criteria.
        /// </summary>
        /// <value>The Start Date Criteria.</value>
        public SmartDate CriteriaStartDate
        {
            get { return GetProperty(StartDateProperty); }
            set { SetProperty(StartDateProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="EndDate"/> property.
        /// </summary>
        [SuppressMessage("ReSharper", "StaticMemberInGenericType")]
        public static readonly PropertyInfo<SmartDate> EndDateProperty = RegisterProperty<SmartDate>(p => p.EndDate, "Até");

        /// <summary>
        /// Gets or sets the End Date.
        /// </summary>
        /// <value>The End Date.</value>
        public string EndDate
        {
            get { return GetPropertyConvert<SmartDate, string>(EndDateProperty); }
            set { SetPropertyConvert(EndDateProperty, value); }
        }

        /// <summary>
        /// Gets or sets the End Date Criteria.
        /// </summary>
        /// <value>The End Date Criteria.</value>
        public SmartDate CriteriaEndDate
        {
            get { return GetProperty(EndDateProperty); }
            set { SetProperty(EndDateProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="FullText"/> property.
        /// </summary>
        [SuppressMessage("ReSharper", "StaticMemberInGenericType")]
        public static readonly PropertyInfo<string> FullTextProperty = RegisterProperty<string>(p => p.FullText);

        /// <summary>
        /// Gets or sets the Full Text.
        /// </summary>
        /// <value>The Full Text.</value>
        public string FullText
        {
            get { return GetProperty(FullTextProperty); }
            set { SetProperty(FullTextProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DateTypeList"/> property.
        /// </summary>
        [SuppressMessage("ReSharper", "StaticMemberInGenericType")]
        public static readonly PropertyInfo<CriteriaDateTypeList> DateTypeListProperty = RegisterProperty<CriteriaDateTypeList>(p => p.DateTypeList);

        /// <summary>
        /// Gets or sets the list of date types for this criteria type.
        /// </summary>
        /// <value>The list of date types.</value>
        public CriteriaDateTypeList DateTypeList
        {
            get { return GetProperty(DateTypeListProperty); }
            set { SetProperty(DateTypeListProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SelectedDateTypeIndex"/> property.
        /// </summary>
        [SuppressMessage("ReSharper", "StaticMemberInGenericType")]
        public static readonly PropertyInfo<int> SelectedDateTypeIndexProperty = RegisterProperty<int>(p => p.SelectedDateTypeIndex);

        /// <summary>
        /// Gets or sets the selected date type index.
        /// </summary>
        /// <value>The selected date type index.</value>
        public int SelectedDateTypeIndex
        {
            get { return GetProperty(SelectedDateTypeIndexProperty); }
            set { SetProperty(SelectedDateTypeIndexProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="SelectedFastDateIndex"/> property.
        /// </summary>
        [SuppressMessage("ReSharper", "StaticMemberInGenericType")]
        public static readonly PropertyInfo<int> SelectedFastDateIndexProperty = RegisterProperty<int>(p => p.SelectedFastDateIndex, string.Empty, -1);

        /// <summary>
        /// Gets or sets the selected fast date index.
        /// </summary>
        /// <value>The selected fast date index.</value>
        public int SelectedFastDateIndex
        {
            get { return GetProperty(SelectedFastDateIndexProperty); }
            set { SetProperty(SelectedFastDateIndexProperty, value); }
        }

        /// <summary>
        /// Gets or sets the selected date type name.
        /// </summary>
        /// <value>The selected date type name.</value>
        public string SelectedDateTypeName
        {
            get { return GetNameOfDateType(); }
            set { SeIndexOftDateType(value); }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCriteriaBase{T}"/> class.
        /// </summary>
        /// <remarks> A parameterless constructor is required by the MobileFormatter.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SearchCriteriaBase()
        {
        }

        #endregion

        #region Business Rules and Property Authorization

        /// <summary>
        /// Override this method in your business class to be notified when you need to set up shared business rules.
        /// </summary>
        /// <remarks>
        /// This method is automatically called by CSLA.NET when your object should associate
        /// per-type validation rules with its properties.
        /// </remarks>
        protected override void AddBusinessRules()
        {
            base.AddBusinessRules();

            // Property Business Rules

            // StartDate
            BusinessRules.AddRule(new DateNotInFuture(StartDateProperty)
            {
                MessageDelegate = () => Resources.DateNotInFuture,
                Priority = 0
            });
            // EndDate
            BusinessRules.AddRule(new DateNotInFuture(EndDateProperty)
            {
                MessageDelegate = () => Resources.DateNotInFuture,
                Priority = 0
            });
            BusinessRules.AddRule(new GreaterThanOrEqual(EndDateProperty, StartDateProperty)
            {
                MessageDelegate = () => Resources.EndDateGreaterThanOrEqualStartDate,
                Priority = 1
            });
            // FullText
            BusinessRules.AddRule(new CollapseWhiteSpace(FullTextProperty) {Priority = 0});
            BusinessRules.AddRule(new ThreePartsFullText(FullTextProperty)
            {
                MessageDelegate = () => Resources.ThreePartsFullText,
                Priority = 1
            });
            // SelectedFastDateIndex
            BusinessRules.AddRule(new FastDateToDateRange(SelectedFastDateIndexProperty));
        }

        #endregion

        #region DataType name helpers

        private string GetNameOfDateType()
        {
            var result = string.Empty;
            var index = 0;
            foreach (var dateType in DateTypeList)
            {
                if (index == SelectedDateTypeIndex)
                {
                    result = dateType.DateTypeName;
                    break;
                }

                index++;
            }

            return result;
        }

        private void SeIndexOftDateType(string name)
        {
            var index = 0;
            foreach (var dateType in DateTypeList)
            {
                if (name == dateType.DateTypeName)
                {
                    SelectedDateTypeIndex = index;
                    break;
                }

                index++;
            }
        }

        #endregion

        #region Common criteria methods

        /// <summary>
        /// Gets the common criteria.
        /// </summary>
        /// <param name="fastDateOptions">The fast date options class to use.</param>
        /// <param name="commonBookCriteria">The common book criteria.</param>
        public void GetCommonCriteria(FastDateOptions fastDateOptions, CommonBookCriteria commonBookCriteria)
        {
            SelectedDateTypeIndex = commonBookCriteria.SelectedDateTypeIndex;
            SelectedFastDateIndex = commonBookCriteria.SelectedFastDateIndex;

            if (SelectedFastDateIndex == fastDateOptions.GetIndex("FreeSearch"))
            {
                if (!string.IsNullOrEmpty(commonBookCriteria.StartDate))
                    StartDate = commonBookCriteria.StartDate;

                if (!string.IsNullOrEmpty(commonBookCriteria.EndDate))
                    EndDate = commonBookCriteria.EndDate;
            }

            if (!string.IsNullOrEmpty(commonBookCriteria.FullText))
                FullText = commonBookCriteria.FullText;

            var iHaveArchiveLocation = this as IHaveArchiveLocation;
            if (iHaveArchiveLocation != null && !string.IsNullOrEmpty(commonBookCriteria.ArchiveLocation))
                iHaveArchiveLocation.ArchiveLocation = commonBookCriteria.ArchiveLocation;
        }

        /// <summary>
        /// Stores the common criteria.
        /// </summary>
        /// <param name="commonBookCriteria">The common book criteria.</param>
        public void StoreCommonCriteria(CommonBookCriteria commonBookCriteria)
        {
            commonBookCriteria.SelectedFastDateIndex = SelectedFastDateIndex;
            commonBookCriteria.SelectedDateTypeIndex = SelectedDateTypeIndex;
            commonBookCriteria.StartDate = ReadProperty(StartDateProperty);
            commonBookCriteria.EndDate = ReadProperty(EndDateProperty);
            commonBookCriteria.FullText = FullText;

            var iHaveArchiveLocation = this as IHaveArchiveLocation;
            if (iHaveArchiveLocation != null)
                commonBookCriteria.ArchiveLocation = iHaveArchiveLocation.ArchiveLocation;
        }

        #endregion
    }
}