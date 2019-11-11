using Jerrystore.Accessors;
using Jerrystore.Models.Customers;
using Jerrystore.Models.Orders;
using System;
using System.Collections.Generic;

namespace Jerrystore.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var cust = new CustomersAccessor();
            var ord = new OrdersAccessor();

            var db = cust.GetDatabase();

            NewCustomerModel newCustomer = new NewCustomerModel()
            {
                Email = "larry@jerrycurl.net",
                Password = "s€cure",
                Name = "Larry The Janitor",
                Street = "2720 36th Ave",
                City = "San Francisco",
                Country = "USA",
                NewOrder = new NewOrderModel()
                {
                    Items = new List<NewOrderModel.OrderItem>()
                    {
                        new NewOrderModel.OrderItem() { ProductId = 1, Units = 12 },
                        new NewOrderModel.OrderItem() { ProductId = 1, Units = 3 },
                        new NewOrderModel.OrderItem() { ProductId = 1, Units = 11 },
                        new NewOrderModel.OrderItem() { ProductId = 1, Units = 66 },
                        new NewOrderModel.OrderItem() { ProductId = 1, Units = 1 },
                        new NewOrderModel.OrderItem() { ProductId = 1, Units = 13 },
                    }
                }
            };

            cust.NewCustomer(newCustomer);

            var stats = cust.GetStats(DateTime.UtcNow.AddDays(-100));
        }
    }
}
