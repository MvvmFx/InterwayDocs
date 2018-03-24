using System;
using Csla;

namespace Codisa.InterwayDocs.Business
{
    public abstract partial class EditOnDemandBase<T> : BusinessBase<T>
        where T : EditOnDemandBase<T>
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

        #region Status properties

        private bool _isReadOnly;

        public bool IsReadOnly
        {
            get { return _isReadOnly; }
            set
            {
                if (_isReadOnly != value)
                {
                    _isReadOnly = value;
                    OnPropertyChanged(nameof(IsReadOnly));
                    if (!_isReadOnly)
                    {
                        BusinessRules.CheckRules();
                        OnPropertyChanged(string.Empty);
                    }
                }
            }
        }

        #endregion

    }
}
