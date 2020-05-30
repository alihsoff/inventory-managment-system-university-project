using Inventory_Managment_System.Config;
using Inventory_Managment_System.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class UserMain : Form
    {
        public String imageFileLocation = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\img\\";
        IMSEntities entities = new IMSEntities();
        public UserMain()
        {
            InitializeComponent();
            loadFileds();
            loadCurrency();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateOrderForm createOrderForm = new CreateOrderForm();
            createOrderForm.Show();
        }

        private void loadFileds()
        {
            lbl_fullName.Text = ConfigUser.configUser.User.U_FULL_NAME;
            pb_userImage.Image = Image.FromFile(imageFileLocation + ConfigUser.configUser.User.U_IMAGE);
            lbl_companyName.Text = ConfigUser.configUser.User.U_COMPANY_NAME;
            lbl_orderCount.Text = entities.T_ORDER.Where(o => o.O_COMPANY_NAME == ConfigUser.configUser.User.U_COMPANY_NAME).ToList().Count().ToString();

        }

        private async void loadCurrency()
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://data.fixer.io/api/");
                HttpResponseMessage httpResponse = await client.GetAsync("latest?access_key=87707c193c3190cb14fab3ab016ca127&symbols=USD,TRY,RUB,AZN&base=EUR&format=1");
                var result = await httpResponse.Content.ReadAsStringAsync();
                CurrencyResponse currencyResponse = new JavaScriptSerializer().Deserialize<CurrencyResponse>(result);
                lbl_currency.Text = "1 USD - " + CurrencyConverter.toAzn(currencyResponse.rates.AZN, currencyResponse.rates.USD) + " AZN" + System.Environment.NewLine;
                lbl_currency.Text += "1 EUR - " + CurrencyConverter.toAzn(currencyResponse.rates.AZN, 1) + " AZN" + System.Environment.NewLine;
                lbl_currency.Text += "1 RUB - " + CurrencyConverter.toAzn(currencyResponse.rates.AZN, currencyResponse.rates.RUB) + " AZN" + System.Environment.NewLine;
                lbl_currency.Text += "1 TRY - " + CurrencyConverter.toAzn(currencyResponse.rates.AZN, currencyResponse.rates.TRY) + " AZN" + System.Environment.NewLine;
            }
            catch (HttpRequestException
          e)
            {
                lbl_currency.Text = "Check Your Internet";
            }

        }

        public class CurrencyResponse
        {
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            this.Dispose();
            UserMain main = new UserMain();
            main.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConfigUser.configUser = null;
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateProfilForm updateProfilForm = new UpdateProfilForm();
            updateProfilForm.Show();
        }
    }
}
