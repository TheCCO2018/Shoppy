using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Shoppy.Authentication.Entities;
using Shoppy.DataAccess.Concrete;
using Shoppy.DataAccess.Filtering;
using Shoppy.Marketing.Entities;

namespace Shoppy.UI
{
    public partial class ManagementForm : MaterialSkin.Controls.MaterialForm
    {
        public Employee activeEmployee {get; set;}
        public ManagementForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Grey600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }
        List<string> CategoryNames = new List<string>();
        private void btnMenuAddProduct_Click(object sender, EventArgs e)
        {
            pnlAddProduct.Visible = true;
            pnlAddProduct.BringToFront();

            CategoryNames.Clear();
            dpAddProductCategory.Clear();
            CategoryNames = new Filter().GetStringLabels("Categories");
            foreach (var category in CategoryNames)
            {
                dpAddProductCategory.AddItem(category);
            }
        }

        ProductDataAccess pda = new ProductDataAccess();
        CategoryDataAccess cda = new CategoryDataAccess();
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (IsDigitsOnly(txtAddProductCost.Text) && IsDigitsOnly(txtAddProductSalePrice.Text) && txtAddProductName.Text != "" && txtAddProductTradeMark.Text != "" && txtAddProductModel.Text != "" && txtAddProductDescription.Text != "" && dpAddProductCategory.selectedValue != "")
            {
                Product newProduct = new Product();
                newProduct.CategoryID = cda.GetList().Where(c => c.Name == dpAddProductCategory.selectedValue).FirstOrDefault().CategoryID;
                newProduct.Name = txtAddProductName.Text;
                newProduct.TradeMark = txtAddProductTradeMark.Text;
                newProduct.Model = txtAddProductModel.Text;
                newProduct.Cost = Convert.ToDecimal(txtAddProductCost.Text);
                newProduct.SalePrice = Convert.ToDecimal(txtAddProductSalePrice.Text);
                newProduct.ProductDescription = txtAddProductDescription.Text;
                if (txtAddProductAvatar.Text == "")
                {
                    newProduct.PicturePath = "..\\..\\Assets\\ProductAvatars\\star"+ ".png";
                    if (pda.AddItem(newProduct) == false)
                    {
                        lblAddProductAlertFail.Visible = true;
                        lblAddProductAlertFail.BringToFront();
                    }
                    else
                    {
                        lblAddProductAlertSuccess.Visible = true;
                        lblAddProductAlertSuccess.BringToFront();
                    }
                }
                else
                {
                    newProduct.PicturePath = "..\\..\\Assets\\ProductAvatars\\"+txtAddProductAvatar.Text;
                    if (pda.AddItem(newProduct) == false)
                    {
                        lblAddProductAlertFail.Visible = true;
                        lblAddProductAlertFail.BringToFront();
                    }
                    else
                    {
                        lblAddProductAlertSuccess.Visible = true;
                        lblAddProductAlertSuccess.BringToFront();
                    }

                }
            }
            else
            {
                lblAddProductAlertFail.Visible = true;
                lblAddProductAlertFail.BringToFront();
            }
        }

        private bool IsDigitsOnly(string str)
        {
            str.Trim();
            foreach (char c in str)
            {
                if(c == ',')
                    continue;
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void btnAddProductChooseFile_Click(object sender, EventArgs e)
        {
            FileDialog(txtAddProductAvatar);
        }

        public void FileDialog(Bunifu.Framework.UI.BunifuMaterialTextbox textBox)
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
                textBox.Text = selectedName[selectedName.Length - 1];
            }
        }

        private void btnMenuAddEmployee_Click(object sender, EventArgs e)
        {
            pnlAddEmployee.Visible = true;
            pnlAddEmployee.BringToFront();

        }
        EmployeeDataAccess eda = new EmployeeDataAccess();
        private void btnAddEmploye_Click(object sender, EventArgs e)
        {
            if (txtAddEmployeeUserName.Text != "" && txtAddEmployeePassword.Text != "" && txtAddEmployeeFirstName.Text != "" && txtAddEmployeeLastName.Text != "" && txtAddEmployeeEMail.Text != "" && txtAddEmployeeAddress.Text != "" && txtAddEmployeeEMail.Text.Contains("@"))
            {
                Employee newEmployee = new Employee();
                newEmployee.FirstName = txtAddEmployeeFirstName.Text;
                newEmployee.LastName = txtAddEmployeeLastName.Text;
                newEmployee.UserName = txtAddEmployeeUserName.Text;
                newEmployee.Adress = txtAddEmployeeAddress.Text;
                newEmployee.Password = txtAddEmployeePassword.Text;
                newEmployee.EMail = txtAddEmployeeEMail.Text;
                if (txtAddEmployeeAvatar.Text == "")
                {
                    newEmployee.PicturePath = "..\\..\\Assets\\UserAvatars\\happy."+"png";
                    if (!eda.AddItem(newEmployee))
                    {
                        lblAddEmployeeAlertFail.Visible = true;
                        lblAddEmployeeAlertFail.BringToFront();
                    }
                    else
                    {
                        lblAddEmployeeAlertSuccess.Visible = true;
                        lblAddEmployeeAlertSuccess.BringToFront();
                    }
                }
                else
                {
                    newEmployee.PicturePath = "..\\..\\Assets\\UserAvatars\\" + txtAddEmployeeAvatar.Text;
                    if (!eda.AddItem(newEmployee))
                    {
                        lblAddEmployeeAlertFail.Visible = true;
                        lblAddEmployeeAlertFail.BringToFront();
                    }
                    else
                    {
                        lblAddEmployeeAlertSuccess.Visible = true;
                        lblAddEmployeeAlertSuccess.BringToFront();
                    }

                }
            }
            else
            {
                lblAddEmployeeAlertFail.Visible = true;
                lblAddEmployeeAlertFail.BringToFront();
            }
        }

        private void btnAddEmployeeChooseFile_Click(object sender, EventArgs e)
        {
            FileDialog(txtAddEmployeeAvatar);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if(txtAddCategoryDescription.Text != "" && txtAddCategoryName.Text != "")
            {

                if(!cda.AddItem(new Category() { CategoryDescription = txtAddCategoryDescription.Text, Name = txtAddCategoryName.Text }))
                {
                    lblManageCategoryAlertSuccessfull.Visible = false;
                    lblManageCategoryAlertFail.Visible = true;
                    lblManageCategoryAlertFail.BringToFront();
                    UpdateCategoryList();
                }
                else
                {
                    lblManageCategoryAlertFail.Visible = false;
                    lblManageCategoryAlertSuccessfull.Visible = true;
                    lblManageCategoryAlertSuccessfull.BringToFront();
                }
            }
            else
            {
                lblManageCategoryAlertSuccessfull.Visible = false;
                lblManageCategoryAlertFail.Visible = true;
                lblManageCategoryAlertFail.BringToFront();
            }
        }

        private void btnMenuAddCategory_Click(object sender, EventArgs e)
        {
            pnlUpdateCategoryName.Visible = true;
            pnlUpdateCategoryName.BringToFront();
            lblManageCategoryAlertFail.Visible = false;
            lblManageCategoryAlertSuccessfull.Visible = false;
            UpdateCategoryList();
        }
        private void UpdateCategoryList()
        {
            mlvCategories.Items.Clear();
            if(cda.GetList().Count > 0)
            {
                foreach (var category in cda.GetList())
                {
                    ListViewItem item = new ListViewItem(category.CategoryID.ToString());
                    item.SubItems.Add(category.Name);
                    item.SubItems.Add(category.CategoryDescription);
                    mlvCategories.Items.Add(item);
                }
            }
        }
        int categoryIndex = 0;
        private void mlvCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryIndex = Convert.ToInt32(mlvCategories.FocusedItem.Index);

            txtUpdateCategoryCategoryID.Text = mlvCategories.Items[categoryIndex].SubItems[0].Text;
            txtUpdateCategoryName.Text = mlvCategories.Items[categoryIndex].SubItems[1].Text;
            txtUpdateCategoryDescription.Text = mlvCategories.Items[categoryIndex].SubItems[2].Text;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            if (txtUpdateCategoryDescription.Text != "" && txtUpdateCategoryName.Text != "")
            {
                if (!cda.Update(new Category { CategoryID=Convert.ToInt32(txtUpdateCategoryCategoryID.Text), CategoryDescription=txtUpdateCategoryDescription.Text, Name =txtUpdateCategoryName.Text}))
                {
                    lblManageCategoryAlertSuccessfull.Visible = false;
                    lblManageCategoryAlertFail.Visible = true;
                    lblManageCategoryAlertFail.BringToFront();
                    UpdateCategoryList();
                }
                else
                {
                    lblManageCategoryAlertFail.Visible = false;
                    lblManageCategoryAlertSuccessfull.Visible = true;
                    lblManageCategoryAlertSuccessfull.BringToFront();
                }
            }
            else
            {
                lblManageCategoryAlertSuccessfull.Visible = false;
                lblManageCategoryAlertFail.Visible = true;
                lblManageCategoryAlertFail.BringToFront();
            }

        }

        private void btnUpdateOrDeleteProduct_Click(object sender, EventArgs e)
        {
            pnlMenuManageProduct.Visible = true;
            pnlMenuManageProduct.BringToFront();
            lblManageProductAlertFail.Visible = false;
            lblManageProductAlertSuccessfull.Visible = false;
            mainFilter = new Filter();
            List<Product> Products = mainFilter.Products;
            UpdateProductList(Products);
        }

        Filter mainFilter;
        public void UpdateProductList(List<Product> Products)
        {
            mlvProdutcs.Items.Clear();
            foreach (var product in Products)
            {
                ListViewItem item = new ListViewItem(product.ProductID.ToString());
                item.SubItems.Add(product.Name);
                item.SubItems.Add(product.ProductDescription);
                item.SubItems.Add(product.Cost.ToString() + " $");
                item.SubItems.Add(product.SalePrice.ToString() + " $");
                item.SubItems.Add(cda.GetList().Where(c => c.CategoryID == product.CategoryID).FirstOrDefault().Name);
                mlvProdutcs.Items.Add(item);
            }
        }
        int productIndex = 0;
        Product operatedProduct;
        private void mlvProdutcs_SelectedIndexChanged(object sender, EventArgs e)
        {
            productIndex = mlvProdutcs.FocusedItem.Index;
            operatedProduct = mainFilter.Products.First(p=>p.ProductID == Convert.ToInt32(mlvProdutcs.Items[productIndex].SubItems[0].Text));
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (mlvProdutcs.FocusedItem != null)
            {
                if (!pda.Delete(operatedProduct))
                {
                    lblManageProductAlertSuccessfull.Visible = false;
                    lblManageProductAlertFail.Visible = true;
                    lblManageProductAlertFail.BringToFront();
                }
                else
                {
                    lblManageProductAlertFail.Visible = false;
                    lblManageProductAlertSuccessfull.Visible = true;
                    lblManageProductAlertSuccessfull.BringToFront();
                }
                UpdateProductList(mainFilter.Products);
            }
        }

        private void txtSearchProduct_OnValueChanged(object sender, EventArgs e)
        {
            if (txtSearchProduct.Text != "")
            {
                mainFilter = new Filter();
                List<Product> Products = mainFilter.SearchByWord(txtSearchProduct.Text);
                UpdateProductList(Products);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            if(mlvCategories.FocusedItem != null)
            {
                if (!cda.Delete(cda.GetList().First(c => c.CategoryID == Convert.ToInt32(txtUpdateCategoryCategoryID.Text))))
                {
                    lblManageCategoryAlertSuccessfull.Visible = false;
                    lblManageCategoryAlertFail.Visible = true;
                    lblManageCategoryAlertFail.BringToFront();
                }
                else
                {
                    lblManageCategoryAlertFail.Visible = false;
                    lblManageCategoryAlertSuccessfull.Visible = true;
                    lblManageCategoryAlertSuccessfull.BringToFront();
                }
                UpdateCategoryList();
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (mlvProdutcs.FocusedItem != null)
            {
                CategoryNames = new Filter().GetStringLabels("Categories");
                foreach (var category in CategoryNames)
                {
                    dpUpdateProductCategory.AddItem(category);
                }
                dpUpdateProductCategory.selectedIndex = CategoryNames.IndexOf(cda.GetList().FirstOrDefault(c => c.CategoryID == operatedProduct.CategoryID).Name);
                txtUpdateProductName.Text = operatedProduct.Name;
                txtUpdateProductTradeMark.Text = operatedProduct.TradeMark;
                txtUpdateProductModel.Text = operatedProduct.Model;
                txtUpdateProductCost.Text = operatedProduct.Cost.ToString();
                txtUpdateProductSalePrice.Text = operatedProduct.SalePrice.ToString();
                string[] avatarName = operatedProduct.PicturePath.Split('\\');
                txtUpdateProductAvatar.Text = avatarName[avatarName.Length - 1];
                txtUpdateProductDescription.Text = operatedProduct.ProductDescription;

                pnlUpdateProduct.Visible = true;
                pnlUpdateProduct.BringToFront();
            }
        }

        private void btnUpdateProductComplete_Click(object sender, EventArgs e)
        {
            if (IsDigitsOnly(txtUpdateProductCost.Text) && IsDigitsOnly(txtUpdateProductSalePrice.Text) && txtUpdateProductName.Text != "" && txtUpdateProductTradeMark.Text != "" && txtUpdateProductModel.Text != "" && txtUpdateProductDescription.Text != "" && dpUpdateProductCategory.selectedValue != "")
            {

                if (txtAddProductAvatar.Text == "")
                {
                    operatedProduct.PicturePath = "..\\..\\Assets\\ProductAvatars\\star" + ".png";
                    if (pda.Update(operatedProduct) == false)
                    {
                        lblManageProductAlertSuccessfull.Visible = false;
                        lblManageProductAlertFail.Visible = true;
                        lblManageProductAlertFail.BringToFront();
                        pnlMenuManageProduct.Visible = true;
                        pnlMenuManageProduct.BringToFront();
                    }
                    else
                    {
                        lblManageProductAlertFail.Visible = false;
                        lblManageProductAlertSuccessfull.Visible = true;
                        lblManageProductAlertSuccessfull.BringToFront();
                        pnlMenuManageProduct.Visible = true;
                        pnlMenuManageProduct.BringToFront();
                    }
                }
                else
                {
                    operatedProduct.PicturePath = "..\\..\\Assets\\ProductAvatars\\" + txtAddProductAvatar.Text;
                    if (pda.Update(operatedProduct) == false)
                    {
                        lblManageProductAlertSuccessfull.Visible = false;
                        lblManageProductAlertFail.Visible = true;
                        lblManageProductAlertFail.BringToFront();
                        pnlMenuManageProduct.Visible = true;
                        pnlMenuManageProduct.BringToFront();
                    }
                    else
                    {
                        lblManageProductAlertFail.Visible = false;
                        lblManageProductAlertSuccessfull.Visible = true;
                        lblManageProductAlertSuccessfull.BringToFront();
                        pnlMenuManageProduct.Visible = true;
                        pnlMenuManageProduct.BringToFront();
                    }
                }
            }
            else
            {
                lblUpdateProductAlertSuccessfull.Visible = false;
                lblUpdateProductAlertFail.Visible = true;
                lblUpdateProductAlertFail.BringToFront();
            }
        }

        private void btnUpdateProductChooseFile_Click(object sender, EventArgs e)
        {
            FileDialog(txtUpdateProductAvatar);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Form = new LoginForm();
            Form.Show();
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            lblWelcomeUserName.Text = activeEmployee.FirstName.Substring(0, 1).ToUpper() + activeEmployee.FirstName.Substring(1).ToLower();
            UpdateMenuItems();
        }

        private void UpdateMenuItems()
        {
            btnUserProfileAvatar.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"" + activeEmployee.PicturePath));
            lblMenuUserName.Text = activeEmployee.FirstName.Substring(0, 1).ToUpper() + activeEmployee.FirstName.Substring(1).ToLower() + " " + activeEmployee.LastName.ToUpper();

        }

        private void btnMenuEmployeeProfile_Click(object sender, EventArgs e)
        {
            lblUpdateEmployeeAlertFail.Visible = false;
            lblUpdateEmployeeAlertSuccessfull.Visible = false;

            txtUpdateEmployeeFirstName.Text = activeEmployee.FirstName;
            txtUpdateEmployeeLastName.Text = activeEmployee.LastName;
            txtUpdateEmployeeEmail.Text = activeEmployee.EMail;
            txtUpdateEmployeeUsername.Text = activeEmployee.UserName;
            txtUpdateEmployeePassword.Text = activeEmployee.Password;
            txtUpdateEmployeeAddress.Text = activeEmployee.Adress;
            txtUpdateEmployeeRePassword.Text = "";
            string[] avatarName = activeEmployee.PicturePath.Split('\\');
            txtUpdateEmployeeAvatar.Text = avatarName[avatarName.Length - 1];

            pnlEmployeeProfile.Visible = true;
            pnlEmployeeProfile.BringToFront();

        }

        private void btnUpdateEmployeeChooseFile_Click(object sender, EventArgs e)
        {
            FileDialog(txtUpdateEmployeeAvatar);
        }

        private void btnUpdateEmployeeComplete_Click(object sender, EventArgs e)
        {
            if (txtUpdateEmployeeAddress.Text != "" && txtUpdateEmployeeLastName.Text != "" && txtUpdateEmployeeFirstName.Text != "" && txtUpdateEmployeeEmail.Text != "" && txtUpdateEmployeeUsername.Text != "" && txtUpdateEmployeePassword.Text != "" && txtUpdateEmployeeRePassword.Text != "")
            {
                if(String.Compare(txtUpdateEmployeePassword.Text,txtUpdateEmployeeRePassword.Text) == 0)
                {
                    activeEmployee.FirstName = txtUpdateEmployeeFirstName.Text;
                    activeEmployee.LastName = txtUpdateEmployeeLastName.Text;
                    activeEmployee.UserName = txtUpdateEmployeeUsername.Text;
                    activeEmployee.EMail = txtUpdateEmployeeEmail.Text;
                    activeEmployee.Adress = txtUpdateEmployeeAddress.Text;
                    activeEmployee.Password = txtUpdateEmployeePassword.Text;
                    if (txtUpdateEmployeeAvatar.Text == "")
                    {
                        activeEmployee.PicturePath = "..\\..\\Assets\\UserAvatars\\happy" + ".png";
                        if (!eda.Update(activeEmployee))
                        {
                            lblUpdateEmployeeAlertSuccessfull.Visible = false;
                            lblUpdateEmployeeAlertFail.Visible = true;
                            lblUpdateEmployeeAlertFail.BringToFront();
                        }
                        else
                        {
                            UpdateMenuItems();
                            btnMenuEmployeeProfile_Click(this, null);
                            lblUpdateEmployeeAlertFail.Visible = false;
                            lblUpdateEmployeeAlertSuccessfull.Visible = true;
                            lblUpdateEmployeeAlertSuccessfull.BringToFront();
                        }
                    }
                    else
                    {
                        activeEmployee.PicturePath = "..\\..\\Assets\\UserAvatars\\" + txtUpdateEmployeeAvatar.Text;
                        if (eda.Update(activeEmployee) == false)
                        {
                            lblUpdateEmployeeAlertSuccessfull.Visible = false;
                            lblUpdateEmployeeAlertFail.Visible = true;
                            lblUpdateEmployeeAlertFail.BringToFront();
                        }
                        else
                        {
                            UpdateMenuItems();
                            btnMenuEmployeeProfile_Click(this, null);
                            lblUpdateEmployeeAlertFail.Visible = false;
                            lblUpdateEmployeeAlertSuccessfull.Visible = true;
                            lblUpdateEmployeeAlertSuccessfull.BringToFront();                            
                        }
                    }
                }
                else
                {
                    lblUpdateEmployeeAlertSuccessfull.Visible = false;
                    lblUpdateEmployeeAlertFail.Visible = true;
                    lblUpdateEmployeeAlertFail.BringToFront();
                }

            }
            else
            {
                lblUpdateEmployeeAlertSuccessfull.Visible = false;
                lblUpdateEmployeeAlertFail.Visible = true;
                lblUpdateEmployeeAlertFail.BringToFront();
            }
        }

        private void btnManageFunds_Click(object sender, EventArgs e)
        { 
            OrderDataAccess ordersDA = new OrderDataAccess();
            OrderDetailDataAccess detailsDA = new OrderDetailDataAccess();
            mlvOrders.Items.Clear();
            decimal loss = 0, profit = 0;
            foreach (var order in ordersDA.GetList())
            {
                ListViewItem item = new ListViewItem(order.OrderID.ToString());
                item.SubItems.Add(order.CustomerID.ToString());
                item.SubItems.Add(order.OrderDate.ToLongTimeString());
                item.SubItems.Add(order.OrderState.ToString());
                if(detailsDA.GetList().Where(d => d.OrderID == order.OrderID).ToList().Count>0)
                {
                    foreach (var orderDetails in detailsDA.GetList().Where(d => d.OrderID == order.OrderID).ToList())
                    {
                        item.SubItems.Add(orderDetails.Loss + "$");
                        loss += orderDetails.Loss;
                        item.SubItems.Add(orderDetails.Profit + "$");
                        profit += orderDetails.Profit;
                    }
                }
                else
                {
                    item.SubItems.Add("---- $");
                    item.SubItems.Add("---- $");
                }
                mlvOrders.Items.Add(item);
            }
            lblLoss.Text = loss.ToString()+"$";
            lblProfit.Text = profit.ToString() + "$";

            if ((profit - loss) > 0)
            {
                lblBalance.ForeColor = Color.SeaGreen;
                lblBalance.Text = (profit - loss).ToString() + "$";
            }
            else
            {
                lblBalance.ForeColor = Color.Red;
                lblBalance.Text = (loss - profit).ToString() + "$";
            }
            pnlManageFunds.Visible = true;
            pnlManageFunds.BringToFront();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            pnlWelcome.Visible = true;
            pnlWelcome.BringToFront();
        }
    }
}
