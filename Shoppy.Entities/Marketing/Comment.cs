using System;
using System.Collections.Generic;
using System.Text;

namespace Shoppy.Marketing.Entities
{
    public class Comment
    {
        public int CommentID { get; set; }
        public DateTime createdAt { get; set; }
        public int CustomerID { get; set; }
        public string CommentDescription { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int Star { get; set; }

        private Comment()
        {

        }

        public Comment(int CustomerID, string CommentDescription,Stars Star)
        {
            this.CustomerID = CustomerID;
            this.CommentDescription = CommentDescription;
            this.Star = (int)Star;
            this.createdAt = DateTime.Now;
        }

        public enum Stars
        {
            Zero,
            One,
            Two,
            Three,
            Four,
            Five
        }
    }
}
