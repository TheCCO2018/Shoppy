using System;
using System.Collections.Generic;
using System.Text;

namespace Shoppy.Marketing.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string CategoryDescription { get; set; }
        public string PicturePath { get; set; }

        public List<Product> Products { get; set; }

        public Category()
        {
            Products = new List<Product>();
        }

    }
}
