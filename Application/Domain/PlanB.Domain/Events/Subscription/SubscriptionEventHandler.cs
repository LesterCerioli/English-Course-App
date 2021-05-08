using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace PlanB.Domain.Events.Subscription
{
    public class SubscriptionEventHandler :
        INotificationHandler<SubscriptionRegisteredEvent>,
        INotificationHandler<SubscriptionUpdatedEvent>,
        INotificationHandler<SubscriptionRemovedEvent>
    {
        public Task Handle(SubscriptionUpdatedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(SubscriptionRegisteredEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(SubscriptionRemovedEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}