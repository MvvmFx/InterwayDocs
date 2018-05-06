using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;

namespace ResourceMigration
{
    public class ResxReader
    {
        #region private fields

        private readonly Assembly _assembly;

        private readonly ResourceManager _resourceManager;

        private readonly List<CultureInfo> _cultureInfos;

        #endregion

        #region Constructors

        private ResxReader()
        {
            // force to use parametrized constructor
        }

        public ResxReader(string resourceType)
        {
            _assembly = Assembly.GetExecutingAssembly();
            _resourceManager = new ResourceManager(VerifyResourceTypeExists(resourceType), _assembly);
            _cultureInfos = GetCultureInfos();
        }

        public ResxReader(string resourceType, List<CultureInfo> cultureInfos)
        {
            _assembly = Assembly.GetExecutingAssembly();
            _resourceManager = new ResourceManager(VerifyResourceTypeExists(resourceType), _assembly);
            _cultureInfos = cultureInfos;
        }

        public ResxReader(Assembly assembly, string resourceType)
        {
            _assembly = assembly;
            _resourceManager = new ResourceManager(VerifyResourceTypeExists(resourceType), _assembly);
            _cultureInfos = GetCultureInfos();
        }

        public ResxReader(Assembly assembly, string resourceType, List<CultureInfo> cultureInfos)
        {
            _assembly = assembly;
            _resourceManager = new ResourceManager(VerifyResourceTypeExists(resourceType), _assembly);
            _cultureInfos = cultureInfos;
        }

        #endregion

        #region Static Get AssemblyNames

        public static List<AssemblyName> GetAssemblyNamesStartingBy(string startString, bool includeEntry = true)
        {
            List<AssemblyName> assemblies = new List<AssemblyName>();

            List<AssemblyName> referencedAssemblies = ReferencedAssemblies(includeEntry);

            foreach (AssemblyName assemblyName in referencedAssemblies)
            {
                if (assemblyName.Name.StartsWith(startString))
                    assemblies.Add(assemblyName);
            }

            return assemblies;
        }

        public static List<AssemblyName> GetAssemblyNamesIncluding(string startString, bool includeEntry = true)
        {
            List<AssemblyName> assemblies = new List<AssemblyName>();

            List<AssemblyName> referencedAssemblies = ReferencedAssemblies(includeEntry);

            foreach (AssemblyName assemblyName in referencedAssemblies)
            {
                if (assemblyName.Name.IndexOf(startString, 0, StringComparison.InvariantCulture) != -1)
                    assemblies.Add(assemblyName);
            }

            return assemblies;
        }

        private static List<AssemblyName> ReferencedAssemblies(bool includeEntry)
        {
            Assembly entryAssembly = Assembly.GetEntryAssembly();

            List<AssemblyName> referencedAssemblies = entryAssembly.GetReferencedAssemblies().ToList();

            if (includeEntry)
                referencedAssemblies.Add(entryAssembly.GetName());

            return referencedAssemblies;
        }

        #endregion

        #region Resource Types

        private string VerifyResourceTypeExists(string resourceType)
        {
            if (!ResourceTypeExists(resourceType))
                throw new ArgumentOutOfRangeException("resourceType",
                    $"Resource type {resourceType} not foun on assembly {_assembly}");

            return resourceType;
        }

        public bool ResourceTypeExists(string resourceType)
        {
            string[] resourceNames = _assembly.GetManifestResourceNames();
            return resourceNames.Any(name => name.Substring(0, name.LastIndexOf('.')) == resourceType);
        }

        #endregion

        #region Static Get ResourceTypes

        public static List<string> GetAllResourceTypes()
        {
            return GetAllResourceTypes(Assembly.GetExecutingAssembly());
        }

        public static List<string> GetAllResourceTypes(Assembly assembly)
        {
            string[] resourceTypeNames = assembly.GetManifestResourceNames();

            return resourceTypeNames.Select(name => new {name, resourceInfo = assembly.GetManifestResourceInfo(name)})
                .Where(type => type.resourceInfo != null)
                .Select(type => type.name.Substring(0, type.name.LastIndexOf('.'))).ToList();
        }

        public static List<string> GetAllResourceTypes(Type type)
        {
            return GetAllResourceTypes(Assembly.GetExecutingAssembly(), new List<Type> {type});
        }

        public static List<string> GetAllResourceTypes(Assembly assembly, Type type)
        {
            return GetAllResourceTypes(assembly, new List<Type> {type});
        }

        public static List<string> GetAllResourceTypes(Assembly assembly, List<Type> types)
        {
            List<string> resourceTypes = new List<string>();

            List<string> resourceTypeNames = GetAllResourceTypes(assembly);

            foreach (string resourceTypeName in resourceTypeNames)
            {
                ResourceManager resourceManager = new ResourceManager(resourceTypeName, assembly);
                ResourceSet resourceSet = resourceManager.GetResourceSet(CultureInfo.InvariantCulture, true, false);
                IDictionaryEnumerator enumerator = resourceSet.GetEnumerator();

                while (enumerator.MoveNext())
                {
                    if (types.Contains(enumerator.Entry.Value.GetType()))
                    {
                        resourceTypes.Add(resourceTypeName);
                        break;
                    }
                }
            }

            return resourceTypes;
        }

