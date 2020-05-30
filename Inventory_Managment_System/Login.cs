using Inventory_Managment_System.Config;
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
    public partial class Login : Form
    {
        IMSEntities entities = new IMSEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Signup signup = new Signup(this);
            this.Hide();
            signup.ShowDialog();
            //this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forget forget = new Forget();
            forget.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String username = txt_username.Text;
            String password = txt_password.Text;
            var myUser = entities.T_USER.FirstOrDefault(u => u.U_USERNAME == username && u.U_PASSWORD == password);
            if (myUser != null)
            {
                ConfigUser configUser = new ConfigUser(myUser);
                ConfigUser.configUser = configUser;
                Form main = null;
                this.Hide();
                if (configUser.User.U_ROLE == "ADMIN")
                {
                    main = new Main();
                }
                else {
                    main = new UserMain();
                }
                main.ShowDialog();
                this.Close();
            }
            else
            {
                txt_username.Text = null;
                txt_password.Text = null;
                lbl_error.Visible = true;
            }
        }
    }
}
