using Jerrystore.Models.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jerrystore.Models.Customers
{
    public class NewCustomerModel
    {
        public int? NewCustomerId { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public NewOrderModel NewOrder { get; set; }
    }
}