        public static Dictionary<AssemblyName, List<string>> GetResourceTypesForStrings(
            List<AssemblyName> assemblyNames)
        {
            Dictionary<AssemblyName, List<string>> assemblyResourceTypes = new Dictionary<AssemblyName, List<string>>();

            foreach (AssemblyName assemblyName in assemblyNames)
            {
                Assembly assembly = Assembly.Load(assemblyName);
                List<string> resourceTypes = ResxReader.GetAllResourceTypes(assembly, typeof(string));
                if (resourceTypes.Count > 0)
                    assemblyResourceTypes.Add(assemblyName, resourceTypes);
            }

            return assemblyResourceTypes;
        }

        #endregion

        #region Get CultureInfo

        public List<CultureInfo> GetCultureInfos()
        {
            List<CultureInfo> cultureInfos = new List<CultureInfo>();

            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
            foreach (CultureInfo culture in cultures)
            {
                ResourceSet resourceSet = _resourceManager.GetResourceSet(culture, true, false);
                if (resourceSet != null && !string.IsNullOrWhiteSpace(culture.ToString()))
                    cultureInfos.Add(culture);
            }

            return cultureInfos;
        }

        #endregion

        #region Resource Keys

        public List<string> GetResourceKeys()
        {
            return GetResourceKeys(new List<Type>());
        }

        public List<string> GetResourceKeys(Type type)
        {
            return GetResourceKeys(new List<Type> {type});
        }

        public List<string> GetResourceKeys(List<Type> types)
        {
            List<string> resourceKeys = new List<string>();
            ResourceSet resourceSet = _resourceManager.GetResourceSet(CultureInfo.InvariantCulture, true, false);

            IDictionaryEnumerator enumerator = resourceSet.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (types.Contains(enumerator.Entry.Value.GetType()))
                    resourceKeys.Add(enumerator.Entry.Key.ToString());
            }

            return resourceKeys;
        }

        #endregion

        #region Resource Values by language

        public Dictionary<string, string> GetResourcesByLanguage(CultureInfo cultureInfo,
            bool includeMissing = false)
        {
            if (cultureInfo == CultureInfo.InvariantCulture)
                throw new ArgumentOutOfRangeException("cultureInfo", "Can not be InvariantCulture");

            if (includeMissing)
                return GetAllResourcesByLanguage(cultureInfo);

            Dictionary<string, string> resources = new Dictionary<string, string>();
            ResourceSet resourceSet = _resourceManager.GetResourceSet(cultureInfo, true, false);

            IDictionaryEnumerator enumerator = resourceSet.GetEnumerator();

            while (enumerator.MoveNext())
            {
                if (enumerator.Entry.Value is string)
                    resources.Add(enumerator.Entry.Key.ToString(), enumerator.Entry.Value.ToString());
            }

            return resources;
        }

        public Dictionary<string, string> GetAllResourcesByLanguage(CultureInfo cultureInfo, List<string> keys = null)
        {
            if (cultureInfo == CultureInfo.InvariantCulture)
                throw new ArgumentOutOfRangeException("cultureInfo", "Can not be InvariantCulture");

            if (keys == null)
                keys = GetResourceKeys(new List<Type> {typeof(string)});

            Dictionary<string, string> resources = new Dictionary<string, string>();
            ResourceSet resourceSet = _resourceManager.GetResourceSet(cultureInfo, true, false);

            foreach (string key in keys)
            {
                resources.Add(key, resourceSet.GetString(key));
            }

            return resources;
        }

        public Dictionary<CultureInfo, Dictionary<string, string>> GetResourcesByLanguage(
            List<CultureInfo> cultureInfos, bool includeMissing = false)
        {
            if (includeMissing)
                return GetAllResourcesByLanguage(cultureInfos);

            Dictionary<CultureInfo, Dictionary<string, string>> resources =
                new Dictionary<CultureInfo, Dictionary<string, string>>();

            foreach (CultureInfo cultureInfo in cultureInfos)
            {
                Dictionary<string, string> entry = GetResourcesByLanguage(cultureInfo);
                resources.Add(cultureInfo, entry);
            }

            return resources;
        }

        public Dictionary<CultureInfo, Dictionary<string, string>> GetAllResourcesByLanguage(
            List<CultureInfo> cultureInfos)
        {
            Dictionary<CultureInfo, Dictionary<string, string>> resources =
                new Dictionary<CultureInfo, Dictionary<string, string>>();

            List<string> keys = GetResourceKeys(new List<Type> {typeof(string)});

            foreach (CultureInfo cultureInfo in cultureInfos)
            {
                Dictionary<string, string> entry = GetAllResourcesByLanguage(cultureInfo, keys);
                resources.Add(cultureInfo, entry);
            }

            return resources;
        }

        #endregion
    }
}