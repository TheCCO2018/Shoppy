using System;
using System.Collections.Generic;
using System.Text;

namespace Shoppy.Entities.Ordering
{
    public class OrderDetail
    {
        public int? OrderID { get; set; }
        public int? OrderDetailID { get; set; }
        public decimal Profit { get; set; }
        public decimal Loss { get; set; }

        public OrderDetail()
        {
            Profit = 0;
            Loss = 0;
        }
    }
}
