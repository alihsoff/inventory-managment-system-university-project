using Inventory_Managment_System.Config;
using Inventory_Managment_System.Util;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class InvoiceForm : Form
    {
        IMSEntities entities = new IMSEntities();
        public InvoiceForm()
        {
            InitializeComponent();
            loadData();
        }


        internal void loadData()
        {
            dataGridView1.DataSource = entities.V_INVOICE.ToList();

                DataGridViewButtonColumn viewProducts = new DataGridViewButtonColumn();
                viewProducts.Name = "viewProducts";
                viewProducts.HeaderText = "Products";
                viewProducts.Text = "Products";
                viewProducts.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(viewProducts);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Columns[e.ColumnIndex].Name == "viewProducts")
            {
                int orderId = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["OrderId"].Value.ToString());
                String totalAmount = dataGridView1.Rows[e.RowIndex].Cells["TotalAmount"].Value.ToString();
                CreateAndViewInvoice createInvoice = new CreateAndViewInvoice(orderId, totalAmount);
                createInvoice.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            dataGridView1.Columns["viewProducts"].Visible = false;
            dataGridView1.ClearSelection();
            Bitmap bitmap = new Bitmap(dataGridView1.Width+15, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new System.Drawing.Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(bitmap, 0, 0);
            dataGridView1.Columns["viewProducts"].Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sendXlsx();
        }

        private void sendXlsx()
        {

            if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook wbook;
                Microsoft.Office.Interop.Excel.Worksheet wsheet;
                xcelApp.Application.Workbooks.Add(Type.Missing);

                wbook = xcelApp.Workbooks.Add(true);
                wsheet = (Worksheet)wbook.ActiveSheet;

                for (int i = 2; i < dataGridView1.Columns.Count + 1; i++)
                {
                    wsheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 1; j < dataGridView1.Columns.Count; j++)
                    {
                        wsheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                String fileName = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\xlsx\\tempExcel"+ new Random().Next(1000,9999);
                wbook.SaveAs(fileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing,
                false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                wbook.Close(Type.Missing, fileName, Type.Missing);

                Attachment attachment = new Attachment(fileName+".xlsx");
                MailUtil.sendMail(ConfigUser.configUser.User.U_EMAIL, "Report", "Report Attached!", attachment);
                MessageBox.Show("Report has been sent to your email");
            }
        }
    }
}
