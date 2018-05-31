using Shoppy.Marketing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.DataStructures.Trees
{
    public class Heap
    {
        private HeapNode[] heapArray;
        private int maxSize;
        private int currentSize;
        public Heap(int maxHeapSize)
        {
            maxSize = maxHeapSize;
            currentSize = 0;
            heapArray = new HeapNode[maxSize];
        }
        public bool IsEmpty()
        { 
            return currentSize == 0; 
        }
        public bool Insert(Product value)
        {
            if (currentSize == maxSize)
                return false;
            HeapNode newHeapDugumu = new HeapNode(value);
            heapArray[currentSize] = newHeapDugumu;
            MoveToUp(currentSize++);
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapNode bottom = heapArray[index];
            while (index > 0 && heapArray[parent].Value.SalePrice < bottom.Value.SalePrice)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public HeapNode RemoveMax() // Remove maximum value HeapNode
        {
            HeapNode root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
            return root;
        }
        public void MoveToDown(int index)
        {
            int largerChild;
            HeapNode top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                //Find larger child
                if (rightChild < currentSize && heapArray[leftChild].Value.SalePrice < heapArray[rightChild].Value.SalePrice)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.Value.SalePrice >= heapArray[largerChild].Value.SalePrice)
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }
    }
}
