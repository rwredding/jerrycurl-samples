using System;
using System.Collections.Generic;
using System.Linq;
using Jerrycurl.Mvc;
using Jerrystore.Models.Products;

namespace Jerrystore.Accessors
{
    public class ProductsAccessor : Accessor
    {
        public void ChangePrice(int[] productIds, decimal[] newPrices)
        {
            var model = productIds.Zip(newPrices, (id, np) => new ProductChangePriceModel()
            {
                ProductId = id,
                NewPrice = np,
            });

            this.Execute(model);
        }
    }
}
