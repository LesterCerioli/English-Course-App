﻿using NetDevPack.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanB.Domain.Events.Student
{
    public class StudentRegisteredEvent : Event
    {
        public StudentRegisteredEvent(Guid id, string cPF, string firstName, string lastName)
        {
            Id = id;
            CPF = cPF;
            FirstName = firstName;
            LastName = lastName;
            AggregateId = id;
        }

        public Guid Id { get; set; }
        public string CPF { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}