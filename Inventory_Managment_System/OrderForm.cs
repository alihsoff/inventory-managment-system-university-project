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
    public partial class OrderForm : Form
    {
        IMSEntities entities = new IMSEntities();
        public OrderForm()
        {
            InitializeComponent();
            loadData();
        }

        public void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            List<DataGridViewRow> complatedOrders = dataGridView1.Rows
            .Cast<DataGridViewRow>()
            .Where(r => r.Cells["O_STATUS"].Value.ToString().Equals("True")).ToList();
            for (int i = 0; i < complatedOrders.Count; i++)
            {
                dataGridView1.Rows[complatedOrders[i].Index].DefaultCellStyle.BackColor = Color.Green;
            }
        }

        internal void loadData(){
            dataGridView1.DataSource = entities.T_ORDER.ToList();

            dataGridView1.Columns["O_ID"].HeaderText = "ID";
            dataGridView1.Columns["O_COMPANY_NAME"].HeaderText = "Company";
            dataGridView1.Columns["O_CREATER_NAME"].HeaderText = "Creater";
            dataGridView1.Columns["O_TOTAL_AMOUNT"].HeaderText = "Total Amount";
            dataGridView1.Columns["O_CREATED_AT"].HeaderText = "Date";
            dataGridView1.Columns["O_STATUS"].Visible = false;

            if (dataGridView1.Columns.Count <= 6)
            {
                DataGridViewButtonColumn createInvoice = new DataGridViewButtonColumn();
                createInvoice.Name = "createInvoice";
                createInvoice.HeaderText = "Invoice";
                createInvoice.Text = "Create Invoice";
                createInvoice.UseColumnTextForButtonValue = true;
                DataGridViewButtonColumn deleteOrder = new DataGridViewButtonColumn();
                deleteOrder.Name = "deleteOrder";
                deleteOrder.HeaderText = "Delete";
                deleteOrder.Text = "Delete Order";
                deleteOrder.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(createInvoice);
                dataGridView1.Columns.Add(deleteOrder);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "createInvoice")
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["O_STATUS"].Value.ToString().Equals("False"))
                {
                    int orderId = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["O_ID"].Value.ToString());
                    CreateAndViewInvoice createInvoice = new CreateAndViewInvoice(orderId, this);
                    createInvoice.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Cannot create invoice!", "Invoice of product already exists!");
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "deleteOrder")
            {
                if (dataGridView1.Rows[e.RowIndex].Cells["O_STATUS"].Value.ToString().Equals("False"))
                {
                    DialogResult result = MessageBox.Show("Are you sure to delete?",
                        "Sure?",
                        MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        int orderId = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["O_ID"].Value.ToString());
                        T_ORDER order = entities.T_ORDER.Find(orderId);
                        entities.T_ORDER.Remove(order);
                        entities.SaveChanges();
                        loadData();
                    }
                }
                else
                {
                    MessageBox.Show("Cannot delete order!", "Invoice of product already exists!");
                }
            }
        }

        private void OrderForm_Shown(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
