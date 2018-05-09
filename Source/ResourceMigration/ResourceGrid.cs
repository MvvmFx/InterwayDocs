using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ResourceMigration
{
    public class ResourceGrid : List<ResourceRow>
    {
        public ResourceRow GetResourceRow(string assembly, string resourceType, string resourceName)
        {
            foreach (ResourceRow resourceRow in this)
            {
                if (resourceRow.Assembly == assembly &&
                    resourceRow.ResourceType == resourceType &&
                    resourceRow.ResourceName == resourceName)
                    return resourceRow;
            }

            var row = new ResourceRow
            {
                Assembly = assembly,
                ResourceType = resourceType,
                ResourceName = resourceName
            };
            Add(row);

            return row;
        }

        public void Save()
        {
            DataAccess_Save();
        }

        internal static string DatabaseConnection
        {
            get { return ConfigurationManager.ConnectionStrings["InterwayDocs"].ConnectionString; }
        }

        private void DataAccess_Save()
        {
            using (var cn = new SqlConnection(DatabaseConnection))
            {
                cn.Open();

                foreach (ResourceRow resourceRow in this)
                {
                    int resourceId = DataAcess_SaveResource(cn, resourceRow);

                    foreach (KeyValuePair<string, string> keyValuePair in resourceRow.Cultures)
                    {
                        DataAcess_SaveResourceTranslation(cn, resourceId, keyValuePair.Key, keyValuePair.Value);
                    }
                }
            }
        }

        private int DataAcess_SaveResource(SqlConnection cn, ResourceRow resourceRow)
        {
            int resourceId = 0;
            using (var cmd = new SqlCommand("dbo.MigrationAddResource", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ResourceId", resourceId).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@ResourceType", resourceRow.Assembly).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@ResourceName", resourceRow.ResourceName).DbType = DbType.String;

                cmd.ExecuteNonQuery();

                resourceId = (int) cmd.Parameters["@ResourceId"].Value;
            }

            return resourceId;
        }

        private void DataAcess_SaveResourceTranslation(SqlConnection cn, int resourceId, string uiCulture,
            string translation)
        {
            using (var cmd = new SqlCommand("dbo.MigrationAddResourceTranslation", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ResourceId", resourceId).DbType = DbType.Int32;
                cmd.Parameters.AddWithValue("@UICulture", uiCulture).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@Translation", translation).DbType = DbType.String;

                cmd.ExecuteNonQuery();
            }
        }
    }
}