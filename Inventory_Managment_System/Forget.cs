using Inventory_Managment_System.Util;
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
    public partial class Forget : Form
    {
        Boolean[] isClicked = { true, false, false };
        private String secretCode;
        private String email;
        IMSEntities entities = new IMSEntities(); 
        public Forget()
        {
            InitializeComponent();
        }

        private void Forget_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (isClicked[0])
            {
                Random random = new Random();

                secretCode = random.Next(10000,99999).ToString(); 
                label.Text = "Code";
                label.Left = 200;
                btn_send.Text = "Approve";
                email = txt_field.Text;
                txt_field.Text = "";
                isClicked[0] = false;
                isClicked[1] = true;
                MailUtil.sendMail(email, "Reset Password", "Secret code: " + secretCode);
            }
            else if (isClicked[1])
            {
                if (txt_field.Text == secretCode)
                {
                    label.Text = "New Password";
                    label.Left = 170;
                    txt_field.Text = "";
                    btn_send.Text = "Reset Password";
                    isClicked[1] = false;
                    isClicked[2] = true;
                }
                else
                {
                    MessageBox.Show("Code doesn't match");
                }
            }
            else if (isClicked[2])
            {
                T_USER user = entities.T_USER.FirstOrDefault(u => u.U_EMAIL == email);
                user.U_PASSWORD = txt_field.Text;

                entities.SaveChanges();

                txt_field.Visible = false;
                btn_send.Visible = false;
                label.Text = "Your password has changed successfully";
                label.ForeColor = Color.Green;
                label.Left = 110;
                label.Top = 50;
            }
        }
    }
}
