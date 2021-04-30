using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanB.Infrastructure.Models
{
    public interface IExtendableObject
    {
        string ExtensionData { get; set; }

        T GetData<T>(string name, object p);
    }
}
