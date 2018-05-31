using System;
using System.Collections.Generic;
using System.Text;

namespace Shoppy.Marketing.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string TradeMark { get; set; }
        public string Model { get; set; }
        public string PicturePath { get; set; }
        public decimal Cost { get; set; }
        public decimal SalePrice { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }

        public Product()
        {
            Comments = new List<Comment>();
        }

        public int Overall()
        {
            int avg=0;
            foreach (var comment in Comments)
            {
                avg += comment.Star;
            }
            if(Comments.Count != 0)
            {
                return avg / Comments.Count;
            }
            return avg;
        }
    }
}
