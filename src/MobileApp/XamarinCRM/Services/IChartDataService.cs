﻿using XamarinCRM.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Syncfusion.SfChart.XForms;

namespace XamarinCRM.Services
{
    public interface IChartDataService
    {
        Task<List<WeeklySalesDataPoint>> GetWeeklySalesDataPoints(IEnumerable<Order> orders, int numberOfWeeks = 6, bool isOpen = false);

        Task<List<ChartDataPoint>> GetCategorySalesDataPoints(IEnumerable<Order> orders, Account account = null, int numberOfWeeks = 6, bool isOpen = false);
    }
}

