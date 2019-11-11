using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Jerrycurl.Mvc;
using Jerrystore.Models.Orders;
using Jerrystore.Views.Customers;

namespace Jerrystore.Accessors
{
    public class OrdersAccessor : Accessor
    {
        public void NewOrder(NewOrderModel order) => this.Execute(model: order);
    }
}