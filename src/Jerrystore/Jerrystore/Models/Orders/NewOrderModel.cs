using Jerrystore.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jerrystore.Models.Orders
{
    public class NewOrderModel
    {
        public int CustomerId { get; set; }
        public IList<OrderItem> Items { get; set; }

        public class OrderItem
        {
            public int ProductId { get; set; }
            public int Units { get; set; }
        }
    }
}