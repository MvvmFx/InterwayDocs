using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

// ReSharper disable UseNameofExpression

namespace Codisa.InterwayDocs.Business.Update
{
    /// <summary>
    /// UpdateSchema Command.<br/>
    /// </summary>
    [Serializable]
    public class BatchCommand : CommandBase<BatchCommand>
    {
        #region Fields

        private string _batchQuery = string.Empty;

        #endregion

        #region Factory Methods

        /// <summary>
        /// Runs a SQL batch.
        /// </summary>
        /// <param name="batchQuery">The batch query to run.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">batchQuery</exception>
        public static BatchCommand RunBatch(string batchQuery)
        {
            if (string.IsNullOrEmpty(batchQuery))
                throw new ArgumentNullException("batchQuery");

            BatchCommand cmd = new BatchCommand {_batchQuery = batchQuery};
            cmd = DataPortal.Execute(cmd);
            return cmd;
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchCommand"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public BatchCommand()
        {
            // Use factory methods and do not use direct creation.
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Loads a <see cref="BatchCommand"/> object from the database, based on given criteria.
        /// </summary>
        protected override void DataPortal_Execute()
        {
            using (var ctx = ConnectionManager<SqlConnection>.GetManager(Database.InterwayDocsConnection, false))
            {
                using (var cmd = new SqlCommand(_batchQuery, ctx.Connection))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        #endregion
    }
}