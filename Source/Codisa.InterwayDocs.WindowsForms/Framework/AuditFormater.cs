using Csla;

namespace Codisa.InterwayDocs.Framework
{
    public static class AuditFormater
    {
        public static string Format(SmartDate created, SmartDate changed)
        {
            created.FormatString = "AuditCreatedFormat".GetUiTranslation();
            if (changed == created)
                return string.Format("AuditNoChanges".GetUiTranslation(), created);

            changed.FormatString = "AuditChangedSameDayFormat".GetUiTranslation();
            if (changed.Date.Year == created.Date.Year && changed.Date.DayOfYear == created.Date.DayOfYear)
                return string.Format("AuditChangedSameDay".GetUiTranslation(), created, changed);

            changed.FormatString = "AuditChangedFormat".GetUiTranslation();
            return string.Format("AuditChanged".GetUiTranslation(), created, changed);
        }
    }
}