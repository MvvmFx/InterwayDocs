using System;
using System.Diagnostics.CodeAnalysis;
using Codisa.InterwayDocs.Rules;
using Csla;

namespace Codisa.InterwayDocs.Business.SearchObjects
{
    /// <summary>
    /// SearchLocatableCriteriaBase criteria base class.
    /// </summary>
    [Serializable]
    public abstract class SearchLocatableCriteriaBase<T> : SearchCriteriaBase<T> where T : SearchLocatableCriteriaBase<T>,
            IGenericCriteriaInformation
    {

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="ArchiveLocation"/> property.
        /// </summary>
        [SuppressMessage("ReSharper", "StaticMemberInGenericType")]
        public static readonly PropertyInfo<string> ArchiveLocationProperty = RegisterProperty<string>(p => p.ArchiveLocation);

        /// <summary>
        /// Gets or sets the Archive Location.
        /// </summary>
        /// <value>The Archive Location.</value>
        public string ArchiveLocation
        {
            get { return GetProperty(ArchiveLocationProperty); }
            set { SetProperty(ArchiveLocationProperty, value); }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchLocatableCriteriaBase{T}"/> class.
        /// </summary>
        /// <remarks> A parameterless constructor is required by the MobileFormatter.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public SearchLocatableCriteriaBase()
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

            // ArchiveLocation
            BusinessRules.AddRule(new CollapseWhiteSpace(ArchiveLocationProperty));
        }

        #endregion

        #region RegisterPropertyLocal

        // Kept for records sake. Need to use it instead of RegisterProperty when inheriting from non-generic base classes.
        /*private static PropertyInfo<T> RegisterPropertyLocal<T>(Expression<Func<SearchLocatableCriteriaBase, object>> propertyLambdaExpression)
        {
            // http://dotnetbyexample.blogspot.pt/2010/08/fixing-clsa-property-registration.html

            var reflectedPropertyInfo = Reflect<SearchLocatableCriteriaBase>.GetProperty(propertyLambdaExpression);
            return RegisterProperty(typeof (SearchLocatableCriteriaBase),
                Csla.Core.FieldManager.PropertyInfoFactory.Factory.Create<T>(typeof (SearchLocatableCriteriaBase),
                    reflectedPropertyInfo.Name));
        }*/

        #endregion

    }
}