using System;
using NetDevPack.Domain;

namespace PlanB.Domain.Models
{
    public class Email : Entity, IAggregateRoot
    {
        public Email(Guid id, string emailAddress)
        {
            Id = id;
            EmailAddress = emailAddress;
        }

        protected Email() { }
        public string EmailAddress { get; private set; }
        
        
        
    }
}