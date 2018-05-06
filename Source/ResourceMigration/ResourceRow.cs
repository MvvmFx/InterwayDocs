using System.Collections.Generic;

namespace ResourceMigration
{
    public class ResourceRow
    {
        public string Assembly { get; set; }
        public string ResourceType { get; set; }
        public string ResourceName { get; set; }
        public Dictionary<string, string> Cultures { get; set; }

        public ResourceRow()
        {
            Cultures = new Dictionary<string, string>();
        }
    }
}
