﻿using PlanB.Infrastructure.Data;
using PlanB.Module.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanB.Module.Core.Services
{
    public class WidgetInstanceService : IWidgetInstanceService
    {
        private IRepository<WidgetInstance> _widgetInstanceRepository;

        public WidgetInstanceService(IRepository<WidgetInstance> widgetInstanceRepository)
        {
            _widgetInstanceRepository = widgetInstanceRepository;
        }

        public IQueryable<WidgetInstance> GetPublished()
        {
            var now = DateTimeOffset.Now;
            return _widgetInstanceRepository.Query().Where(x =>
                x.PublishStart.HasValue && x.PublishStart < now
                && (!x.PublishEnd.HasValue || x.PublishEnd > now));
        }
    }
}
