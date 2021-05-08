using System;
using NetDevPack.Domain;

namespace PlanB.Domain.Models
{
    public class Course : Entity, IAggregateRoot
    {
        public Course(Guid id, bool active, bool basic, bool intermedium, bool advanced)
        {
            Id = id;
            Active = active;
            Basic = basic;
            Intermedium = intermedium;
            Advanced = advanced;
        }

        protected Course() { }
        public bool Active {get; private set;}
        public bool Basic {get; private set;}
        public bool Intermedium {get; private set;}
        public bool Advanced {get; private set;}

        
    }
}