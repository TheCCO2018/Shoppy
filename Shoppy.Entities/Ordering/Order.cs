using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Shoppy.Authentication.Entities;

namespace Shoppy.Ordering.Entities
{
    public class Order
    {
        public int? OrderID { get; set; }
        public int? CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderState { get; set; }   
        [NotMapped]
        public ShoppingCart Cart { get; set; }
        public Customer Customer { get; set; }

        public Order()
        {
            this.OrderDate = DateTime.Now;
            this.OrderState = OrderStatus.Open;
            Cart = new ShoppingCart();
        }
        public enum OrderStatus
        {
            Open,
            Hold,
            Shipped,
            Delivered,
            Closed
        }
    }

}
