using MediatR;

namespace PlanB.Module.Core.Events
{
    public class UserSignedIn : INotification
    {
        public long UserId { get; set; }
        
    }
}