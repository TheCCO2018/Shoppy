using Shoppy.Authentication.Entities;
using Shoppy.DataAccess;
using Shoppy.DataAccess.Abstraction;
using Shoppy.DataAccess.Concrete;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shoppy.UI
{
    public partial class LoginForm : Form
    {
        ICustomerRepository cda = new CustomerDataAccess();
        IEmployeeRepository eda = new EmployeeDataAccess();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            pnlWelcome.Visible = false;
            btnLogin.Location = new Point(btnLogin.Location.X, 450);
            btnLogin.Visible = true;
            btnRegister.Visible = false;
            pnlRegister.Visible = true;
            pnlRegister.BringToFront();
            lblAlertFail.Visible = false;
            lblAlertSuccess.Visible = false;
        }

        private void btnCompleteRegister_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text != "" && txtFirstName.Text != "" && txtLastName.Text != "" && txtMail.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {
                // Initialize the customer with provided values
                Customer c = new Customer();
                c.FirstName = txtFirstName.Text;
                c.LastName = txtLastName.Text;
                c.UserName = txtUsername.Text;
                c.password = txtPassword.Text;
                c.EMail = txtMail.Text;
                c.PicturePath = "..\\..\\Assets\\UserAvatars\\happy"+".png";
                //add to db
                if(cda.AddItem(c))
                // alert the result
                {
                    lblAlertSuccess.Visible = true;
                    lblAlertSuccess.BringToFront();
                }
                else
                {
                    lblAlertFail.Text = "   Unavailable Values to Register";
                    lblAlertFail.Visible = true;
                    lblAlertFail.BringToFront();
                }
            }
            else
            {
                lblAlertFail.Text = "Please fill the form!";
                lblAlertFail.Visible = true;
                lblAlertFail.BringToFront();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            pnlWelcome.Visible = false;
            btnRegister.Visible = true;
            pnlRegister.Visible = false;
            pnlLogin.Visible = true;
            pnlLogin.BringToFront();
            btnLogin.Visible = false;
            lblAlertLoginFail.Visible = false;
            lblAlertLoginSuccess.Visible = false;

        }

        public static IUser ActiveUser;
        private void btnCompleteLogin_Click(object sender, EventArgs e)
        {
            if(ckbEmplyee.Checked == false)
            {
                if (txtLoginUserName.Text != "" && txtPassword.Text != "")
                {
                    ActiveUser =cda.Login(txtLoginUserName.Text, txtLoginPassword.Text);
                    if (!(ActiveUser is null))
                    {
                        lblAlertLoginSuccess.Visible = true;
                        lblAlertLoginSuccess.BringToFront();
                        this.Hide();
                        ShoppingForm Form = new ShoppingForm();
                        Form.activeCustomer = (Customer)ActiveUser;
                        Form.Show();
                    }
                    else
                    {
                        lblAlertLoginFail.Text = "    Somethings wrong!";
                        lblAlertLoginFail.Visible = true;
                        lblAlertLoginFail.BringToFront();
                    }
                }
                else
                {
                    lblAlertLoginFail.Text = "Please fill the form!";
                    lblAlertLoginFail.Visible = true;
                    lblAlertLoginFail.BringToFront();
                }
            }
            else
            {
                if (txtLoginUserName.Text != "" && txtPassword.Text != "")
                {
                    ActiveUser = eda.Login(txtLoginUserName.Text, txtLoginPassword.Text);
                    if (!(ActiveUser is null))
                    {
                        lblAlertLoginSuccess.Visible = true;
                        lblAlertLoginSuccess.BringToFront();
                        this.Hide();
                        ManagementForm Form = new ManagementForm();
                        Form.activeEmployee =(Employee)ActiveUser;
                        Form.Show();
                    }
                    else
                    {
                        lblAlertLoginFail.Text = "    Somethings wrong!";
                        lblAlertLoginFail.Visible = true;
                        lblAlertLoginFail.BringToFront();
                    }
                }
                else
                {
                    lblAlertLoginFail.Text = "Please fill the form!";
                    lblAlertLoginFail.Visible = true;
                    lblAlertLoginFail.BringToFront();
                }

            }
           
        }

        private void lblisEmployee_Click(object sender, EventArgs e)
        {
            if(ckbEmplyee.Checked == true)
            {
                ckbEmplyee.Checked = false;
            }
            else
            {
                ckbEmplyee.Checked = true;
            }
        }
    }
}
