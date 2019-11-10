using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Jerrycurl.Mvc;
using Jerrystore.Views.Customers;

namespace Jerrystore.Accessors
{
    public class CustomersAccessor : Accessor
    {
        public IList<CustomerDatabaseView> GetDatabase() => this.Query<CustomerDatabaseView>();
    }
}