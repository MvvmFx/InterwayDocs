using System.Linq;
using Codisa.InterwayDocs.Business.Properties;
using Codisa.InterwayDocs.Configuration;
using Csla;
using Csla.Core;
using Csla.Rules.CommonRules;

namespace Codisa.InterwayDocs.Business
{
    public partial class IncomingRegister
    {

        #region Fields

        [NotUndoable]
        private static string _objectName;
        [NotUndoable]
        private static PropertyRequiredList _requiredList;

        public PropertyRequiredList RequiredList
        {
            get
            {
                if (_requiredList == null)
                    _requiredList = PropertyRequiredList.GetPropertyRequiredList(_objectName);

                return _requiredList;
            }
        }

        #endregion

        #region OnDeserialized actions

        /// <summary>
        /// This method is called on a newly deserialized object
        /// after deserialization is complete.
        /// </summary>
        /// <param name="context">Serialization context object.</param>
        protected override void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
        {
            base.OnDeserialized(context);
            Saved += OnIncomingRegisterSaved;
            // add your custom OnDeserialized actions here.
        }

        #endregion

        #region Custom Business Rules and Property Authorization

        partial void AddBusinessRulesExtend()
        {
            if (string.IsNullOrEmpty(_objectName))
                _objectName = ToString().Substring(ToString().LastIndexOf('.') + 1);

            var allProperties = FieldManager.GetRegisteredProperties();

            foreach (IPropertyInfo propertyInfo in from propertyInfo in allProperties
                from propertyConfiguration in RequiredList
                where propertyInfo.Name == propertyConfiguration.Name
                where propertyConfiguration.IsRequired
                select propertyInfo)
            {
                BusinessRules.AddRule(new Required(propertyInfo)
                {
                    MessageText = Resources.Required
                });
            }
        }

        #endregion

        #region Implementation of DataPortal Hooks

        //partial void OnCreate(DataPortalHookArgs args)
        //{
        //    throw new NotImplementedException();
        //}

        //partial void OnFetchPre(DataPortalHookArgs args)
        //{
        //    throw new NotImplementedException();
        //}

        //partial void OnFetchPost(DataPortalHookArgs args)
        //{
        //    throw new NotImplementedException();
        //}

        //partial void OnFetchRead(DataPortalHookArgs args)
        //{
        //    throw new NotImplementedException();
        //}

        //partial void OnUpdatePre(DataPortalHookArgs args)
        //{
        //    throw new NotImplementedException();
        //}

        //partial void OnUpdatePost(DataPortalHookArgs args)
        //{
        //    throw new NotImplementedException();
        //}

        //partial void OnInsertPre(DataPortalHookArgs args)
        //{
        //    throw new NotImplementedException();
        //}

        //partial void OnInsertPost(DataPortalHookArgs args)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

    }
}
