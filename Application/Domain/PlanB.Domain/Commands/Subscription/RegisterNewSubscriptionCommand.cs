using System;
using NetDevPack.Messaging;

namespace PlanB.Domain.Commands.Subscription
{
    public class RegisterNewSubscriptionCommand : Command
    {
        public RegisterNewSubscriptionCommand(DateTime createDate, DateTime lastUpdateDate, DateTime? expireDate, bool active, string subNumber, Payer payer) 
        {
            CreateDate = createDate;
            LastUpdateDate = lastUpdateDate;
            ExpireDate = expireDate;
            Active = active;
            SubNumber = subNumber;
            Payer = payer;
            

        }    
        
        

        
            
        
        
    }
}