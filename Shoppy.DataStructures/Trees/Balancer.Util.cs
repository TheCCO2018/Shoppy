using System;
using System.Collections.Generic;
using System.Text;

namespace Shoppy.DataStructures.Trees
{
    public static class Balancer
    {
        public static void RotateLeft(BinarySearchTreeNode ParentNode, BinarySearchTreeNode Node)
        {
            BinarySearchTreeNode tempNode = Node.Right;
            Node.Right = tempNode.Left;
            tempNode.Left = Node;

            if(Node == ParentNode.Left)
            {
                ParentNode.Left = tempNode;
            }
            else
            {
                ParentNode.Right = tempNode;
            }
            Node.Balance = 0;
            tempNode.Balance = 0;
        }
        public static void RotateRight(BinarySearchTreeNode ParentNode, BinarySearchTreeNode Node)
        {
            BinarySearchTreeNode tempNode = Node.Left;
            Node.Left = tempNode.Right;
            tempNode.Right = Node;

            if (Node == ParentNode.Left)
            {
                ParentNode.Left = tempNode;
            }
            else
            {
                ParentNode.Right = tempNode;
            }
            Node.Balance = 0;
            tempNode.Balance = 0;
        }
        public static void RotateRightLeft(BinarySearchTreeNode ParentNode, BinarySearchTreeNode Node)
        {
            Node.Right.Left.Balance = 1;
            RotateRight(Node, Node.Right);
            Node.Right.Balance = 1;
            RotateLeft(ParentNode, Node);
        }
        public static void RotateLeftRight(BinarySearchTreeNode ParentNode,BinarySearchTreeNode Node)
        {
            Node.Left.Right.Balance = -1;
            RotateRight(Node,Node.Left);
            Node.Left.Balance = -1;
            RotateLeft(ParentNode,Node);
        }

        public static void ReBalance(BinarySearchTreeNode ParentNode, BinarySearchTreeNode Node)
        {
            // if left subtree is too high, and left child has a left child
            if(Node.Balance == -2 && Node.Left.Balance == -1)
            {
                RotateRight(ParentNode, Node);
            }
            // if right subtree is too high, and right child has a right child
            else if (Node.Balance == 2 && Node.Right.Balance == 1)
            {
                RotateLeft(ParentNode, Node);
            }
            // Left subtree is too high, and left child has a right child.	
            else if (Node.Balance == -2 && Node.Left.Balance == 1)
            {
                RotateLeftRight(ParentNode, Node);
            }
            // Right subtree is too high, and right child has a left child.	
            else if( Node.Balance == 2 && Node.Right.Balance == -1)
            {
                RotateRightLeft(ParentNode, Node);
            }
        }
    }
}
