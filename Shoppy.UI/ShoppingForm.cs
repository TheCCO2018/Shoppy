using BrightIdeasSoftware;
using Shoppy.Authentication.Entities;
using Shoppy.DataAccess;
using Shoppy.DataAccess.Concrete;
using Shoppy.DataAccess.Filtering;
using Shoppy.Entities.Ordering;
using Shoppy.Marketing.Entities;
using Shoppy.Ordering.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Shoppy.UI
{
    public partial class ShoppingForm : Form
    {
        List<Product> Products;
        public ShoppingForm()
        {
            InitializeComponent();
            Products = new List<Product>();
        }
        
        public Customer activeCustomer { get; set; }
        Order firstOrder;
        Filter mainFilter = new Filter();
        List<string> Categories = new List<string>();
        List<string> TradeMarks = new List<string>();
        List<string> Models = new List<string>();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(pnlMenu.Visible)
            {
                pnlMenu.Visible = false;
            }
            else
            {
                pnlMenu.Visible = true;
                pnlMenu.BringToFront();
            }
        }

        Filter HotItems;
        private void ShoppingForm_Load(object sender, EventArgs e)
        {
            UpdateMenuItems();
            HotItems = new Filter();
            if (HotItems.Products.Count > 3)
            {
                picHotItemOne.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"" + HotItems.Products.ElementAt(HotItems.Products.Count - 1).PicturePath));
                lblHotItemOneTitle.Text = HotItems.Products.ElementAt(HotItems.Products.Count - 1).Name;
                lblHotItemOneDesc.Text = HotItems.Products.ElementAt(HotItems.Products.Count - 1).ProductDescription;
                lblHotItemOnePrice.Text = HotItems.Products.ElementAt(HotItems.Products.Count - 1).SalePrice + " $";

                picHotItemTwo.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"" + HotItems.Products.ElementAt(HotItems.Products.Count - 2).PicturePath));
                lblHotItemTwoTitle.Text = HotItems.Products.ElementAt(HotItems.Products.Count - 2).Name;
                lblHotItemTwoDesc.Text = HotItems.Products.ElementAt(HotItems.Products.Count - 2).ProductDescription;
                lblHotItemTwoPrice.Text = HotItems.Products.ElementAt(HotItems.Products.Count - 2).SalePrice + " $";

                picHotItemThree.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"" + HotItems.Products.ElementAt(HotItems.Products.Count - 3).PicturePath));
                lblHotItemThreeTitle.Text = HotItems.Products.ElementAt(HotItems.Products.Count - 3).Name;
                lblHotItemThreeDesc.Text = HotItems.Products.ElementAt(HotItems.Products.Count - 3).ProductDescription;
                lblHotItemThreePrice.Text = HotItems.Products.ElementAt(HotItems.Products.Count - 3).SalePrice + " $";

                picHotItemFour.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"" + HotItems.Products.ElementAt(HotItems.Products.Count - 4).PicturePath));
                lblHotItemFourTitle.Text = HotItems.Products.ElementAt(HotItems.Products.Count - 4).Name;
                lblHotItemFourDesc.Text = HotItems.Products.ElementAt(HotItems.Products.Count - 4).ProductDescription;
                lblHotItemFourPrice.Text = HotItems.Products.ElementAt(HotItems.Products.Count - 4).SalePrice + " $";
            }
            firstOrder = new Order { CustomerID = activeCustomer.CustomerID, OrderState = Order.OrderStatus.Open };

        }
        private void UpdateMenuItems()
        {
            btnUserProfileAvatar.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"" + activeCustomer.PicturePath));
            lblMenuUserName.Text = activeCustomer.FirstName.Substring(0, 1).ToUpper() + activeCustomer.FirstName.Substring(1) + " " + activeCustomer.LastName.ToUpper();
        }
        public void normalListViewFiller(ListView lv, List<string> labels)
        {
            lv.Clear();
            lv.Items.Clear();
            foreach (var item in labels)
            {
               lv.Items.Add(new ListViewItem(item));
            }
        }

        private void olvProducts_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Product product = (Product)e.Model;
                NamedDescriptionDecoration decorationProduct = new NamedDescriptionDecoration();
                decorationProduct.ImageList = this.ilistProducts;
                decorationProduct.Title = product.Name;
                decorationProduct.ImageName = Convert.ToString(product.ProductID);
                decorationProduct.Description = product.ProductDescription;
                e.SubItem.Decoration = decorationProduct;
            }
        }

        public void InitializeObjectListView(List<Product> Products)
        {
            olvProducts.Items.Clear();
            ilistProducts.Images.Clear();
            this.olvColumnProduct.AspectToStringConverter = delegate (object x) {
                return "";
            };
            if(Products != null)
            {
                foreach (var product in Products)
                {
                    ilistProducts.Images.Add(Convert.ToString(product.ProductID), Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"" + product.PicturePath)));
                }
            }
            this.olvProducts.SetObjects(Products);
        }
        CustomerDataAccess CustomerAccess = new CustomerDataAccess();
        CommentDataAccess CommentAccess = new CommentDataAccess();
        private void olvComments_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Comment comment = (Comment)e.Model;
                NamedDescriptionDecoration decorationComment = new NamedDescriptionDecoration();
                decorationComment.ImageList = this.ilistComment;
                Customer CommentOwner = CustomerAccess.GetCustomer(comment.CustomerID);
                decorationComment.Title = CommentOwner.FirstName.Substring(0,1).ToUpper()+ CommentOwner.FirstName.Substring(1) + " "+CommentOwner.LastName.ToUpper();
                decorationComment.ImageName = Convert.ToString(comment.CustomerID);
                decorationComment.Description = comment.CommentDescription;
                e.SubItem.Decoration = decorationComment;
            }
        }
        public void InitializeOLVComments(List<Comment> Comments)
        {
            olvComments.Items.Clear();
            ilistComment.Images.Clear();
            this.olvColumnComment.AspectToStringConverter = delegate (object x) {
                return "";
            };
            foreach (var comment in Comments)
            {
                ilistComment.Images.Add(Convert.ToString(comment.CustomerID), Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"" + CustomerAccess.GetCustomer(comment.CustomerID).PicturePath)));
            }
            this.olvComments.SetObjects(Comments);
        }
        public void InitializeOLVCart(List<Product> Products)
        {
            olvCart.Items.Clear();
            ilistShoppingCart.Images.Clear();
            this.olvColumnShoppingProduct.AspectToStringConverter = delegate (object x) {
                return "";
            };
            foreach (var product in Products)
            {
                ilistShoppingCart.Images.Add(Convert.ToString(product.ProductID), Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"" + product.PicturePath)));
            }
            this.olvCart.SetObjects(Products);
        }
        private void olvCart_FormatCell(object sender, BrightIdeasSoftware.FormatCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Product product = (Product)e.Model;
                NamedDescriptionDecoration decorationCart = new NamedDescriptionDecoration();
                decorationCart.ImageList = this.ilistShoppingCart;
                decorationCart.Title = product.Name;
                decorationCart.ImageName = Convert.ToString(product.ProductID);
                decorationCart.Description = product.ProductDescription;
                e.SubItem.Decoration = decorationCart;
            }
        }
        private void CellClick(object sender, CellClickEventArgs e)
        {
            // MessageBox.Show((String.Format("Button clicked: ({0}, {1}, {2})", e.RowIndex, e.SubItem, e.Model)));           
            if (e.Model != null)
            {
                FillProductDetailPanel((Product)e.Model);
                InitializeOLVCart(Products);
                this.olvProducts.RefreshObject(e.Model);
            }
           
        }
        Product DetailedProduct;
        private void FillProductDetailPanel(Product product)
        {
            DetailedProduct = product;
            pnlProductDetails.Visible = true;
            pnlProductDetails.BringToFront();
            pbDetailedProductPhoto.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"" + DetailedProduct.PicturePath));
            lblDetailedProductTitle.Text = DetailedProduct.Name;
            lblDetailedProductDescription.Tag = DetailedProduct.ProductDescription;
            if (DetailedProduct.ProductDescription.Length > 50)
            {
                lblDetailedProductDescription.Text = DetailedProduct.ProductDescription.Substring(0,47)+"...";
            }
            else
            {
                lblDetailedProductDescription.Text = DetailedProduct.ProductDescription;
            }
            lblPriceValue.Text = DetailedProduct.SalePrice + " $";
            lblDetailedProductModel.Text = DetailedProduct.Model;
            product.Comments.Clear();
            product.Comments = CommentAccess.GetSpecificComments(product.ProductID);
            ratingProductDetail.Value = DetailedProduct.Overall();
            nudAmount.Value = 1;
            InitializeOLVComments(product.Comments);
        }
        int tradeMarkIndex = -1;
        private void HandleOnlvTradeMarksItemSelectionChanged(Object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                tradeMarkIndex = lvTradeMarks.FocusedItem.Index;
                InitializeObjectListView(mainFilter.FilterByTradeMark(TradeMarks.ElementAt(tradeMarkIndex)));
                Models.Clear();
                Models.AddRange(mainFilter.GetStringLabels("Model"));
                normalListViewFiller(lvModels, Models);
            }
            else
            {
                columnTradeMarks.Text = String.Empty;
            }
        }
        int modelIndex = -1;
        private void HandleOnlvModelsItemSelectionChanged(Object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                modelIndex = lvModels.FocusedItem.Index;
                InitializeObjectListView(mainFilter.FilterByModel(Models.ElementAt(modelIndex)));
            }
            else
            {
                columnTradeMarks.Text = String.Empty;
            }
        }

        private void txtSearchBox_OnValueChanged(object sender, EventArgs e)
        {
            pnlSearch.Visible = true;
            pnlSearch.BringToFront();
            Filter allProduct = new Filter();
            InitializeObjectListView(allProduct.SearchByWord(txtSearchBox.Text));
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            if(pnlCategories.Visible)
            {
                pnlCategories.Visible = false;
            }
            else
            {
                pnlCategories.Visible = true;
                pnlCategories.BringToFront();
                Categories = new Filter().GetStringLabels("Categories");
                normalListViewFiller(lvCategories, Categories);
            }       
        }
        int categorieIndex = -1;
        private void HandleOnlvCategoriesItemSelectionChanged(Object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                    pnlMenu.Visible = false;
                    pnlCategories.Visible = false;
                    pnlSearch.Visible = true;
                    pnlSearch.BringToFront();
                    categorieIndex = lvCategories.FocusedItem.Index;
                    mainFilter.CategoryName = Categories.ElementAt(categorieIndex);
                    InitializeObjectListView(mainFilter.Products);
                    TradeMarks.Clear();
                    TradeMarks = mainFilter.GetStringLabels("TradeMark");
                    normalListViewFiller(lvTradeMarks, TradeMarks);
            }
            else
            {
                columnTradeMarks.Text = String.Empty;
            }
        }

        private void txtMaxPrice_OnValueChanged(object sender, EventArgs e)
        {
            if ((IsDigitsOnly(txtMaxPrice.Text) && txtMaxPrice.Text != "" ) && (txtMinPrice.Text != "" && IsDigitsOnly(txtMinPrice.Text)))
            {
                InitializeObjectListView(mainFilter.FilterBySalePriceRange(Convert.ToDecimal(txtMinPrice.Text), Convert.ToDecimal(txtMaxPrice.Text)));
            }
            
        }
        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            if(pnlCart.Visible)
            {
                pnlCart.Visible = false;
            }
            else
            {
                pnlCart.Visible = true;
                pnlCart.BringToFront();
            }
        }

        private void btnResetCart_Click(object sender, EventArgs e)
        {
            firstOrder.Cart.LineItems.Clear();
            lblTotalAmount.Text = "0 $";
            lblShoppingCartCount.Text = "0";
            lblShoppingCartCount.Visible = false;
            Products.Clear();
            InitializeOLVCart(Products);
        }

        private void btnSearchKeyWord_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = true;
            pnlSearch.BringToFront();
            Filter allProduct = new Filter();
            InitializeObjectListView(allProduct.SearchByWord(txtSearchBox.Text));
        }

        OrderDataAccess ODA = new OrderDataAccess();
        OrderDetailDataAccess DetailDA = new OrderDetailDataAccess();
        private void btnOrderCart_Click(object sender, EventArgs e)
        {
            activeCustomer.Orders.Add(firstOrder);
            OrderDetail orderDetail = new OrderDetail();
            foreach (var item in firstOrder.Cart.LineItems)
            {
                orderDetail.Loss += item.Product.Cost*item.Quantity;
                orderDetail.Profit += item.Price;
            }
            ODA.AddItem(activeCustomer.Orders.ElementAt(activeCustomer.Orders.Count - 1));
            orderDetail.OrderID = activeCustomer.Orders.ElementAt(activeCustomer.Orders.Count - 1).OrderID;
            DetailDA.AddItem(orderDetail);
            firstOrder = null;
            firstOrder = new Order();
            firstOrder.Customer = activeCustomer;
            firstOrder.CustomerID = activeCustomer.CustomerID;
            firstOrder.OrderState = Order.OrderStatus.Open;
            btnResetCart_Click(this,null);
        }

        private void btnHotItemOneAddCart_Click(object sender, EventArgs e)
        {
            if (HotItems.Products.Count > 0)
            {
                Products.Clear();
                firstOrder.Cart.AddItem(new LineItem(HotItems.Products.ElementAt(3), 1, HotItems.Products.ElementAt(3).SalePrice));
                foreach (var lineItem in firstOrder.Cart.LineItems)
                {
                    Products.Add(lineItem.Product);
                }
                lblShoppingCartCount.Visible = true;
                lblTotalAmount.Text = firstOrder.Cart.CartTotal() + " $";
                lblShoppingCartCount.Text = Products.Count.ToString();
                InitializeOLVCart(Products);
            }
        }

        private void btnHotItemTwoAddCart_Click(object sender, EventArgs e)
        {
            if (HotItems.Products.Count > 0)
            {
                Products.Clear();
                firstOrder.Cart.AddItem(new LineItem((Product)HotItems.Products.ElementAt(2), 1, HotItems.Products.ElementAt(2).SalePrice));
                foreach (var lineItem in firstOrder.Cart.LineItems)
                {
                    Products.Add(lineItem.Product);
                }
                lblShoppingCartCount.Visible = true;
                lblTotalAmount.Text = firstOrder.Cart.CartTotal() + " $";
                lblShoppingCartCount.Text = Products.Count.ToString();
                InitializeOLVCart(Products);
            }
        }

        private void btnHotItemThreeAddCart_Click(object sender, EventArgs e)
        {
            if (HotItems.Products.Count > 0)
            {
                Products.Clear();
                firstOrder.Cart.AddItem(new LineItem((Product)HotItems.Products.ElementAt(1), 1, HotItems.Products.ElementAt(1).SalePrice));
                foreach (var lineItem in firstOrder.Cart.LineItems)
                {
                    Products.Add(lineItem.Product);
                }
                lblShoppingCartCount.Visible = true;
                lblTotalAmount.Text = firstOrder.Cart.CartTotal() + " $";
                lblShoppingCartCount.Text = Products.Count.ToString();
                InitializeOLVCart(Products);
            }
        }

        private void btnHotItemFourAddCart_Click(object sender, EventArgs e)
        {
            if (HotItems.Products.Count > 0)
            {
                Products.Clear();
                firstOrder.Cart.AddItem(new LineItem((Product)HotItems.Products.ElementAt(0), 1, HotItems.Products.ElementAt(0).SalePrice));
                foreach (var lineItem in firstOrder.Cart.LineItems)
                {
                    Products.Add(lineItem.Product);
                }
                lblShoppingCartCount.Visible = true;
                lblTotalAmount.Text = firstOrder.Cart.CartTotal() + " $";
                lblShoppingCartCount.Text = Products.Count.ToString();
                InitializeOLVCart(Products);
            }
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            pnlCart.Visible = false;
            pnlMenu.Visible = false;
            pnlWelcome.Visible = true;
            pnlWelcome.BringToFront();
        }


        private void btnAddDetailedProduct_Click(object sender, EventArgs e)
        {
            Products.Clear();
            firstOrder.Cart.AddItem(new LineItem(DetailedProduct, Convert.ToInt32(nudAmount.Value), DetailedProduct.SalePrice));
            foreach (var lineItem in firstOrder.Cart.LineItems)
            {
                Products.Add(lineItem.Product);
            }
            lblShoppingCartCount.Visible = true;
            lblTotalAmount.Text = firstOrder.Cart.CartTotal() + " $";
            lblShoppingCartCount.Text = Products.Count.ToString();
            InitializeOLVCart(Products);

        }

        private void btnGoBackToTheSearch_Click(object sender, EventArgs e)
        {
            pnlProductDetails.Visible = false;
        }
        Comment userComment;
        private void btnFinishComment_Click(object sender, EventArgs e)
        {
            if(txtComment.Text != "" || txtComment.Text != "Comment Here")
            {
                Comment.Stars Star;
                switch(ratingComment.Value)
                {
                    case 1:
                        Star = Comment.Stars.One;
                    break;
                    case 2:
                        Star = Comment.Stars.Two;
                    break;
                    case 3:
                        Star = Comment.Stars.Three;
                    break;
                    case 4:
                        Star = Comment.Stars.Four;
                    break;
                    case 5:
                        Star = Comment.Stars.Five;
                    break;
                    case 0:
                    default:
                        Star = Comment.Stars.Zero;
                    break;
                }
                userComment = new Comment(activeCustomer.CustomerID, txtComment.Text, Star) { ProductID = DetailedProduct.ProductID};
                CommentAccess.AddItem(userComment);
                txtComment.Text = "Comment here...";
                ratingComment.Value = 0;
                DetailedProduct.Comments.Clear();
                DetailedProduct.Comments = CommentAccess.GetSpecificComments(DetailedProduct.ProductID);
                InitializeOLVComments(DetailedProduct.Comments);
            }
        }

        private void btnMenuLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Form = new LoginForm();
            Form.Show();
        }

        private void btnUserProfileAvatar_Click(object sender, EventArgs e)
        {
            FileDialog();
        }
        public void FileDialog()
        {
            OpenFileDialog ofdPicturePath = new OpenFileDialog();

            ofdPicturePath.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            ofdPicturePath.Filter = "Image Files (*.png, *.jpg)|*.png;*.jpg";
            ofdPicturePath.FilterIndex = 0;
            ofdPicturePath.RestoreDirectory = true;

            if (ofdPicturePath.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = ofdPicturePath.FileName;
                string[] selectedName = selectedFileName.Split('\\');
                activeCustomer.PicturePath = "..\\..\\Assets\\UserAvatars\\"+selectedName[selectedName.Length - 1];
                CustomerAccess.Update(activeCustomer);
                UpdateMenuItems();
            }
        }
    }
    public class NamedDescriptionDecoration : AbstractDecoration
    {
        public ImageList ImageList;
        public string ImageName;
        public string Title;
        public string Description;

        public Font TitleFont = new Font("Tahoma", 9, FontStyle.Bold);
        public Color TitleColor = Color.FromArgb(255, 32, 32, 32);
        public Font DescripionFont = new Font("Tahoma", 9);
        public Color DescriptionColor = Color.FromArgb(255, 96, 96, 96);
        public Size CellPadding = new Size(1, 1);

        public override void Draw(BrightIdeasSoftware.ObjectListView olv, Graphics g, Rectangle r)
        {
            Rectangle cellBounds = this.CellBounds;
            cellBounds.Inflate(-this.CellPadding.Width, -this.CellPadding.Height);
            Rectangle textBounds = cellBounds;

            if (this.ImageList != null && !String.IsNullOrEmpty(this.ImageName))
            {
                g.DrawImage(this.ImageList.Images[this.ImageName], cellBounds.Location);
                textBounds.X += this.ImageList.ImageSize.Width;
                textBounds.Width -= this.ImageList.ImageSize.Width;
            }

            //g.DrawRectangle(Pens.Red, textBounds);

            // Draw the title
            StringFormat fmt = new StringFormat(StringFormatFlags.NoWrap);
            fmt.Trimming = StringTrimming.EllipsisCharacter;
            fmt.Alignment = StringAlignment.Near;
            fmt.LineAlignment = StringAlignment.Near;

            using (SolidBrush b = new SolidBrush(this.TitleColor))
            {
                g.DrawString(this.Title, this.TitleFont, b, textBounds, fmt);
            }

            // Draw the description
            SizeF size = g.MeasureString(this.Title, this.TitleFont, (int)textBounds.Width, fmt);
            textBounds.Y += (int)size.Height;
            textBounds.Height -= (int)size.Height;
            StringFormat fmt2 = new StringFormat();
            fmt2.Trimming = StringTrimming.EllipsisCharacter;
            using (SolidBrush b = new SolidBrush(this.DescriptionColor))
            {
                g.DrawString(this.Description, this.DescripionFont, b, textBounds, fmt2);
            }
        }
    }
}
