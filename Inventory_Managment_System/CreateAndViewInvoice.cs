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
    public partial class CreateAndViewInvoice : Form
    {
        private int orderId;
        IMSEntities entities = new IMSEntities();
        decimal totalAmount = 0;
        OrderForm orderForm;
        public CreateAndViewInvoice(int orderId, OrderForm orderForm)
        {
            this.orderForm = orderForm;
            InitializeComponent();
            this.orderId = orderId;
            loadData();
        }

        public CreateAndViewInvoice(int orderId, String totalAmount)
        {
            InitializeComponent();
            this.orderId = orderId;
            loadData();
            dataGridView1.ReadOnly = true;
            btn_add.Enabled = false;
            lbl_totalAmount.Text = totalAmount;
        }

        private void loadData()
        {
            List<OrderProduct> products = entities.T_PRODUCT_ORDER.Where(po => po.P_O_ORDER_ID == orderId)
                .Join(
                    entities.T_PRODUCT,
                    po => po.P_O_PRODUCT_ID,
                    p => p.P_ID,
                    (po, p) => new OrderProduct
                    {
                        Select = po.P_O_STATUS,
                        ProductId = po.P_O_PRODUCT_ID,
                        ProductName = p.P_NAME,
                        OrderQuantity = po.P_O_QUANTITY,
                        TotalAmount = po.P_O_TOTAL_AMOUNT
                    }
                ).ToList();
            dataGridView1.DataSource = products;
            totalAmount = products.Sum(p => p.TotalAmount);
            lbl_totalAmount.Text = totalAmount.ToString();
            txt_orderID.Text = orderId.ToString();
            txt_companyName.Text = entities.T_ORDER.Find(orderId).O_COMPANY_NAME;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public class OrderProduct{
            public bool Select { get; set; }
            public int ProductId { get; set; }
            public String ProductName { get; set; }
            public int OrderQuantity { get; set; }
            public decimal TotalAmount { get; set; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
                if (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() == "False")
                {
                    totalAmount -= decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                }
                else
                {

                    totalAmount += decimal.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                }
                lbl_totalAmount.Text = totalAmount.ToString();
            

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            T_INVOICE invoice = new T_INVOICE();
            invoice.I_O_ID = orderId;
            invoice.I_TOTAL_AMOUNT = totalAmount;
            invoice.I_CREATED_AT = DateTime.Parse(DateTime.Now.ToString("dd.MM.yyyy"));
            entities.T_INVOICE.Add(invoice);

            T_ORDER order = entities.T_ORDER.Find(orderId);
            order.O_STATUS = true;

            List<DataGridViewRow> unselectedProducts = dataGridView1.Rows
            .Cast<DataGridViewRow>()
            .Where(p => p.Cells["Select"].Value.ToString().Equals("False")).ToList();


            List<DataGridViewRow> selectedProducts = dataGridView1.Rows
            .Cast<DataGridViewRow>()
            .Where(p => p.Cells["Select"].Value.ToString().Equals("True")).ToList();

            List<int> unselectedIndexes = new List<int>();
            List<int> selectedIndexes = new List<int>();

            unselectedIndexes = unselectedProducts.Select(row => Int32.Parse(row.Cells["ProductId"].Value.ToString())).ToList();
            selectedIndexes = selectedProducts.Select(row => Int32.Parse(row.Cells["ProductId"].Value.ToString())).ToList();

            List <T_PRODUCT_ORDER> poProducts = entities.T_PRODUCT_ORDER.Where(po => po.P_O_ORDER_ID == orderId && unselectedIndexes.Contains(po.P_O_PRODUCT_ID)).ToList();
            List<T_PRODUCT_ORDER> selectedPoProducts = entities.T_PRODUCT_ORDER.Where(po => po.P_O_ORDER_ID == orderId && selectedIndexes.Contains(po.P_O_PRODUCT_ID)).ToList();
            foreach (T_PRODUCT_ORDER po in poProducts)
            {
                po.P_O_STATUS = false;
            }
            
            foreach (T_PRODUCT_ORDER po in selectedPoProducts)
            {
                po.T_PRODUCT.P_QUANTITY -= po.P_O_QUANTITY;
            }
            entities.SaveChanges();
            MessageBox.Show("Invoice has been created");
            orderForm.Dispose();
            orderForm = new OrderForm();
            orderForm.Show();
            this.Dispose();
        }
    }
}
