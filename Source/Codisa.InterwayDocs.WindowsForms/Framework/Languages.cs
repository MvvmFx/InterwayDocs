using System.Collections.Generic;

namespace Codisa.InterwayDocs.Framework
{
    internal class Languages : List<Language>
    {
        private static readonly List<Language> InternalList = new List<Language>();

        public static List<Language> LanguageList
        {
            get
            {
                if (InternalList.Count == 0)
                {
                    InternalList.Add(new Language(0, "en", "English"));
                    InternalList.Add(new Language(1, "es", "Español"));
                    InternalList.Add(new Language(2, "fr", "Français"));
                    InternalList.Add(new Language(3, "pt", "Português"));
                }

                return InternalList;
            }
        }

        public static int GetIndexOfUICode(string uiCode)
        {
            for (int index = 0; index < LanguageList.Count; index++)
            {
                if (LanguageList[index].UICode == uiCode)
                    return index;
            }

            return -1;
        }
    }

    internal class Language
    {
        public int Index { get; }
        public string UICode { get; }
        public string Name { get; }

        private Language()
        {
            // force to use parametrized constructor
        }

        public Language(int index, string uiCode, string name)
        {
            Index = index;
            UICode = uiCode;
            Name = name;
        }
    }
}