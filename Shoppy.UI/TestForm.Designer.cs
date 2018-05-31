namespace Shoppy.UI
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvwProduct = new System.Windows.Forms.ListView();
            this.TradeMark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SalePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvwProduct
            // 
            this.lvwProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TradeMark,
            this.Model,
            this.ProductsName,
            this.Description,
            this.SalePrice});
            this.lvwProduct.Location = new System.Drawing.Point(12, 12);
            this.lvwProduct.Name = "lvwProduct";
            this.lvwProduct.Size = new System.Drawing.Size(487, 212);
            this.lvwProduct.TabIndex = 0;
            this.lvwProduct.UseCompatibleStateImageBehavior = false;
            this.lvwProduct.View = System.Windows.Forms.View.Details;
            // 
            // TradeMark
            // 
            this.TradeMark.Text = "TradeMark";
            // 
            // Model
            // 
            this.Model.Text = "Model";
            // 
            // ProductsName
            // 
            this.ProductsName.Text = "ProductName";
            // 
            // Description
            // 
            this.Description.Text = "Description";
            // 
            // SalePrice
            // 
            this.SalePrice.Text = "SalePrice";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Location = new System.Drawing.Point(12, 292);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(487, 212);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "TradeMark";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SalePrice";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 576);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lvwProduct);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwProduct;
        private System.Windows.Forms.ColumnHeader TradeMark;
        private System.Windows.Forms.ColumnHeader Model;
        private System.Windows.Forms.ColumnHeader ProductsName;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader SalePrice;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}