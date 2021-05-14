using MediatR;

namespace PlanB.Module.Core.Events
{
    public class ReviewSummaryChanges : INotification
    {
        public long EntityId {get; set;}
        public string EntityTypeId {get; set;}
        public int ReviewsCount { get; set; }

        public double? RatingAverage { get; set; }
        
    }
}