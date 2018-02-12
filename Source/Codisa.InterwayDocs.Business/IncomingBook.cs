using System;
using System.Data;
using System.Data.SqlClient;

namespace Codisa.InterwayDocs.Business
{
    public partial class IncomingBook
    {

        #region OnDeserialized actions

        /// <summary>
        /// This method is called on a newly deserialized object
        /// after deserialization is complete.
        /// </summary>
        protected override void OnDeserialized()
        {
            base.OnDeserialized();
            IncomingRegisterSaved.Register(this);
            // add your custom OnDeserialized actions here.
        }

        #endregion

        #region Inlines queries

        private const string QueryList =
            "IncomingRegisters.RegisterId, RegisterDate, DocumentType, DocumentReference, DocumentEntity, DocumentDept, DocumentClass, DocumentDate, Subject, SenderName, ReceptionDate, RoutedTo, Notes, ArchiveLocation";

        private string GetIncomingBookInlineQuery(IncomingBookCriteriaGet crit)
        {
            var clauseStatus = ClauseStatus.NoClause;

            var query = GetSelectPart(crit);

            if (!string.IsNullOrEmpty(crit.FullText) ||
                !string.IsNullOrEmpty(crit.ArchiveLocation) ||
                !crit.CriteriaStartDate.IsEmpty ||
                !crit.CriteriaEndDate.IsEmpty)
                query = GetWherePart(query, crit, ref clauseStatus);

            query = GetOrderPart(query);

            return query;
        }

        private string GetSelectPart(IncomingBookCriteriaGet crit)
        {
            var query = "SELECT " + QueryList + Environment.NewLine + "FROM IncomingRegisters";
            if (!string.IsNullOrEmpty(crit.FullText))
                query += ", IncomingView";

            query += Environment.NewLine;
            return query;
        }

        private string GetWherePart(string query, IncomingBookCriteriaGet crit, ref ClauseStatus clauseStatus)
        {
            QueryBuilder.AddClause(ref query, ref clauseStatus);

            if (!string.IsNullOrEmpty(crit.FullText))
            {
                query += "IncomingView.RegisterId = IncomingRegisters.RegisterId";
                clauseStatus = ClauseStatus.ClauseAdded;
            }

            if (crit.SelectedDateTypeName == "AllDates")
            {
                if (!crit.CriteriaStartDate.IsEmpty && !crit.CriteriaEndDate.IsEmpty)
                {
                    QueryBuilder.AddClause(ref query, ref clauseStatus);
                    query += "(" + Environment.NewLine;
                    for (var dateTypeItem = 0; dateTypeItem < crit.DateTypeList.Count - 1; dateTypeItem++)
                    {
                        if (dateTypeItem > 0)
                            QueryBuilder.AddOrClause(ref query, ref clauseStatus);

                        var dateTypeName = crit.DateTypeList[dateTypeItem].DateTypeName;
                        query += "(";
                        query += QueryBuilder.NormalizeToDate("IncomingRegisters.", dateTypeName) +
                                 " >= @CriteriaStartDate";
                        clauseStatus = ClauseStatus.ClauseAdded;

                        QueryBuilder.AddClause(ref query, ref clauseStatus);
                        query += QueryBuilder.NormalizeToDate("IncomingRegisters.", dateTypeName) +
                                 " <= @CriteriaEndDate";
                        clauseStatus = ClauseStatus.ClauseAdded;
                        query += ")";
                    }
                    query += Environment.NewLine + ")";
                }
                else
                {
                    QueryBuilder.AddClause(ref query, ref clauseStatus);
                    query += "(" + Environment.NewLine;
                    for (var dateTypeItem = 0; dateTypeItem < crit.DateTypeList.Count - 1; dateTypeItem++)
                    {
                        if (!crit.CriteriaStartDate.IsEmpty)
                        {
                            QueryBuilder.AddOrClause(ref query, ref clauseStatus);

                            var dateTypeName = crit.DateTypeList[dateTypeItem].DateTypeName;
                            query += QueryBuilder.NormalizeToDate("IncomingRegisters.", dateTypeName) +
                                     " >= @CriteriaStartDate";
                            clauseStatus = ClauseStatus.ClauseAdded;
                        }

                        if (!crit.CriteriaEndDate.IsEmpty)
                        {
                            QueryBuilder.AddOrClause(ref query, ref clauseStatus);

                            var dateTypeName = crit.DateTypeList[dateTypeItem].DateTypeName;
                            query += QueryBuilder.NormalizeToDate("IncomingRegisters.", dateTypeName) +
                                     " <= @CriteriaEndDate";
                            clauseStatus = ClauseStatus.ClauseAdded;
                        }
                    }
                    query += Environment.NewLine + ")";
                }
            }
            else
            {
                foreach (var dateTypeInfo in crit.DateTypeList)
                {
                    if (dateTypeInfo.DateTypeName == crit.SelectedDateTypeName)
                    {
                        BuildWhereClause(crit, crit.SelectedDateTypeName, ref query, ref clauseStatus);
                        break;
                    }
                }
            }

            if (!string.IsNullOrEmpty(crit.ArchiveLocation))
            {
                QueryBuilder.AddClause(ref query, ref clauseStatus);
                query += "ArchiveLocation LIKE @ArchiveLocation";
                clauseStatus = ClauseStatus.ClauseAdded;
            }

            if (!string.IsNullOrEmpty(crit.FullText))
            {
                QueryBuilder.AddClause(ref query, ref clauseStatus);
                query += "(" + Environment.NewLine;
                query += "FullText LIKE @FullText";
                clauseStatus = ClauseStatus.ClauseAdded;
                QueryBuilder.AddClause(ref query, ref clauseStatus, true);
                query += "FullText LIKE @FullText21";
                QueryBuilder.AddClause(ref query, ref clauseStatus, true);
                query += "FullText LIKE @FullText22";
                QueryBuilder.AddClause(ref query, ref clauseStatus, true);
                query += "FullText LIKE @FullText31";
                QueryBuilder.AddClause(ref query, ref clauseStatus, true);
                query += "FullText LIKE @FullText32";
                QueryBuilder.AddClause(ref query, ref clauseStatus, true);
                query += "FullText LIKE @FullText33";
                QueryBuilder.AddClause(ref query, ref clauseStatus, true);
                query += "FullText LIKE @FullText34";
                QueryBuilder.AddClause(ref query, ref clauseStatus, true);
                query += "FullText LIKE @FullText35";
                QueryBuilder.AddClause(ref query, ref clauseStatus, true);
                query += "FullText LIKE @FullText36";
                query += Environment.NewLine;
                query += ")";
            }

            return query;
        }

