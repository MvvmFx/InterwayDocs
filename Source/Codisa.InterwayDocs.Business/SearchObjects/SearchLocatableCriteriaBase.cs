using System;
using Csla;
using Codisa.InterwayDocs.Rules;

namespace Codisa.InterwayDocs.Business.SearchObjects
{
    public abstract partial class SearchLocatableCriteriaBase<T> : SearchCriteriaBase<T>
        where T : SearchLocatableCriteriaBase<T>, IGenericCriteriaInformation, IHaveArchiveLocation
    {

        #region OnDeserialized actions

        /*/// <summary>
        /// This method is called on a newly deserialized object
        /// after deserialization is complete.
        /// </summary>
        protected override void OnDeserialized()
        {
            base.OnDeserialized();
            // add your custom OnDeserialized actions here.
        }*/

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
