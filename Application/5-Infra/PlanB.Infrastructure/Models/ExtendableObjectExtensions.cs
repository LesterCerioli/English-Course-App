
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace PlanB.Infrastructure.Models
{
    public class ExtendableObjectExtensions
    {
        public static T GetData<T>(this IExtendableObject extendableObject, string name, bool handleType = false)
        {
            CheckNotNull(extendableObject, name);
            if (extendableObject ==null)
            {
                throw new ArgumentNullException(nameof(extendableObject));
            }

            if (name ==null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return extendableObject.GetData<T>(
                name,
                handleType
                    ? new JsonSerializer { TypeNameHandling = TypeNameHandling.All}
                    : JsonSerializer.CreateDefault()

            );

        }

        public static T GetData<T>(this IExtendableObject extendableObject, string name, JsonSerializer jsonSerializer)
        {
            CheckNotNull(extendableObject, name);
            if (extendableObject.ExtensionData == null)
            {
                return default(T);
            }

            var json = JsonObjectAttribute.Parse(extendableObject.ExtensionData);
            var prop = json[name];

            if (prop ==null)
            {
                return default(T);
            }

        }

        private static void CheckNotNull(IExtendableObject extendableObject, string name)
        {
            throw new NotImplementedException();
        }
    }
}
