using System;

namespace PlanB.MicroService.Subscription.Models
{
    public class Subscription
    {

        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool Active { get; private set; }
        public long SubNumber {get; private set;}
        //public IReadOnlyCollection<Payment> Payments { get { return _payments.ToArray(); } }
        
    }
}