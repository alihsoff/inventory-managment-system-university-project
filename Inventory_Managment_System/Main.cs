using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Globalization;
using Inventory_Managment_System.Config;
using Inventory_Managment_System.Util;

namespace Inventory_Managment_System
{
    public partial class Main : Form
    {
        IMSEntities entities = new IMSEntities();
        public static CurrencyResponse currencyResponse;
        public String imageFileLocation = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\img\\";
        public Main()
        {
            loadCurrency();
            InitializeComponent();
            loadFileds();
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public class CurrencyResponse {
            public Boolean success { get; set; }
            public DateTime date { get; set; }
            public Rate rates { get; set; }
        }

        public class Rate
        {
            public Decimal USD { get; set; }
            public Decimal TRY { get; set; }
            public Decimal RUB { get; set; }
            public Decimal AZN { get; set; }
        }

        private async void loadCurrency()
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://data.fixer.io/api/");
                HttpResponseMessage httpResponse = await client.GetAsync("latest?access_key=87707c193c3190cb14fab3ab016ca127&symbols=USD,TRY,RUB,AZN&base=EUR&format=1");
                var result = await httpResponse.Content.ReadAsStringAsync();
                currencyResponse = new JavaScriptSerializer().Deserialize<CurrencyResponse>(result);
                lbl_currency.Text = "1 USD - " + CurrencyConverter.toAzn(currencyResponse.rates.AZN, currencyResponse.rates.USD) + " AZN" + System.Environment.NewLine;
                lbl_currency.Text += "1 EUR - " + CurrencyConverter.toAzn(currencyResponse.rates.AZN, 1) + " AZN" + System.Environment.NewLine;
                lbl_currency.Text += "1 RUB - " + CurrencyConverter.toAzn(currencyResponse.rates.AZN, currencyResponse.rates.RUB) + " AZN" + System.Environment.NewLine;
                lbl_currency.Text += "1 TRY - " + CurrencyConverter.toAzn(currencyResponse.rates.AZN, currencyResponse.rates.TRY) + " AZN" + System.Environment.NewLine;
            } catch(HttpRequestException 
            e)
            {
                lbl_currency.Text = "Check Your Internet";
            }

        }
        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUsersForm editUsersForm = new EditUsersForm();
            editUsersForm.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
        }

        private void ordersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateOrderForm createOrderForm = new CreateOrderForm();
            createOrderForm.Show();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.Show();
        }

        private void loadFileds()
        {
            lbl_fullName.Text = ConfigUser.configUser.User.U_FULL_NAME;
            pb_userImage.Image = Image.FromFile(imageFileLocation+ ConfigUser.configUser.User.U_IMAGE);
            lbl_companyName.Text = ConfigUser.configUser.User.U_COMPANY_NAME;
            lbl_userCount.Text = entities.T_USER.ToList().Count().ToString();
            lbl_productCount.Text = entities.T_PRODUCT.ToList().Count().ToString();
            lbl_invoiceCount.Text = entities.T_INVOICE.ToList().Count().ToString();
            GV_highest.DataSource = entities.V_TopSoldProducts.ToList();
            GV_latest.DataSource = entities.V_LatestSoldProducts.ToList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Main main = new Main();
            main.ShowDialog();
        }


        private void invoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoiceForm invoice = new InvoiceForm();
            invoice.ShowDialog();

        }

        private void createInvoiceStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateProfilForm updateProfilForm = new UpdateProfilForm();
            updateProfilForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConfigUser.configUser = null;
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Dispose();
        }
    }
}
