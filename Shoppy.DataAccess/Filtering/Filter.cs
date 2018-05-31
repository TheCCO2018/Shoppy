using Shoppy.DataAccess.Concrete;
using Shoppy.DataStructures.Tables;
using Shoppy.DataStructures.Trees;
using Shoppy.Marketing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy.DataAccess.Filtering
{
    public class Filter
    {
        private string categoryName;

        public string CategoryName
        {
            get { return categoryName; }
            set
            {
                GetItemsByCategory(value);
                categoryName = value;
            }
        }

        private string TradeMark;
        private bool isTradeMark = false;
        private string Name;
        private string KeyWord;
        private StringBST TradeMarkTree = new StringBST("TradeMark");
        private StringBST NameTree = new StringBST("Name");
        private IntBST PriceTree = new IntBST();
        private List<BinarySearchTree> Trees { get; set; }
        private HashMapChain HashMap { get; set; }
        public List<Product> Products = new List<Product>();

        public Filter()
        {
            Products = new ProductDataAccess().GetList();
            Trees = new List<BinarySearchTree>();
            Trees.Add(TradeMarkTree);
            Trees.Add(NameTree);
            Trees.Add(PriceTree);
        }

        public Filter(string categoryName)
        {
            GetItemsByCategory(categoryName);
            Trees = new List<BinarySearchTree>();
            Trees.Add(TradeMarkTree);
            Trees.Add(NameTree);
            Trees.Add(PriceTree);
        }

        private void GetItemsByCategory(string categoryName)
        {
            if(Products != null)
            {
                Products.Clear();
                int CategoryID = new CategoryDataAccess().GetList().Where(x => x.Name == categoryName).ElementAtOrDefault(0).CategoryID;

                if (CategoryID != -1)
                {
                    Products = new ProductDataAccess().GetByCategoryName(CategoryID);
                }
                else
                {
                    Products = new List<Product>();
                }  
            }
        }
        private void AddItemsToTheTree(BinarySearchTree tree)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                tree.Add(Products[i]);
            }
        }

        public List<Product> FilterByName(string name)
        {
            Name = name;
            isTradeMark = false;
            AddItemsToTheTree(NameTree);
            Products.Clear();
            Products.AddRange(NameTree.Search(Name).Products);
            return Products;
        }
        public List<Product> FilterByTradeMark(string trademark)
        {
            TradeMark = trademark;
            isTradeMark = true;
            AddItemsToTheTree(TradeMarkTree);
            Products.Clear();
            Products.AddRange(TradeMarkTree.Search(TradeMark).Products);
            return Products;
        }
        public List<Product> FilterBySalePriceRange(decimal min, decimal max)
        {
            HeapSort _HeapSort = new HeapSort(Products);
            List<Product> FilteredProducts = _HeapSort.Sort();
            foreach (var product in FilteredProducts.ToList())
            {
                if(product.SalePrice < min || product.SalePrice > max)
                {
                    FilteredProducts.Remove(product);
                }
            }
            return FilteredProducts;
        }
        public List<Product> FilterByModel(string model)
        {
            if (isTradeMark)
            {
                FilterByTradeMark(TradeMark);
                if (HashMap == null)
                {
                    HashMap = new HashMapChain(TradeMarkTree.Search(TradeMark).Products.Count);
                }
                HashMap.ClearTable();
                foreach (var product in TradeMarkTree.Search(TradeMark).Products)
                {
                    HashMap.AddItem(product.Model, product);
                }
            }
            else
            {

                FilterByName(Name);
                if (HashMap == null)
                {
                    HashMap = new HashMapChain(NameTree.Search(Name).Products.Count);
                }
                HashMap.ClearTable();
                foreach (var product in NameTree.Search(Name).Products)
                {
                    HashMap.AddItem(product.Model, product);
                }
            }
            Products.Clear();
            if(HashMap.GetItem(model).Cast<Product>().ToList().Count != 0)
                Products = HashMap.GetItem(model).Cast<Product>().ToList();
            
            return Products;
        }
        public List<Product> SearchByWord(string word)
        {
            KeyWord = word;
            foreach (var tree in Trees)
            {
                if (tree.NumberOfNodes() == 0)
                {
                    AddItemsToTheTree(TradeMarkTree);
                }
            }
            Products.Clear();
            foreach (var tree in Trees)
            {
                if (tree is StringBST)
                {
                    StringBST tempTree = (StringBST)tree;
                    tempTree.InOrder();
                    foreach (var product in tempTree.GetProducts())
                    {
                        if (product.ProductDescription.ToLower().Contains(KeyWord.ToLower()) || product.Name.ToLower().Contains(KeyWord.ToLower()) || product.Model.ToLower().Contains(KeyWord.ToLower()) || product.TradeMark.ToLower().Contains(KeyWord.ToLower()))
                        {
                            if (!Products.Contains(product))
                            {
                                Products.Add(product);
                            }
                        }
                    }
                    break;
                }
                if(tree is IntBST)
                {
                    IntBST tempTree = (IntBST)tree;
                    tempTree.InOrder();
                    foreach (var product in tempTree.GetProducts())
                    {
                        if (product.ProductDescription.ToLower().Contains(KeyWord.ToLower()) || product.Name.ToLower().Contains(KeyWord.ToLower()) || product.Model.ToLower().Contains(KeyWord.ToLower()) || product.TradeMark.ToLower().Contains(KeyWord.ToLower()))
                        {
                            if (!Products.Contains(product))
                            {
                                Products.Add(product);
                            }
                        }
                    }
                    break;
                }
            }
            return Products;
        }
        public List<string> GetStringLabels(string type)
        {
            List<string> Labels = new List<string>();
            if(type=="Categories" && new CategoryDataAccess().GetList() != null)
            {
                foreach (var category in new CategoryDataAccess().GetList())
                {
                    Labels.Add(category.Name);
                }
                return Labels;
            }
            foreach (var tree in Trees)
            {
                if(tree is StringBST)
                {
                    StringBST tempTree = (StringBST)tree;
                    if (String.Compare(tempTree.GetTreeType(), type, true) == 0)
                    {
                        AddItemsToTheTree(tempTree);
                        if (type == "TradeMark")
                        {
                            tempTree.InOrder();
                            foreach (var product in tempTree.GetProducts())
                            {
                                if(!Labels.Exists(t=>t.CompareTo(product.TradeMark) == 0))
                                    Labels.Add(product.TradeMark);
                            }
                            break;
                        }
                        if (type == "Name")
                        {
                            tempTree.InOrder();
                            foreach (var product in tempTree.GetProducts())
                            {
                                if (!Labels.Exists(t => t.CompareTo(product.Name) == 0))
                                    Labels.Add(product.Name);
                            }
                            break;
                        }
                    }
                    if(type == "Model" && tree == TradeMarkTree)
                    {
                        StringBST tempTradeMarkTree = (StringBST)tree;
                        if(tree.NumberOfNodes() == 0)
                        {
                            AddItemsToTheTree(tree);
                        }
                        tree.InOrder();
                        foreach (var product in tempTree.Search(TradeMark).Products)
                        {
                            if (!Labels.Exists(t => t.CompareTo(product.Model) == 0))
                                Labels.Add(product.Model);
                        }
                        break;
                    }
                }
            }
            return Labels;
        }

    }
}
