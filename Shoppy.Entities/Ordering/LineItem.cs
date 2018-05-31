using System;
using System.Collections.Generic;
using System.Text;
using Shoppy.Marketing.Entities;

namespace Shoppy.Ordering.Entities
{
    public class LineItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public LineItem(Product product,int Quantity, decimal Price)
        {
            this.Product = product;
            this.Quantity = Quantity;
            this.Price = Quantity * product.SalePrice;
        }
    }
}
