using Inventory_Managment_System.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class ProductForm : Form
    {
        public IMSEntities entities = new IMSEntities();
        bool isNewFile = false;
        public ProductForm()
        {
            InitializeComponent();
            cb_currency.SelectedIndex = 0;
            dataGridView1.DataSource = entities.V_PRODUCT.ToList();
            loadComboBox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
                dataGridView1.DataSource = entities.V_PRODUCT.Where(u => u.Name.ToLower().Contains(textBox1.Text.ToString())).ToList();
            else
                dataGridView1.DataSource = entities.V_PRODUCT.ToList();
        }


        private void btn_browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                setImage(openFileDialog1.FileName);
                isNewFile = true;
            }

        }

        private void setImage(String fileName)
        {
            pb_image.Image = Image.FromFile(fileName);
            pb_image.ImageLocation = fileName;
        }

        private void loadComboBox()
        {
            foreach (T_CATEGORY category in entities.T_CATEGORY)
            {
                cb_category.Items.Add(new ComboboxValue(category.C_ID, category.C_NAME));
            }
            cb_category.SelectedIndex = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_measure.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cb_category.SelectedIndex = cb_category.Items.IndexOf(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            cb_currency.SelectedIndex = cb_currency.Items.IndexOf(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            txt_price.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_quantity.Value = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            setImage(FileUtil.imageFileLocation + dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
            btn_add.Enabled = false;
            btn_edit.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            String imgName = pb_image.ImageLocation.Substring(pb_image.ImageLocation.LastIndexOf("\\"));
            T_PRODUCT product = new T_PRODUCT();
            product.P_NAME = txt_name.Text;
            product.P_MEASURE = txt_measure.Text;
            product.P_C_ID = ((ComboboxValue)cb_category.SelectedItem).Id;
            product.P_CURRENCY = cb_currency.SelectedItem.ToString();
            product.P_PRICE = Decimal.Parse(txt_price.Text);
            product.P_QUANTITY = Int32.Parse(txt_quantity.Value.ToString());
            product.P_IMAGE = imgName;
            FileUtil.fileUpload(pb_image.ImageLocation, imgName);
            entities.T_PRODUCT.Add(product);
            entities.SaveChanges();
            MessageBox.Show("Product has been added");
            resetFields();

        }

        private void resetFields()
        {
            txt_id.Text = null;
            txt_name.Text = null;
            txt_measure.Text = null;
            cb_category.SelectedIndex = 0;
            cb_currency.SelectedIndex = 0;
            txt_price.Text = null;
            txt_quantity.Value = 0;
            pb_image.Image = null;
            isNewFile = false;
            entities = new IMSEntities();
            dataGridView1.DataSource = entities.V_PRODUCT.ToList();
            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            T_PRODUCT product = entities.T_PRODUCT.Find(Int32.Parse(txt_id.Text));

            product.P_NAME = txt_name.Text;
            product.P_MEASURE = txt_measure.Text;
            product.P_C_ID = ((ComboboxValue)cb_category.SelectedItem).Id;
            product.P_CURRENCY = cb_currency.SelectedItem.ToString();
            product.P_PRICE = Decimal.Parse(txt_price.Text);
            product.P_QUANTITY = Int32.Parse(txt_quantity.Value.ToString());
            if (isNewFile)
            {
                String imgName = pb_image.ImageLocation.Substring(pb_image.ImageLocation.LastIndexOf("\\"));
                product.P_IMAGE = imgName;
                FileUtil.fileUpload(pb_image.ImageLocation, imgName);
            }
            entities.SaveChanges();
            MessageBox.Show("Product has been updated");
            resetFields();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete?",
    "Sure?",
    MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                T_PRODUCT product = entities.T_PRODUCT.Find(Int32.Parse(txt_id.Text));
                FileUtil.deleteFile(product.P_IMAGE);
                entities.T_PRODUCT.Remove(product);
                entities.SaveChanges();
                MessageBox.Show("Product has been deleted");
                resetFields();
            }
        }
    }
}
