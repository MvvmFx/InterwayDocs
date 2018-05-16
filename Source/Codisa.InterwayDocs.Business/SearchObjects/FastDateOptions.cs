using System;
using Csla.Core;

namespace Codisa.InterwayDocs.Business.SearchObjects
{
    [Serializable]
    public class FastDateOptions
    {
        private readonly MobileDictionary<string, string> _optionsDictionary =
            new MobileDictionary<string, string>();

        public MobileDictionary<string, string> GetDictionary()
        {
            if (_optionsDictionary.Count == 0)
                LoadDictionary();

            return _optionsDictionary;
        }

        public void RefreshDictionary()
        {
            _optionsDictionary.Clear();
        }

        private void LoadDictionary()
        {
            _optionsDictionary.Add("Today", "FastDateOptionsToday".GetTranslation());
            _optionsDictionary.Add("Yesterday", "FastDateOptionsYesterday".GetTranslation());
            _optionsDictionary.Add("Last7Days", "FastDateOptionsLast7Days".GetTranslation());
            _optionsDictionary.Add("Last15Days", "FastDateOptionsLast15Days".GetTranslation());
            _optionsDictionary.Add("Last30Days", "FastDateOptionsLast30Days".GetTranslation());
            _optionsDictionary.Add("Last90Days", "FastDateOptionsLast90Days".GetTranslation());
            _optionsDictionary.Add("FreeSearch", "FastDateOptionsFreeSearch".GetTranslation());
        }

        public int GetIndex(string key)
        {
            var result = 0;
            foreach (var valuePair in GetDictionary())
            {
                if (valuePair.Key == key)
                    break;

                result++;
            }

            return result;
        }
    }
}