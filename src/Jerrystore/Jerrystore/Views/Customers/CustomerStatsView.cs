using System;
using System.Collections.Generic;
using System.Text;

namespace Jerrystore.Views.Customers
{
    public class CustomerStatsView
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public decimal NumberOfOrders { get; set; }
    }
}
