using System;
using System.Collections.Generic;
using System.Text;
using Shoppy.Marketing.Entities;

namespace Shoppy.DataStructures.Trees
{
    public class StringBST : BinarySearchTree
    {
        private string type;

        public StringBST(string type) : base()
        {
            this.type = type;
        }
        public StringBST(BinarySearchTreeNode node, string type) : base(node)
        {
            this.type = type;
        }
        public string GetTreeType()
        {
            return type;
        }
        public override void Add(Product product)
        {
            if (Root == null)
            {
                Root = new StringBinarySearchTreeNode(product,type); ;
            }
            this.Root.InsertNode(product);
            if (Root.Balance < -1 || Root.Balance > 1)
            {
                BinarySearchTreeNode fakeParent = new StringBinarySearchTreeNode(type) { Left = Root };
                Balancer.ReBalance(fakeParent, Root);
                Root = fakeParent.Left;
            }
        }

        public override bool Delete(Product product)
        {
            BinarySearchTreeNode current = Root;
            BinarySearchTreeNode parent = Root;
            bool isLeft = true;

            switch (type)
            {
                case "Name":
                    while (String.Compare(product.Name, current.Products[0].Name, true) != 0)
                    {
                        parent = current;
                        if (String.Compare(product.Name, current.Products[0].Name, true) < 0)
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
                    break;
                case "TradeMark":
                default:
                    while (String.Compare(product.TradeMark, current.Products[0].TradeMark, true) != 0)
                    {
                        parent = current;
                        if (String.Compare(product.TradeMark, current.Products[0].TradeMark, true) < 0)
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
                    break;
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
        public BinarySearchTreeNode Search(string key)
        {
            return SearchString(Root, key);
        }
        private BinarySearchTreeNode SearchString(BinarySearchTreeNode Node,string key)
        {
            if(Node == null)
            {
                return null;
            }
            switch(type)
            {
                case "Name":
                    if (String.Compare(Node.Products[0].Name, key , true) == 0)
                    {
                        return Node;
                    }
                    else if(String.Compare(Node.Products[0].Name, key, true) > 0)
                    {
                        return SearchString(Node.Left, key);
                    }
                    else
                    {
                        return SearchString(Node.Right, key);
                    }
                case "TradeMark":
                default:
                    if (String.Compare(Node.Products[0].TradeMark, key, true) == 0)
                    {
                        return Node;
                    }
                    else if (String.Compare(Node.Products[0].TradeMark, key, true) > 0)
                    {
                        return SearchString(Node.Left, key);
                    }
                    else
                    {
                        return SearchString(Node.Right, key);
                    }
            }
        }
    }
}
