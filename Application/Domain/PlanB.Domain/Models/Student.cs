using System;
using System.Reflection.Metadata;
namespace PlanB.Domain.Models
{
    public class Student : Entity
    {
        
        public string Name { get; set; }
        public string MiddleName { get; set; }
                
        public string LastName { get; set; }
        public DateTime BornDate { get; set; }
        public int SubscriptionId {get; set; }
        public virtual Subscription Subscription {get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}