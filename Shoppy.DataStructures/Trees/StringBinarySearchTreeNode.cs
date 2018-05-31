using Shoppy.Marketing.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shoppy.DataStructures.Trees
{
    public class StringBinarySearchTreeNode : BinarySearchTreeNode
    {
        public string type { get; set; }
        public StringBinarySearchTreeNode(string type) : base()
        {
            this.type = type;
        }
        public StringBinarySearchTreeNode(Product product, string type) : base(product)
        {
            this.type = type;
        }

        public override bool InsertNode(Product product)
        {
            switch (type)
            {
                case "Name":
                {
                    if (String.Compare(product.Name, Products[0].Name, true) == 0)
                    {
                        if (Products.Exists(x => x == product))
                        {
                            return false;
                        }
                        AddItem(product);
                        return true;
                    }
                    else if (String.Compare(product.Name, Products[0].Name, true) < 0)
                    {
                        if (Left == null)
                        {
                            Left = new StringBinarySearchTreeNode(product, type);
                            if (Right == null)
                            {
                                Balance = -1;
                            }
                            else
                            {
                                Balance = 0;
                            }
                        }
                        else
                        {
                            if (Left.InsertNode(product))
                            {
                                if (Left.Balance < -1 || Left.Balance > 1)
                                {
                                    Balancer.ReBalance(this, Left);
                                }
                                else
                                {
                                    Balance--;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (Right == null)
                        {
                            Right = new StringBinarySearchTreeNode(product, type);
                            if (Left == null)
                            {
                                Balance = 1;
                            }
                            else
                            {
                                Balance = 0;
                            }
                        }
                        else
                        {
                            if (Right.InsertNode(product))
                            {
                                if (Right.Balance < -1 || Right.Balance > 1)
                                {
                                    Balancer.ReBalance(this, Right);
                                }
                                else
                                {
                                    Balance++;
                                }
                            }
                        }
                    }
                    if (Balance != 0)
                    {
                        return true;
                    }
                }
                break;
                case "TradeMark":
                default:
                {
                    if (String.Compare(product.TradeMark, Products[0].TradeMark, true) == 0)
                    {
                        if (Products.Exists(x => x == product))
                        {
                            return false;
                        }
                        AddItem(product);
                        return true;
                    }
                    else if (String.Compare(product.TradeMark, Products[0].TradeMark, true) < 0)
                    {
                        if (Left == null)
                        {
                            Left = new StringBinarySearchTreeNode(product, type);
                            if (Right == null)
                            {
                                Balance = -1;
                            }
                            else
                            {
                                Balance = 0;
                            }
                        }
                        else
                        {
                            if (Left.InsertNode(product))
                            {
                                if (Left.Balance < -1 || Left.Balance > 1)
                                {
                                    Balancer.ReBalance(this, Left);
                                }
                                else
                                {
                                    Balance--;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (Right == null)
                        {
                            Right = new StringBinarySearchTreeNode(product, type);
                            if (Left == null)
                            {
                                Balance = 1;
                            }
                            else
                            {
                                Balance = 0;
                            }
                        }
                        else
                        {
                            if (Right.InsertNode(product))
                            {
                                if (Right.Balance < -1 || Right.Balance > 1)
                                {
                                    Balancer.ReBalance(this, Right);
                                }
                                else
                                {
                                    Balance++;
                                }
                            }
                        }
                    }
                }
                if (Balance != 0)
                {
                    return true;
                }
            break;
            }
            return false;
        }
    }
}
