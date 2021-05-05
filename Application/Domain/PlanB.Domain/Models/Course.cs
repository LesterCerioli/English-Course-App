namespace PlanB.Domain.Models
{
    public class Course : Entity
    {
        
        public bool Active {get; set;}
        public bool Basic {get; set;}
        public bool Intermedium {get; set;}
        public bool Advanced {get; set;}

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}