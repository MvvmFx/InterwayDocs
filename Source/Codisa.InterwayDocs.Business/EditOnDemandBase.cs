using System;
using Csla;

namespace Codisa.InterwayDocs.Business
{
    [Serializable]
    public abstract class EditOnDemandBase<T> : BusinessBase<T> where T : EditOnDemandBase<T>
    {
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