        private string GetOrderPart(string query)
        {
            query += Environment.NewLine + "ORDER BY IncomingRegisters.RegisterId" + Environment.NewLine;

            return query;
        }

        private void BuildWhereClause(IncomingBookCriteriaGet crit, string dateTypeName, ref string query,
            ref ClauseStatus clauseStatus)
        {
            if (!crit.CriteriaStartDate.IsEmpty)
            {
                QueryBuilder.AddClause(ref query, ref clauseStatus);
                query += QueryBuilder.NormalizeToDate("IncomingRegisters.", dateTypeName) + " >= @CriteriaStartDate";
                clauseStatus = ClauseStatus.ClauseAdded;
            }

            if (!crit.CriteriaEndDate.IsEmpty)
            {
                QueryBuilder.AddClause(ref query, ref clauseStatus);
                query += QueryBuilder.NormalizeToDate("IncomingRegisters.", dateTypeName) + " <= @CriteriaEndDate";
                clauseStatus = ClauseStatus.ClauseAdded;
            }
        }

        #endregion

        #region Implementation of DataPortal Hooks

        partial void OnFetchPre(DataPortalHookArgs args)
        {
            var cmd = args.CommandArg as SqlCommand;
            var crit = args.CriteriaArg as IncomingBookCriteriaGet;
            if (cmd != null && crit != null)
            {
                if (!string.IsNullOrEmpty(crit.FullText))
                {
                    var fullText = crit.FullText;
                    var fullText21 = string.Empty;
                    var fullText22 = string.Empty;
                    var fullText31 = string.Empty;
                    var fullText32 = string.Empty;
                    var fullText33 = string.Empty;
                    var fullText34 = string.Empty;
                    var fullText35 = string.Empty;
                    var fullText36 = string.Empty;

                    var words = fullText.Split(' ');
                    if (words.Length == 2)
                    {
                        fullText21 = "%" + words[0] + "%" + words[1] + "%";
                        fullText22 = "%" + words[1] + "%" + words[0] + "%";
                    }
                    else if (words.Length == 3)
                    {
                        fullText31 = "%" + words[0] + "%" + words[1] + "%" + words[2] + "%";
                        fullText32 = "%" + words[0] + "%" + words[2] + "%" + words[1] + "%";
                        fullText33 = "%" + words[1] + "%" + words[0] + "%" + words[2] + "%";
                        fullText34 = "%" + words[1] + "%" + words[2] + "%" + words[0] + "%";
                        fullText35 = "%" + words[2] + "%" + words[0] + "%" + words[1] + "%";
                        fullText36 = "%" + words[2] + "%" + words[1] + "%" + words[0] + "%";
                    }

                    cmd.Parameters.AddWithValue("@FullText21", fullText21).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@FullText22", fullText22).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@FullText31", fullText31).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@FullText32", fullText32).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@FullText33", fullText33).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@FullText34", fullText34).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@FullText35", fullText35).DbType = DbType.String;
                    cmd.Parameters.AddWithValue("@FullText36", fullText36).DbType = DbType.String;
                }
            }
        }

        //partial void OnFetchPost(DataPortalHookArgs args)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

    }

    #region Criteria Object

    public partial class IncomingBookCriteriaGet
    {
    }

    #endregion

}
