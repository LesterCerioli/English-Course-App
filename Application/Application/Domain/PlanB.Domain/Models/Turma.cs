using System;
namespace PlanB.Domain.Models
{
    public class Turma
    {
        public string Name {get; set;}
        public int StudentId {get; set;}
        public virtual Student Student {get; set;}
        public DateTime DataInicio {get; set;}
    }
}