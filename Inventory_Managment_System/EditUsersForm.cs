using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class EditUsersForm : Form
    {
        IMSEntities entities = new IMSEntities();
        public EditUsersForm()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            dataGridView1.DataSource = entities.T_USER.ToList();
            dataGridView1.Columns["U_PASSWORD"].Visible = false;
            dataGridView1.Columns["U_ID"].HeaderText = "ID";
            dataGridView1.Columns["U_USERNAME"].HeaderText = "Username";
            dataGridView1.Columns["U_EMAIL"].HeaderText = "Email";
            dataGridView1.Columns["U_FULL_NAME"].HeaderText = "Full Name";
            dataGridView1.Columns["U_PASSWORD"].HeaderText = "Password";
            dataGridView1.Columns["U_COMPANY_NAME"].HeaderText = "Company";
            dataGridView1.Columns["U_ROLE"].HeaderText = "Role";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
                dataGridView1.DataSource = entities.T_USER.Where(u => u.U_FULL_NAME.ToLower().Contains(textBox2.Text.ToString())).ToList();
            else
                dataGridView1.DataSource = entities.T_USER.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_email.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            btn_delete.Enabled = true;
            btn_edit.Enabled = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            T_USER user = entities.T_USER.Find(Int32.Parse(txt_id.Text));
            user.U_FULL_NAME = txt_name.Text;
            user.U_EMAIL = txt_email.Text;
            entities.SaveChanges();
            loadData();
            MessageBox.Show("User has been updated");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete?",
            "Sure?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                T_USER user = entities.T_USER.Find(Int32.Parse(txt_id.Text));
                entities.T_USER.Remove(user);
                entities.SaveChanges();
                MessageBox.Show("User has been deleted");
                loadData();
            }
        }
    }
}
