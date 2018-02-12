using System;

namespace Codisa.InterwayDocs.Business
{
    internal enum ClauseStatus
    {
        NoClause,
        WhereAdded,
        ClauseAdded
    }

    internal static class QueryBuilder
    {
        internal static void AddOrClause(ref string query, ref ClauseStatus status)
        {
            AddClause(ref query, ref status, true);
        }

        internal static void AddClause(ref string query, ref ClauseStatus status, bool useOr = false)
        {
            if (status == ClauseStatus.NoClause)
            {
                status = ClauseStatus.WhereAdded;
                query += "WHERE" + Environment.NewLine;
            }
            else if (status == ClauseStatus.ClauseAdded)
            {
                if (useOr)
                    query += " OR" + Environment.NewLine;
                else
                    query += " AND" + Environment.NewLine;
            }
        }

        internal static string NormalizeToDate(string tableDot, string column)
        {
            var result = string.Empty;

            if (column == "CreateDate" || column == "ChangeDate")
                result += $"CONVERT(DATE, {tableDot}{column})";
            else
                result += $"{tableDot}{column}";

            return result;
        }
    }
}