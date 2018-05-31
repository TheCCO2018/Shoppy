using System;
using System.Collections.Generic;

namespace Shoppy.Marketing.Entities
{
    public class Market
    {
        public List<Category> Categories { get; set; }
        public string MarketName { get; set; }
        public string MarketBrand { get; set; }

        public Market()
        {
            Categories = new List<Category>();
        }
    }
}
