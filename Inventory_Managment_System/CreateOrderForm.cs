using Inventory_Managment_System.Config;
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
    public partial class CreateOrderForm : Form
    {
        IMSEntities entities = new IMSEntities();
        public List<T_PRODUCT> products = new List<T_PRODUCT>();
        public List<int> quantites = new List<int>();
        public T_PRODUCT selectedProduct;
        decimal totalAmount = 0;
        public CreateOrderForm()
        {
            InitializeComponent();
            loadComboBox();
        }

        private void btn_selectProduct_Click(object sender, EventArgs e)
        {
            SelectProductForm selectProductForm = new SelectProductForm(this);
            selectProductForm.Show();
        }

        private void loadComboBox()
        {
            foreach (String company in entities.T_USER.Select(u => u.U_COMPANY_NAME).ToList())
            {
                cb_company.Items.Add(company);
            }
            if(ConfigUser.configUser.User.U_ROLE != "ADMIN")
            {
                cb_company.SelectedIndex = cb_company.Items.IndexOf(ConfigUser.configUser.User.U_COMPANY_NAME);
                cb_company.Enabled = false;
            }
            else
            cb_company.SelectedIndex = 0;
        }
        int i = 0;
        private void btn_add_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(selectedProduct.P_NAME);
            listView1.Items[i].SubItems.Add(nd_quantity.Value.ToString());
            i++;

            decimal price = selectedProduct.P_PRICE;
            if (!selectedProduct.P_CURRENCY.Equals("AZN"))
                price = CurrencyConverter.toAzn(selectedProduct.P_CURRENCY, selectedProduct.P_PRICE);

            totalAmount += Math.Round((price * nd_quantity.Value), 4);
            products.Add(selectedProduct);
            quantites.Add(Int32.Parse(nd_quantity.Value.ToString()));
            lbl_productName.Text = null;
            nd_quantity.Value = 1;
            lbl_totalAmount.Text = totalAmount.ToString()+" AZN";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            T_ORDER order = new T_ORDER();
            order.O_COMPANY_NAME = cb_company.SelectedItem.ToString();
            order.O_CREATER_NAME = ConfigUser.configUser.User.U_FULL_NAME;
            order.O_TOTAL_AMOUNT = totalAmount;
            order.O_STATUS = false;
            order.O_CREATED_AT = DateTime.Parse(DateTime.Now.ToString("dd.MM.yyyy"));
            entities.T_ORDER.Add(order);
            entities.SaveChanges();

            for(int i=0; i<products.Count(); i++) {
                T_PRODUCT product = products[i];
                int quantity = quantites[i];
                T_PRODUCT_ORDER productOrder = new T_PRODUCT_ORDER();
                productOrder.P_O_ORDER_ID = order.O_ID;
                productOrder.P_O_PRODUCT_ID = product.P_ID;
                productOrder.P_O_QUANTITY = quantity;
                productOrder.P_O_TOTAL_AMOUNT = (quantity * product.P_PRICE);
                productOrder.P_O_STATUS = true;
                entities.T_PRODUCT_ORDER.Add(productOrder);
            }
            entities.SaveChanges();

            MessageBox.Show("Order has been created");
            listView1.Items.Clear();
            i = 0;
            totalAmount = 0;;
            lbl_totalAmount.Text = "";
            products.Clear();
            quantites.Clear();
        }
    }
}
