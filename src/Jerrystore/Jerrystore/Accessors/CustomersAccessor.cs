using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Jerrycurl.Mvc;
using Jerrystore.Models.Customers;
using Jerrystore.Views.Customers;

namespace Jerrystore.Accessors
{
    public class CustomersAccessor : Accessor
    {
        public IList<CustomerDatabaseView> GetDatabase() => this.Query<CustomerDatabaseView>();

        public IList<CustomerStatsView> GetStats(DateTime minAge)
        {
            var filter = new CustomerFilter()
            {
                MinAge = minAge,
            };

            return this.Query<CustomerStatsView>(model: filter);
        }

        public void NewCustomer(NewCustomerModel customer) => this.Execute(customer);
    }
}