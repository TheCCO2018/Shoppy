using Shoppy.DataStructures.Trees;
using System;
using Shoppy.Marketing.Entities;
using System.Collections.Generic;
using System.Windows.Forms;
using Shoppy.DataAccess.Filtering;

namespace Shoppy.UI
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            IntBST priceTree = new IntBST();
            StringBST tradeMarkTree = new StringBST("TradeMark");
            Product[] fakeProducts = new Product[10];
            for (int i = 0; i < fakeProducts.Length / 2; i++)
            {
                fakeProducts[i] = new Product { Name = "Product " + i,
                    ProductDescription = "This is the " + i + ". test product",
                    SalePrice = i + 1,
                    Model = "X1",
                    Cost = i,
                    TradeMark = "TheJengo",
                };
                priceTree.Add(fakeProducts[i]);
                tradeMarkTree.Add(fakeProducts[i]);
            }
            for (int i = fakeProducts.Length / 2; i < fakeProducts.Length; i++)
            {
                fakeProducts[i] = new Product
                {
                    Name = "Product " + i,
                    ProductDescription = "This is the " + i + ". test product",
                    SalePrice = i + 1,
                    Model = "X" + i,
                    Cost = i,
                    TradeMark = "TheTudorst",
                };
                priceTree.Add(fakeProducts[i]);
                tradeMarkTree.Add(fakeProducts[i]);
            }
            priceTree.InOrder();
            tradeMarkTree.InOrder();
            lvwProduct.Items.Clear();
            Filter f1 = new Filter("Computer");
            List<string> label = f1.GetStringLabels("Model");
            foreach (var Product in f1.SearchByWord("Lenovo"))
            {

                var listViewItem = new ListViewItem(Product.TradeMark);
                listViewItem.SubItems.Add(Product.Model);
                listViewItem.SubItems.Add(Product.Name);
                listViewItem.SubItems.Add(Product.ProductDescription);
                listViewItem.SubItems.Add(Product.SalePrice + " TL");
                lvwProduct.Items.Add(listViewItem);
            }
            /*
            HashMapChain _HMP = new HashMapChain(10);
            foreach (var Product in tradeMarkTree.GetProducts())
            {
                var listViewItem = new ListViewItem(Product.TradeMark);
                listViewItem.SubItems.Add(Product.Model);
                listViewItem.SubItems.Add(Product.Name);
                listViewItem.SubItems.Add(Product.ProductDescription);
                listViewItem.SubItems.Add(Product.SalePrice + " TL");
                listView1.Items.Add(listViewItem);
            }
            List<Product> ps = tradeMarkTree.Search("TheJengo").Products;
            foreach (var item in ps)
            {
                _HMP.AddItem(item.Model, item);
            }
            */
        }
    }
}
