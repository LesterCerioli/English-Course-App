namespace PlanB.Domain.Models
{
    public class Course : Entity
    {
        public int Id {get; set;}
        public bool Active {get; set;}
        public bool Basic {get; set;}
        public bool Intermedium {get; set;}
        public bool Advanced {get; set;}
        
    }
}