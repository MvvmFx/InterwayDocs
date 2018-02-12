using Codisa.InterwayDocs.Properties;
using Csla;

namespace Codisa.InterwayDocs.Framework
{
    public static class AuditFormater
    {
        public static string Format(SmartDate created, SmartDate changed)
        {
            created.FormatString = Resources.AuditCreatedFormat;
            if (changed == created)
                return string.Format(Resources.AuditNoChanges, created);

            changed.FormatString = Resources.AuditChangedSameDayFormat;
            if (changed.Date.Year == created.Date.Year && changed.Date.DayOfYear == created.Date.DayOfYear)
                return string.Format(Resources.AuditChangedSameDay, created, changed);

            changed.FormatString = Resources.AuditChangedFormat;
            return string.Format(Resources.AuditChanged, created, changed);
        }
    }
}