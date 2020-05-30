using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class SelectProductForm : Form
    {
        IMSEntities entities = new IMSEntities();
        CreateOrderForm form;
        public SelectProductForm(CreateOrderForm crateOrderForm)
        {
            this.form = crateOrderForm;
            InitializeComponent();
            dataGridView1.DataSource = entities.V_PRODUCT.ToList();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            form.selectedProduct = entities.T_PRODUCT.Find(Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
            form.lbl_productName.Text = form.selectedProduct.P_NAME;
            form.nd_quantity.Maximum = form.selectedProduct.P_QUANTITY;
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
                dataGridView1.DataSource = entities.V_PRODUCT.Where(u => u.Name.ToLower().Contains(textBox2.Text.ToString())).ToList();
            else
                dataGridView1.DataSource = entities.V_PRODUCT.ToList();
        }
    }
}
