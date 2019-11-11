using System;
using System.Collections.Generic;
using System.Text;

namespace Jerrystore.Models.Products
{
    public class ProductChangePriceModel
    {
        public int ProductId { get; set; }
        public decimal NewPrice { get; set; }
    }
}
