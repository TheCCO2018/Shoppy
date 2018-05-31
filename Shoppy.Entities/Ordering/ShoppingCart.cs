using Shoppy.Marketing.Entities;
using System;
using System.Collections.Generic;

namespace Shoppy.Ordering.Entities
{
    public class ShoppingCart
    {
        public DateTime CartDate { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public List<LineItem> LineItems;
        public Order Order { get; set; }

        public ShoppingCart()
        {
            this.CartDate = DateTime.Now;
            this.LineItems = new List<LineItem>();
        }
        public void AddItem(LineItem Item)
        {
            LineItems.Add(Item);
        }
        public decimal CartTotal()
        {
            decimal total = 0;
            if (LineItems != null)
            {
                foreach (var Item in LineItems)
                {
                    total += Item.Price;
                }
            }
            return total;
        }
    }
}
