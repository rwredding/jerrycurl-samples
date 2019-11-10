using Jerrystore.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jerrystore.Views.Customers
{
    public class CustomerDatabaseView : Customer
    {
        public IList<OrderView> Orders { get; set; }
        public CustomerAddress Address { get; set; }

        public class OrderView : Order
        {
            public IList<OrderLineView> Lines { get; set; }
            public CustomerAddress Billing { get; set; }
        }

        public class OrderLineView : OrderLine
        {
            public Product Product { get; set; }
        }
    }
}
