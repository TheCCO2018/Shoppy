namespace Shoppy.UI
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.DragController = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlLoginForm = new System.Windows.Forms.Panel();
            this.pnlWelcome = new System.Windows.Forms.Panel();
            this.pboxArrowDown = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcomeThird = new System.Windows.Forms.Label();
            this.lblWelcomeSecond = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnCompleteLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblisEmployee = new System.Windows.Forms.Label();
            this.ckbEmplyee = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblAlertLoginFail = new System.Windows.Forms.Label();
            this.lblAlertLoginSuccess = new System.Windows.Forms.Label();
            this.txtLoginPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLoginUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.lblAlertFail = new System.Windows.Forms.Label();
            this.lblAlertSuccess = new System.Windows.Forms.Label();
            this.btnCompleteRegister = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtLastName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFirstName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnRegister = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblMark = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.ElipseRenderer = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlLoginForm.SuspendLayout();
            this.pnlWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxArrowDown)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // DragController
            // 
            this.DragController.Fixed = true;
            this.DragController.Horizontal = true;
            this.DragController.TargetControl = this.pnlLoginForm;
            this.DragController.Vertical = true;
            // 
            // pnlLoginForm
            // 
            this.pnlLoginForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlLoginForm.Controls.Add(this.pnlLogin);
            this.pnlLoginForm.Controls.Add(this.pnlWelcome);
            this.pnlLoginForm.Controls.Add(this.pnlRegister);
            this.pnlLoginForm.Controls.Add(this.btnRegister);
            this.pnlLoginForm.Controls.Add(this.btnLogin);
            this.pnlLoginForm.Controls.Add(this.lblMark);
            this.pnlLoginForm.Controls.Add(this.lblSlogan);
            this.pnlLoginForm.Controls.Add(this.btnClose);
            this.pnlLoginForm.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginForm.Name = "pnlLoginForm";
            this.pnlLoginForm.Size = new System.Drawing.Size(600, 500);
            this.pnlLoginForm.TabIndex = 0;
            // 
            // pnlWelcome
            // 
            this.pnlWelcome.BackColor = System.Drawing.Color.Transparent;
            this.pnlWelcome.Controls.Add(this.pboxArrowDown);
            this.pnlWelcome.Controls.Add(this.label3);
            this.pnlWelcome.Controls.Add(this.label2);
            this.pnlWelcome.Controls.Add(this.label1);
            this.pnlWelcome.Controls.Add(this.lblWelcomeThird);
            this.pnlWelcome.Controls.Add(this.lblWelcomeSecond);
            this.pnlWelcome.Controls.Add(this.lblWelcome);
            this.pnlWelcome.Location = new System.Drawing.Point(119, 160);
            this.pnlWelcome.Name = "pnlWelcome";
            this.pnlWelcome.Size = new System.Drawing.Size(373, 191);
            this.pnlWelcome.TabIndex = 15;
            // 
            // pboxArrowDown
            // 
            this.pboxArrowDown.Image = ((System.Drawing.Image)(resources.GetObject("pboxArrowDown.Image")));
            this.pboxArrowDown.Location = new System.Drawing.Point(236, 154);
            this.pboxArrowDown.Name = "pboxArrowDown";
            this.pboxArrowDown.Size = new System.Drawing.Size(37, 40);
            this.pboxArrowDown.TabIndex = 6;
            this.pboxArrowDown.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(80, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "easily just right here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "login :) If you don\'t have";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = " Before to be happy when ";
            // 
            // lblWelcomeThird
            // 
            this.lblWelcomeThird.AutoSize = true;
            this.lblWelcomeThird.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeThird.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeThird.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeThird.Location = new System.Drawing.Point(80, 121);
            this.lblWelcomeThird.Name = "lblWelcomeThird";
            this.lblWelcomeThird.Size = new System.Drawing.Size(208, 21);
            this.lblWelcomeThird.TabIndex = 2;
            this.lblWelcomeThird.Text = "an account. You can register ";
            // 
            // lblWelcomeSecond
            // 
            this.lblWelcomeSecond.AutoSize = true;
            this.lblWelcomeSecond.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeSecond.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeSecond.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeSecond.Location = new System.Drawing.Point(82, 67);
            this.lblWelcomeSecond.Name = "lblWelcomeSecond";
            this.lblWelcomeSecond.Size = new System.Drawing.Size(186, 21);
            this.lblWelcomeSecond.TabIndex = 1;
            this.lblWelcomeSecond.Text = "you are shopping. Please ";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(79, 11);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(203, 26);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Shoppy.";
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.SystemColors.ControlText;
            this.pnlLogin.Controls.Add(this.btnCompleteLogin);
            this.pnlLogin.Controls.Add(this.lblisEmployee);
            this.pnlLogin.Controls.Add(this.ckbEmplyee);
            this.pnlLogin.Controls.Add(this.lblAlertLoginFail);
            this.pnlLogin.Controls.Add(this.lblAlertLoginSuccess);
            this.pnlLogin.Controls.Add(this.txtLoginPassword);
            this.pnlLogin.Controls.Add(this.txtLoginUserName);
            this.pnlLogin.Location = new System.Drawing.Point(175, 160);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(250, 194);
            this.pnlLogin.TabIndex = 14;
            this.pnlLogin.Visible = false;
            // 
            // btnCompleteLogin
            // 
            this.btnCompleteLogin.Activecolor = System.Drawing.Color.Orange;
            this.btnCompleteLogin.BackColor = System.Drawing.Color.Black;
            this.btnCompleteLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompleteLogin.BorderRadius = 0;
            this.btnCompleteLogin.ButtonText = "  Login";
            this.btnCompleteLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompleteLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnCompleteLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCompleteLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCompleteLogin.Iconimage")));
            this.btnCompleteLogin.Iconimage_right = null;
            this.btnCompleteLogin.Iconimage_right_Selected = null;
            this.btnCompleteLogin.Iconimage_Selected = null;
            this.btnCompleteLogin.IconMarginLeft = 0;
            this.btnCompleteLogin.IconMarginRight = 0;
            this.btnCompleteLogin.IconRightVisible = true;
            this.btnCompleteLogin.IconRightZoom = 0D;
            this.btnCompleteLogin.IconVisible = true;
            this.btnCompleteLogin.IconZoom = 90D;
            this.btnCompleteLogin.IsTab = false;
            this.btnCompleteLogin.Location = new System.Drawing.Point(60, 117);
            this.btnCompleteLogin.Name = "btnCompleteLogin";
            this.btnCompleteLogin.Normalcolor = System.Drawing.Color.Black;
            this.btnCompleteLogin.OnHovercolor = System.Drawing.Color.Gold;
            this.btnCompleteLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCompleteLogin.selected = false;
            this.btnCompleteLogin.Size = new System.Drawing.Size(120, 48);
            this.btnCompleteLogin.TabIndex = 10;
            this.btnCompleteLogin.Text = "  Login";
            this.btnCompleteLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCompleteLogin.Textcolor = System.Drawing.Color.White;
            this.btnCompleteLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteLogin.Click += new System.EventHandler(this.btnCompleteLogin_Click);
            // 
            // lblisEmployee
            // 
            this.lblisEmployee.AutoSize = true;
            this.lblisEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblisEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblisEmployee.ForeColor = System.Drawing.Color.Gold;
            this.lblisEmployee.Location = new System.Drawing.Point(26, 98);
            this.lblisEmployee.Name = "lblisEmployee";
            this.lblisEmployee.Size = new System.Drawing.Size(61, 13);
            this.lblisEmployee.TabIndex = 9;
            this.lblisEmployee.Text = "Employee";
            this.lblisEmployee.Click += new System.EventHandler(this.lblisEmployee_Click);
            // 
            // ckbEmplyee
            // 
            this.ckbEmplyee.BackColor = System.Drawing.Color.Gold;
            this.ckbEmplyee.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ckbEmplyee.Checked = true;
            this.ckbEmplyee.CheckedOnColor = System.Drawing.Color.Gold;
            this.ckbEmplyee.ForeColor = System.Drawing.Color.White;
            this.ckbEmplyee.Location = new System.Drawing.Point(3, 95);
            this.ckbEmplyee.Name = "ckbEmplyee";
            this.ckbEmplyee.Size = new System.Drawing.Size(20, 20);
            this.ckbEmplyee.TabIndex = 8;
            this.ckbEmplyee.Tag = "Employee";
            // 
            // lblAlertLoginFail
            // 
            this.lblAlertLoginFail.AutoSize = true;
            this.lblAlertLoginFail.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertLoginFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlertLoginFail.ForeColor = System.Drawing.Color.Red;
            this.lblAlertLoginFail.Image = ((System.Drawing.Image)(resources.GetObject("lblAlertLoginFail.Image")));
            this.lblAlertLoginFail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAlertLoginFail.Location = new System.Drawing.Point(16, 172);
            this.lblAlertLoginFail.Name = "lblAlertLoginFail";
            this.lblAlertLoginFail.Size = new System.Drawing.Size(183, 18);
            this.lblAlertLoginFail.TabIndex = 7;
            this.lblAlertLoginFail.Text = "      Please fill the form!";
            this.lblAlertLoginFail.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblAlertLoginFail.Visible = false;
            // 
            // lblAlertLoginSuccess
            // 
            this.lblAlertLoginSuccess.AutoSize = true;
            this.lblAlertLoginSuccess.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertLoginSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlertLoginSuccess.ForeColor = System.Drawing.Color.Lime;
            this.lblAlertLoginSuccess.Image = ((System.Drawing.Image)(resources.GetObject("lblAlertLoginSuccess.Image")));
            this.lblAlertLoginSuccess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAlertLoginSuccess.Location = new System.Drawing.Point(74, 173);
            this.lblAlertLoginSuccess.Name = "lblAlertLoginSuccess";
            this.lblAlertLoginSuccess.Size = new System.Drawing.Size(110, 18);
            this.lblAlertLoginSuccess.TabIndex = 6;
            this.lblAlertLoginSuccess.Text = "   Successful!";
            this.lblAlertLoginSuccess.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblAlertLoginSuccess.Visible = false;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLoginPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoginPassword.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoginPassword.HintText = "";
            this.txtLoginPassword.isPassword = true;
            this.txtLoginPassword.LineFocusedColor = System.Drawing.Color.Orange;
            this.txtLoginPassword.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoginPassword.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.txtLoginPassword.LineThickness = 3;
            this.txtLoginPassword.Location = new System.Drawing.Point(0, 55);
            this.txtLoginPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(249, 33);
            this.txtLoginPassword.TabIndex = 4;
            this.txtLoginPassword.Text = "asdasd";
            this.txtLoginPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLoginUserName
            // 
            this.txtLoginUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLoginUserName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoginUserName.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoginUserName.HintText = "Username or Mail";
            this.txtLoginUserName.isPassword = false;
            this.txtLoginUserName.LineFocusedColor = System.Drawing.Color.Orange;
            this.txtLoginUserName.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoginUserName.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.txtLoginUserName.LineThickness = 3;
            this.txtLoginUserName.Location = new System.Drawing.Point(2, 8);
            this.txtLoginUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginUserName.Name = "txtLoginUserName";
            this.txtLoginUserName.Size = new System.Drawing.Size(249, 33);
            this.txtLoginUserName.TabIndex = 3;
            this.txtLoginUserName.Text = "Username";
            this.txtLoginUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pnlRegister
            // 
            this.pnlRegister.BackColor = System.Drawing.SystemColors.ControlText;
            this.pnlRegister.Controls.Add(this.lblAlertFail);
            this.pnlRegister.Controls.Add(this.lblAlertSuccess);
            this.pnlRegister.Controls.Add(this.btnCompleteRegister);
            this.pnlRegister.Controls.Add(this.txtPassword);
            this.pnlRegister.Controls.Add(this.txtUsername);
            this.pnlRegister.Controls.Add(this.txtMail);
            this.pnlRegister.Controls.Add(this.txtLastName);
            this.pnlRegister.Controls.Add(this.txtFirstName);
            this.pnlRegister.Location = new System.Drawing.Point(175, 160);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(250, 284);
            this.pnlRegister.TabIndex = 13;
            this.pnlRegister.Visible = false;
            // 
            // lblAlertFail
            // 
            this.lblAlertFail.AutoSize = true;
            this.lblAlertFail.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlertFail.ForeColor = System.Drawing.Color.Red;
            this.lblAlertFail.Image = ((System.Drawing.Image)(resources.GetObject("lblAlertFail.Image")));
            this.lblAlertFail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAlertFail.Location = new System.Drawing.Point(21, 256);
            this.lblAlertFail.Name = "lblAlertFail";
            this.lblAlertFail.Size = new System.Drawing.Size(178, 18);
            this.lblAlertFail.TabIndex = 7;
            this.lblAlertFail.Text = "     Please fill the form!";
            this.lblAlertFail.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblAlertFail.Visible = false;
            // 
            // lblAlertSuccess
            // 
            this.lblAlertSuccess.AutoSize = true;
            this.lblAlertSuccess.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlertSuccess.ForeColor = System.Drawing.Color.Lime;
            this.lblAlertSuccess.Image = ((System.Drawing.Image)(resources.GetObject("lblAlertSuccess.Image")));
            this.lblAlertSuccess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAlertSuccess.Location = new System.Drawing.Point(74, 255);
            this.lblAlertSuccess.Name = "lblAlertSuccess";
            this.lblAlertSuccess.Size = new System.Drawing.Size(110, 18);
            this.lblAlertSuccess.TabIndex = 6;
            this.lblAlertSuccess.Text = "   Successful!";
            this.lblAlertSuccess.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblAlertSuccess.Visible = false;
            // 
            // btnCompleteRegister
            // 
            this.btnCompleteRegister.Activecolor = System.Drawing.Color.Orange;
            this.btnCompleteRegister.BackColor = System.Drawing.Color.Black;
            this.btnCompleteRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompleteRegister.BorderRadius = 0;
            this.btnCompleteRegister.ButtonText = "    Register";
            this.btnCompleteRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompleteRegister.DisabledColor = System.Drawing.Color.Gray;
            this.btnCompleteRegister.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCompleteRegister.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCompleteRegister.Iconimage")));
            this.btnCompleteRegister.Iconimage_right = null;
            this.btnCompleteRegister.Iconimage_right_Selected = null;
            this.btnCompleteRegister.Iconimage_Selected = null;
            this.btnCompleteRegister.IconMarginLeft = 0;
            this.btnCompleteRegister.IconMarginRight = 0;
            this.btnCompleteRegister.IconRightVisible = true;
            this.btnCompleteRegister.IconRightZoom = 0D;
            this.btnCompleteRegister.IconVisible = true;
            this.btnCompleteRegister.IconZoom = 90D;
            this.btnCompleteRegister.IsTab = false;
            this.btnCompleteRegister.Location = new System.Drawing.Point(60, 212);
            this.btnCompleteRegister.Name = "btnCompleteRegister";
            this.btnCompleteRegister.Normalcolor = System.Drawing.Color.Black;
            this.btnCompleteRegister.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.btnCompleteRegister.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCompleteRegister.selected = false;
            this.btnCompleteRegister.Size = new System.Drawing.Size(125, 41);
            this.btnCompleteRegister.TabIndex = 5;
            this.btnCompleteRegister.Text = "    Register";
            this.btnCompleteRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCompleteRegister.Textcolor = System.Drawing.Color.White;
            this.btnCompleteRegister.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteRegister.Click += new System.EventHandler(this.btnCompleteRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.HintText = "";
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.Orange;
            this.txtPassword.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(0, 172);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(249, 33);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "asdasd";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUsername
            // 
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.HintText = "Username";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.Orange;
            this.txtUsername.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.txtUsername.LineThickness = 3;
            this.txtUsername.Location = new System.Drawing.Point(0, 117);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(249, 33);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMail
            // 
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtMail.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtMail.HintText = "Mail";
            this.txtMail.isPassword = false;
            this.txtMail.LineFocusedColor = System.Drawing.Color.Orange;
            this.txtMail.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txtMail.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.txtMail.LineThickness = 3;
            this.txtMail.Location = new System.Drawing.Point(1, 60);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(249, 33);
            this.txtMail.TabIndex = 2;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtLastName
            // 
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtLastName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.HintText = "Last Name";
            this.txtLastName.isPassword = false;
            this.txtLastName.LineFocusedColor = System.Drawing.Color.Orange;
            this.txtLastName.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.txtLastName.LineThickness = 3;
            this.txtLastName.Location = new System.Drawing.Point(131, 4);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(119, 33);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFirstName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.HintForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.HintText = "First Name";
            this.txtFirstName.isPassword = false;
            this.txtFirstName.LineFocusedColor = System.Drawing.Color.Orange;
            this.txtFirstName.LineIdleColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.LineMouseHoverColor = System.Drawing.Color.Gold;
            this.txtFirstName.LineThickness = 3;
            this.txtFirstName.Location = new System.Drawing.Point(1, 4);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(119, 33);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnRegister
            // 
            this.btnRegister.Activecolor = System.Drawing.Color.Gray;
            this.btnRegister.BackColor = System.Drawing.Color.Black;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.BorderRadius = 0;
            this.btnRegister.ButtonText = "Register";
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.DisabledColor = System.Drawing.Color.Gray;
            this.btnRegister.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegister.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRegister.Iconimage")));
            this.btnRegister.Iconimage_right = null;
            this.btnRegister.Iconimage_right_Selected = null;
            this.btnRegister.Iconimage_Selected = null;
            this.btnRegister.IconMarginLeft = 0;
            this.btnRegister.IconMarginRight = 0;
            this.btnRegister.IconRightVisible = true;
            this.btnRegister.IconRightZoom = 0D;
            this.btnRegister.IconVisible = true;
            this.btnRegister.IconZoom = 50D;
            this.btnRegister.IsTab = false;
            this.btnRegister.Location = new System.Drawing.Point(307, 350);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Normalcolor = System.Drawing.Color.Black;
            this.btnRegister.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnRegister.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegister.selected = false;
            this.btnRegister.Size = new System.Drawing.Size(119, 48);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegister.Textcolor = System.Drawing.Color.White;
            this.btnRegister.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Activecolor = System.Drawing.Color.Gray;
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.BorderRadius = 0;
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogin.Iconimage")));
            this.btnLogin.Iconimage_right = null;
            this.btnLogin.Iconimage_right_Selected = null;
            this.btnLogin.Iconimage_Selected = null;
            this.btnLogin.IconMarginLeft = 0;
            this.btnLogin.IconMarginRight = 0;
            this.btnLogin.IconRightVisible = true;
            this.btnLogin.IconRightZoom = 0D;
            this.btnLogin.IconVisible = true;
            this.btnLogin.IconZoom = 50D;
            this.btnLogin.IsTab = false;
            this.btnLogin.Location = new System.Drawing.Point(175, 350);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Normalcolor = System.Drawing.Color.Black;
            this.btnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogin.selected = false;
            this.btnLogin.Size = new System.Drawing.Size(119, 48);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Textcolor = System.Drawing.Color.White;
            this.btnLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.BackColor = System.Drawing.Color.Transparent;
            this.lblMark.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMark.ForeColor = System.Drawing.Color.Gold;
            this.lblMark.Location = new System.Drawing.Point(174, 59);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(252, 63);
            this.lblMark.TabIndex = 4;
            this.lblMark.Text = "Shoppy";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.BackColor = System.Drawing.Color.Transparent;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSlogan.Location = new System.Drawing.Point(189, 116);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(223, 28);
            this.lblSlogan.TabIndex = 5;
            this.lblSlogan.Text = "Be happy with Shoppy.";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(563, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ElipseRenderer
            // 
            this.ElipseRenderer.ElipseRadius = 20;
            this.ElipseRenderer.TargetControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.pnlLoginForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginScreen";
            this.pnlLoginForm.ResumeLayout(false);
            this.pnlLoginForm.PerformLayout();
            this.pnlWelcome.ResumeLayout(false);
            this.pnlWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxArrowDown)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl DragController;
        private Bunifu.Framework.UI.BunifuElipse ElipseRenderer;
        private System.Windows.Forms.Panel pnlLoginForm;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.Label lblSlogan;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegister;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogin;
        private System.Windows.Forms.Panel pnlRegister;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLastName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFirstName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMail;
        private Bunifu.Framework.UI.BunifuFlatButton btnCompleteRegister;
        private System.Windows.Forms.Label lblAlertSuccess;
        private System.Windows.Forms.Label lblAlertFail;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblAlertLoginFail;
        private System.Windows.Forms.Label lblAlertLoginSuccess;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLoginPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtLoginUserName;
        private Bunifu.Framework.UI.BunifuCheckbox ckbEmplyee;
        private System.Windows.Forms.Label lblisEmployee;
        private Bunifu.Framework.UI.BunifuFlatButton btnCompleteLogin;
        private System.Windows.Forms.Panel pnlWelcome;
        private System.Windows.Forms.Label lblWelcomeSecond;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblWelcomeThird;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pboxArrowDown;
    }
}

