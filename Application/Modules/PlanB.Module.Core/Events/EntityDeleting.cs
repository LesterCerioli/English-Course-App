using MediatR;

namespace PlanB.Module.Core.Events
{
    public class EntityDeleting : INotification
    {
        public long EntityId {get; set;}
        
    }
}