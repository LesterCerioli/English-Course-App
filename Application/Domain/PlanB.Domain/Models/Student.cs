using System.Reflection.Metadata;
namespace PlanB.Domain.Models
{
    public class Student : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
                
        public string LastName { get; set; }
        public DateTime BornDate { get; set; }
        public int SubscriptionId {get; set; }
        public virtual SubscriptionModel Subscription {get; set; }
        
    }
}