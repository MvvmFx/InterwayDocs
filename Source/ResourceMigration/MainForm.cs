using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace ResourceMigration
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void fromResx_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            ReferenceAssemblies.Perform();
            LoadFromResX();
        }

        private void fromDatabase_Click(object sender, EventArgs e)
        {
        }

        private void toDatabase_Click(object sender, EventArgs e)
        {
        }


        private void LoadFromResX()
        {
            ResourceGrid resourceGrid = new ResourceGrid();

            List<AssemblyName> assemblyNames = ResxReader.GetAssemblyNamesStartingBy("InterwayDocs");

            Dictionary<AssemblyName, List<string>> assemblyResourceTypes =
                ResxReader.GetResourceTypesForStrings(assemblyNames);

            foreach (KeyValuePair<AssemblyName, List<string>> assemblyResourceType in assemblyResourceTypes)
            {
                foreach (string value in assemblyResourceType.Value)
                {
                    //System.Diagnostics.Debug.WriteLine($"Assembly {assemblyResourceType.Key.Name} - ResourceType {value}");

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
                                resourceGrid.GetResourceRow(assemblyResourceType.Key.Name, value, stringResource.Key);

                            resourceRow.Cultures[resource.Key.Name] = stringResource.Value;

                            //System.Diagnostics.Debug.WriteLine($"CultureInfo {resource.Key.Name} - ResourceName {stringResource.Key} - Translation {}");
                        }
                    }
                }

                System.Diagnostics.Debug.WriteLine(string.Empty);
            }

            foreach (ResourceRow resourceRow in resourceGrid)
            {
                string[] row = new string[7];
                row[0] = resourceRow.Assembly;
                row[1] = resourceRow.ResourceType;
                row[2] = resourceRow.ResourceName;

                if (resourceRow.Cultures.ContainsKey("en-GB"))
                    row[3] = resourceRow.Cultures["en-GB"];
                if (resourceRow.Cultures.ContainsKey("es"))
                    row[4] = resourceRow.Cultures["es"];
                if (resourceRow.Cultures.ContainsKey("fr"))
                    row[5] = resourceRow.Cultures["fr"];
                if (resourceRow.Cultures.ContainsKey("pt"))
                    row[6] = resourceRow.Cultures["pt"];

                dataGridView.Rows.Add(row);
            }

            totalRows.Text = dataGridView.RowCount.ToString();
        }
    }
}