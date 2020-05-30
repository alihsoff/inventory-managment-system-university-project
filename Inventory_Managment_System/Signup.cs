using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class Signup : Form
    {
        private Login login;
        private IMSEntities entities = new IMSEntities();
        public Signup(Login login)
        {
            this.login = login;
            InitializeComponent();
            btn_backToLogin.Visible = true;
        }

        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            T_USER user = new T_USER();
            user.U_FULL_NAME = txt_fullname.Text;
            user.U_USERNAME = txt_username.Text;
            user.U_EMAIL = txt_email.Text;
            user.U_COMPANY_NAME = txt_companyName.Text;
            user.U_PASSWORD = txt_password.Text;
            user.U_IMAGE = "defaultuser.png";
            user.U_ROLE = "USER";
            entities.T_USER.Add(user);
            entities.SaveChanges();
            lbl_success.Visible = true;
            resetFields();

        }

        private void txt_password_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Cannot be empity");
                btn_signup.Enabled = false;
            }
        }

        private void txt_rePassword_Validating(object sender, CancelEventArgs e)
        {
            if (!txt_password.Text.Equals(txt_rePassword.Text))
            {
                MessageBox.Show("Password don't match");
                btn_signup.Enabled = false;
            }
            else
            {
                btn_signup.Enabled = true;
            }
        }

        private void resetFields() {
            txt_companyName.Text = null;
            txt_fullname.Text = null;
            txt_password.Text = null;
            txt_rePassword.Text = null;
            txt_email.Text = null;
            txt_username.Text = null;
            btn_signup.Enabled = false;
        }
    }
}
