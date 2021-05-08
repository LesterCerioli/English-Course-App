using System;
using NetDevPack.Messaging;
using PlanB.Domain.Models;

namespace PlanB.Domain.Events.Subscription
{
    public class SubscriptionRegisteredEvent : Event
    {
        public SubscriptionRegisteredEvent(Guid id, DateTime createDate, DateTime lastUpdateDate, DateTime? expireDate, bool active, string subNumber, Payer payer)
        {
            Id = id;
            CreateDate = createDate;
            LastUpdateDate = lastUpdateDate;
            ExpireDate = expireDate;
            Active = active;
            SubNumber = subNumber;
            Payer = payer;
            AggregateId = id;
        }

        public Guid Id { get; private set; }
        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdateDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool Active { get; private set; }
        public string SubNumber { get; private set; }
        public virtual Payer Payer { get; private set; }
        
        
        
    }
}