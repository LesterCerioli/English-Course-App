using NetDevPack.Domain;
using System;
using System.Reflection.Metadata;
namespace PlanB.Domain.Models
{
    public class Student : Entity, IAggregateRoot
    {
        public Student(Guid id, string name, string middleName, string lastName, DateTime bornDate, int subscriptionId, Subscription subscription)
        {
            Id = id;
            Name = name;
            MiddleName = middleName;
            LastName = lastName;
            BornDate = bornDate;
            SubscriptionId = subscriptionId;
            Subscription = subscription;
        }

        protected Student() { }
        public string Name { get; set; }
        public string MiddleName { get; set; }
                
        public string LastName { get; set; }
        public DateTime BornDate { get; set; }
        public int SubscriptionId {get; set; }
        public virtual Subscription Subscription {get; set; }

        
    }
}