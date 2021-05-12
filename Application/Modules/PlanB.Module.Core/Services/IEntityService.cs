using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanB.Module.Core.Services
{
    public interface IEntityService
    {
        string ToSafeSlug(string slug, long entityId, string entityTypeId);
        IEntityService Get(long entityId, string entityTypeId);
        void Add(string name, string slug, long entityId, string entityTypeid);
        void Update(string newname, string newSlug, long entityid, string entityTypeid);
        Task Remove(long entityId, string entityTypeId);
    }
}
