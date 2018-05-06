using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace ResourceMigration
{
    public partial class MainForm : Form
    {
        private ResourceGrid _resourceGrid;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            totalRows.Text = $"Total rows: n/a";
        }

        private void fromResx_Click(object sender, EventArgs e)
        {
            Editable(false);

            dataGridView.Rows.Clear();
            ReferenceAssemblies.Perform();
            LoadFromResX();

            foreach (ResourceRow resourceRow in _resourceGrid)
            {
                string[] row = new string[7];
                row[0] = resourceRow.Assembly;
                row[1] = resourceRow.ResourceType;
                row[2] = resourceRow.ResourceName;

                if (resourceRow.Cultures.ContainsKey("en-GB"))
                    row[3] = resourceRow.Cultures["en-GB"];

                if (!resourceRow.Cultures.ContainsKey("es"))
                    resourceRow.Cultures["es"] = resourceRow.Cultures["en-GB"];

                row[4] = resourceRow.Cultures["es"];

                if (!resourceRow.Cultures.ContainsKey("fr"))
                    resourceRow.Cultures["fr"] = resourceRow.Cultures["en-GB"];

                row[5] = resourceRow.Cultures["fr"];

                if (!resourceRow.Cultures.ContainsKey("pt"))
                    resourceRow.Cultures["pt"] = resourceRow.Cultures["en-GB"];

                row[6] = resourceRow.Cultures["pt"];

                dataGridView.Rows.Add(row);
            }

            totalRows.Text = $"Total rows: {dataGridView.RowCount.ToString()}";

            Editable(true);
        }

        private void fromDatabase_Click(object sender, EventArgs e)
        {
        }

        private void toDatabase_Click(object sender, EventArgs e)
        {
            Editable(false);

            _resourceGrid.Clear();

            foreach (var line in dataGridView.Rows)
            {
                var row = (DataGridViewRow) line;
                var resourceRow = new ResourceRow
                {
                    Assembly = row.Cells[0].Value.ToString(),
                    ResourceType = row.Cells[1].Value.ToString(),
                    ResourceName = row.Cells[2].Value.ToString()
                };

                resourceRow.Cultures.Add(dataGridView.Columns[3].Name, row.Cells[3].Value.ToString());
                resourceRow.Cultures.Add(dataGridView.Columns[4].Name, row.Cells[4].Value.ToString());
                resourceRow.Cultures.Add(dataGridView.Columns[5].Name, row.Cells[5].Value.ToString());
                resourceRow.Cultures.Add(dataGridView.Columns[6].Name, row.Cells[6].Value.ToString());

                _resourceGrid.Add(resourceRow);
            }

            _resourceGrid.Save();

            Editable(true);

            MessageBox.Show("Resources saved.", "Save eneded");
        }

        private void Editable(bool setEditable)
        {
            dataGridView.ReadOnly = setEditable;
            dataGridView.AllowUserToAddRows = setEditable;
            dataGridView.AllowUserToDeleteRows = setEditable;
        }

        private void LoadFromResX()
        {
            _resourceGrid = new ResourceGrid();

            List<AssemblyName> assemblyNames = ResxReader.GetAssemblyNamesStartingBy("InterwayDocs");

            Dictionary<AssemblyName, List<string>> assemblyResourceTypes =
                ResxReader.GetResourceTypesForStrings(assemblyNames);

            foreach (KeyValuePair<AssemblyName, List<string>> assemblyResourceType in assemblyResourceTypes)
            {
                foreach (string value in assemblyResourceType.Value)
                {
                    ResxReader resxReader =
                        new ResxReader(System.Reflection.Assembly.Load(assemblyResourceType.Key), value);
                    List<CultureInfo> cultureInfos = resxReader.GetCultureInfos();
                    Dictionary<CultureInfo, Dictionary<string, string>> resources =
                        resxReader.GetResourcesByLanguage(cultureInfos);

                    foreach (KeyValuePair<CultureInfo, Dictionary<string, string>> resource in resources)
                    {
                        foreach (KeyValuePair<string, string> stringResource in resource.Value)
                        {
                            ResourceRow resourceRow =
                                _resourceGrid.GetResourceRow(assemblyResourceType.Key.Name, value, stringResource.Key);

                            resourceRow.Cultures[resource.Key.Name] = stringResource.Value;
                        }
                    }
                }
            }
        }
    }
}