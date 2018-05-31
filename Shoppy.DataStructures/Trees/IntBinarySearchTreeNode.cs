using Shoppy.Marketing.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shoppy.DataStructures.Trees
{
    public class IntBinarySearchTreeNode : BinarySearchTreeNode
    {
        public IntBinarySearchTreeNode():base()
        {

        }
        public IntBinarySearchTreeNode(Product product) : base(product)
        {

        }
        public override bool InsertNode(Product product)
        {
            if (product.SalePrice == (decimal)Products[0].SalePrice)
            {
                if (Products.Exists(x => x == product))
                {
                    return false;
                }
                AddItem(product);
                return true;
            }
            else if (product.SalePrice < (decimal)Products[0].SalePrice)
            {
                if (Left == null)
                {
                    Left = new IntBinarySearchTreeNode(product);
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
                    Right = new IntBinarySearchTreeNode(product);
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
            return false;
        }
    }
}
