using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanB.Module.Core.Extensions.Settings
{
    public class SettingDefinition
    {
        public string Name { get; private set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string DefaultValue { get; set; }
        public bool IsVisibleToClients { get; set; }
        public Dictionary<string, object> ExtraProperties { get; set; }

        public SettingDefinition(
            string name,
            string defaultValue,
            string displayName = null,
            string description = null,
            bool isVisibleToClients = false)
        {

        }



    }
}
