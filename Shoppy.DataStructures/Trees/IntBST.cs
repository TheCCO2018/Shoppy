using System;
using System.Collections.Generic;
using System.Text;
using Shoppy.Marketing.Entities;

namespace Shoppy.DataStructures.Trees
{
    public class IntBST : BinarySearchTree
    {
        public IntBST() : base()
        {

        }
        public IntBST(BinarySearchTreeNode Node) : base(Node)
        {

        }
        public BinarySearchTreeNode MinPrice()
        {
            BinarySearchTreeNode tempLeft = Root;
            while(tempLeft.Left != null)
            {
                tempLeft = tempLeft.Left;
            }
            return tempLeft;
        }
        public BinarySearchTreeNode MaxPrice()
        {
            BinarySearchTreeNode tempRight = Root;
            while(tempRight.Right != null)
            {
                tempRight = tempRight.Right;
            }
            return tempRight;
        }
        public override void Add(Product product)
        {
            if (Root == null)
            {
                Root = new IntBinarySearchTreeNode(product); ;
            }
            this.Root.InsertNode(product);
            if(Root.Balance < -1 || Root.Balance > 1)
            {
                BinarySearchTreeNode fakeParent = new IntBinarySearchTreeNode { Left = Root };
                Balancer.ReBalance(fakeParent, Root);
                Root = fakeParent.Left;
            }

        }

        public override bool Delete(Product product)
        {
            BinarySearchTreeNode current = Root;
            BinarySearchTreeNode parent = Root;
            bool isLeft = true;

            while ((decimal)current.Products[0].SalePrice != product.SalePrice)
            {
                parent = current;
                if (product.SalePrice < (decimal)current.Products[0].SalePrice)
                {
                    isLeft = true;
                    current = current.Left;
                }
                else
                {
                    isLeft = false;
                    current = current.Right;
                }
                if (current == null)
                    return false;
            }
            // If deleted node has no child
            if (current.Left == null && current.Right == null)
            {
                if (current == Root)
                    Root = null;
                else if (isLeft)
                    parent.Left = null;
                else
                    parent.Right = null;
            }
            //If deleted node has one child
            else if (current.Right == null)
            {
                if (current == Root)
                    Root = current.Left;
                else if (isLeft)
                    parent.Left = current.Left;
                else
                    parent.Right = current.Left;
            }
            else if (current.Left == null)
            {
                if (current == Root)
                    Root = current.Right;
                else if (isLeft)
                    parent.Left = current.Right;
                else
                    parent.Right = current.Right;
            }
            //If deleted node has two children
            else
            {
                BinarySearchTreeNode successor = Successor(current);
                if (current == Root)
                    Root = successor;
                else if (isLeft)
                    parent.Left = successor;
                else
                    parent.Right = successor;
                successor.Left = current.Left;
            }
            return true;
        }
    }
}
