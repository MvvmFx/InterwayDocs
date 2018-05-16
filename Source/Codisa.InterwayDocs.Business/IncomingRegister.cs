using System.Linq;
using Codisa.InterwayDocs.Configuration;
using Csla;
using Csla.Core;
using Csla.Rules.CommonRules;

namespace Codisa.InterwayDocs.Business
{
    public partial class IncomingRegister
    {

        #region Extra fields & properties

        [NotUndoable]
        private const string ObjectName = "IncomingRegister";
        [NotUndoable]
        private static PropertyRequiredList _requiredList;
        // this might be a problem if business logic changes
        // and the required list depends on the role or document lifecycle.

        public static PropertyRequiredList RequiredList
        {
            get
            {
                if (_requiredList == null)
                    _requiredList = PropertyRequiredList.GetPropertyRequiredList(ObjectName);

                return _requiredList;
            }
        }

        #endregion

        #region OnDeserialized actions

        /*/// <summary>
        /// This method is called on a newly deserialized object
        /// after deserialization is complete.
        /// </summary>
        /// <param name="context">Serialization context object.</param>
        protected override void OnDeserialized(System.Runtime.Serialization.StreamingContext context)
        {
            base.OnDeserialized(context);
            // add your custom OnDeserialized actions here.
        }*/

        #endregion

        #region Custom Business Rules and Property Authorization

        partial void AddBusinessRulesExtend()
        {
            var allProperties = FieldManager.GetRegisteredProperties();

            foreach (IPropertyInfo propertyInfo in from propertyInfo in allProperties
                from propertyConfiguration in RequiredList
                where propertyInfo.Name == propertyConfiguration.Name
                where propertyConfiguration.IsRequired
                select propertyInfo)
            {
                BusinessRules.AddRule(new Required(propertyInfo)
                {
                    MessageDelegate = () => "Required".GetTranslation()
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
