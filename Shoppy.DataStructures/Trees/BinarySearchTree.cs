using Shoppy.Marketing.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shoppy.DataStructures.Trees
{
    public abstract class BinarySearchTree
    {
        protected BinarySearchTreeNode Root { get; set; }
        protected List<Product> Products;
        public BinarySearchTree()
        {
            Products = new List<Product>();
        }
        public BinarySearchTree(BinarySearchTreeNode Node)
        {
            Products = new List<Product>();
            this.Root = Node;
        }
        public int NumberOfNodes()
        {
            return NumberOfNodes(Root);
        }
        private int NumberOfNodes(BinarySearchTreeNode Node)
        {
            int count = 0;
            if (Node != null)
            {
                count = 1;
                count += NumberOfNodes(Node.Left);
                count += NumberOfNodes(Node.Right);
            }
            return count;
        }
        public int NumberOfLeaves()
        {
            return NumberOfLeaves(Root);
        }
        private int NumberOfLeaves(BinarySearchTreeNode Node)
        {
            int count = 0;
            if (Node != null)
            {
                if ((Node.Left == null) && (Node.Right == null))
                {
                    count = 1;
                }
                else
                {
                    count = count + NumberOfLeaves(Node.Left) + NumberOfLeaves(Node.Right);
                }
            }
            return count;
        }
        public List<Product> GetProducts()
        {
            return Products;
        }
        public void PreOrder()
        {
            Products.Clear();
            PreOrder(Root);
        }
        private void PreOrder(BinarySearchTreeNode Node)
        {
            if(Node == null)
            {
                return;
            }
            else
            {
                Visitation(Node);
                PreOrder(Node.Left);
                PreOrder(Node.Right);
            }
        }
        public void InOrder()
        {
            Products.Clear();
            InOrder(Root);
        }
        private void InOrder(BinarySearchTreeNode Node)
        {
            if (Node == null)
            {
                return;
            }
            else
            {
                InOrder(Node.Left);
                Visitation(Node);
                InOrder(Node.Right);
            }
        }
        public void PostOrder()
        {
            Products.Clear();
            PostOrder(Root);
        }
        private void PostOrder(BinarySearchTreeNode Node)
        {
            if (Node == null)
            {
                return;
            }
            else
            {
                PostOrder(Node.Left);
                PostOrder(Node.Right);
                Visitation(Node);
            }
        }

        private void Visitation(BinarySearchTreeNode Node)
        {
            Products.AddRange(Node.Products);
        }
        protected BinarySearchTreeNode Successor(BinarySearchTreeNode deletedNode)
        {
            BinarySearchTreeNode successorParent = deletedNode;
            BinarySearchTreeNode successor = deletedNode;
            BinarySearchTreeNode current = deletedNode.Right;
            while(current != null)
            {
                //swapping
                successorParent = successor;
                successor = current;
                //iterating the loop
                current = current.Left;
            }
            if(successor != deletedNode.Right)
            {
                successorParent.Left = successor.Right;
                successor.Right = deletedNode.Right;
            }
            return successor;
        }
        // To-Do make it specific
        public abstract void Add(Product product);
        public abstract bool Delete(Product product);



    }
}
