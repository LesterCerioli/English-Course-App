using System;
using NetDevPack.Domain;

namespace PlanB.Domain.Models
{
    public class Payer : Entity, IAggregateRoot
    {
        public Payer(Guid id, string firstName, string middleName, string lastName, CPF cPF)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            CPF = cPF;
        }

        protected Payer() { }
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public virtual CPF CPF { get; private set; }
        
        
        
        
        
        
        
        
    }
}