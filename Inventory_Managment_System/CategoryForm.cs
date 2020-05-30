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
    public partial class CategoryForm : Form
    {
        IMSEntities entities = new IMSEntities();
        public CategoryForm()
        {
            InitializeComponent();
            loadData();
        }

        internal void loadData()
        {
            dataGridView1.DataSource = entities.T_CATEGORY.ToList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            T_CATEGORY category = new T_CATEGORY();
            category.C_NAME = txt_name.Text;

            entities.T_CATEGORY.Add(category);
            entities.SaveChanges();
            loadData();
            MessageBox.Show("Category has been created");
            resetFields();
        }

        private void resetFields()
        {
            txt_name.Text = null;
            txt_id.Text = null;
            btn_edit.Enabled = false;
            btn_add.Enabled = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            T_CATEGORY category = entities.T_CATEGORY.Find(Int32.Parse(txt_id.Text));
            category.C_NAME = txt_name.Text;

            entities.SaveChanges();
            loadData();
            MessageBox.Show("Category has been updated");
            resetFields();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            btn_edit.Enabled = true;
            btn_add.Enabled = false;
        }
    }
}
