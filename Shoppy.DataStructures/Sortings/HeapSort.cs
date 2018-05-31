using Shoppy.Marketing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.DataStructures.Trees
{
    public class HeapSort
    {
        private List<Product> Products;
        public HeapSort(List<Product> Products)
        {
            this.Products = Products;
        }

        public List<Product> Sort()
        {
            Heap _Heap = new Heap(Products.Count);
            List<Product> SortedProducts = new List<Product>();
            //Heap Ağacı Oluştur
            foreach (var item in Products)
                _Heap.Insert(item);
            //Ağaçtaki maksimum elemanı al ve yeni diziye ekle
            while (!_Heap.IsEmpty())
                SortedProducts.Add(_Heap.RemoveMax().Value);
            return SortedProducts;
        }

    }
}
