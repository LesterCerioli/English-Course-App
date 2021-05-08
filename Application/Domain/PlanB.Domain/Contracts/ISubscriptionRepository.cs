using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetDevPack.Data;
using PlanB.Domain.Models;

namespace PlanB.Domain.Contracts
{
    public interface ISubscriptionRepository : IRepository<Subscription>
    {
        Task<Subscription> GetById(Guid id);
        Task<IEnumerable<Subscription>> GetAll();
        Task<Subscription> GetBySubNumber(string subNumber);

        void Add(Subscription subscription);
        void Update(Subscription subscription) ;
        void Remove(Subscription subscription);
            
        
        
        
         
    }
}