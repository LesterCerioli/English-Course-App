using Microsoft.AspNetCore.Identity;
using PlanB.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanB.Module.Core.Models
{
    public class Role : IdentityRole<long>, IEntityWithTypedId<long>
    {
        public IList<UserRole> Users { get; set; } = new List<UserRole>();
    }
}
