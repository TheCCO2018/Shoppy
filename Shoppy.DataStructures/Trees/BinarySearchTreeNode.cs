using Shoppy.Marketing.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shoppy.DataStructures.Trees
{
    public abstract class BinarySearchTreeNode
    {
        public List<Product> Products { get; set; }
        public BinarySearchTreeNode Left { get; set; }
        public BinarySearchTreeNode Right { get; set; }
        public int Balance { get; set; }
        public BinarySearchTreeNode()
        {
            Balance = 0;
            Products = new List<Product>();
            Left = null;
            Right = null;
        }
        public BinarySearchTreeNode(Product product)
        {
            Balance = 0;
            Products = new List<Product>
            {
                product
            };
            Left = null;
            Right = null;

        }
        public void AddItem(Product product)
        {
            Products.Add(product);
        }
        public abstract bool InsertNode(Product product);

    }
}
