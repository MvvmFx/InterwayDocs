using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace ResourceMigration
{
    public class Migrator
    {
        public Migrator()
        {
            ShowResourcesByLanguage();
        }

        private void ShowResourcesByLanguage()
        {
            List<AssemblyName> assemblyNames = ResxReader.GetAssemblyNamesStartingBy("InterwayDocs"); ;
            Dictionary<AssemblyName, List<string>> assemblyResourceTypes =
                ResxReader.GetResourceTypesForStrings(assemblyNames);

            foreach (KeyValuePair<AssemblyName, List<string>> assemblyResourceType in assemblyResourceTypes)
            {
                foreach (string value in assemblyResourceType.Value)
                {
                    System.Diagnostics.Debug.WriteLine(
                        $"Assembly {assemblyResourceType.Key.Name} - ResourceType {value}");

                    ResxReader resxReader = new ResxReader(Assembly.Load(assemblyResourceType.Key), value);
                    List<CultureInfo> cultureInfos = resxReader.GetCultureInfos();
                    Dictionary<CultureInfo, Dictionary<string, string>> resources =
                        resxReader.GetResourcesByLanguage(cultureInfos);

                    foreach (KeyValuePair<CultureInfo, Dictionary<string, string>> resource in resources)
                    {
                        foreach (KeyValuePair<string, string> stringResource in resource.Value)
                        {
                            System.Diagnostics.Debug.WriteLine(
                                $"CultureInfo {resource.Key.Name} - ResourceName {stringResource.Key} - Translation {stringResource.Value}");
                        }
                    }
                }

                System.Diagnostics.Debug.WriteLine(string.Empty);
            }
        }

    }
}