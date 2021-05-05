namespace PlanB.Domain.Models
{
    public class Subscription : Entity
    {
        
        public string SubNumber { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}