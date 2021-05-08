using System;
using NetDevPack.Messaging;
using PlanB.Domain.Models;

namespace PlanB.Domain.Commands.Subscription
{
    public abstract class SubscriptionCommand : Command
    {
        public Guid Id { get; protected set; }
        public DateTime CreateDate { get; protected set; }
        public DateTime LastUpdateDate { get; protected set; }
        public DateTime? ExpireDate { get; protected set; }
        public bool Active { get; protected set; }
        public string SubNumber { get; protected set; }
        public virtual Payer Payer { get; protected set; }
        
        
        
    }
}