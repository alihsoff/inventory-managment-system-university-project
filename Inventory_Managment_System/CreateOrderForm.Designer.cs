namespace Inventory_Managment_System
{
    partial class CreateOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.oQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_company = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nd_quantity = new System.Windows.Forms.NumericUpDown();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.btn_selectProduct = new System.Windows.Forms.Button();
            this.lbl_totalAmount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nd_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lbl_totalAmount);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_company);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.nd_quantity);
            this.panel1.Controls.Add(this.lbl_productName);
            this.panel1.Controls.Add(this.btn_selectProduct);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 547);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pName,
            this.oQuantity});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(420, 109);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(334, 290);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // pName
            // 
            this.pName.Text = "Product Name";
            this.pName.Width = 130;
            // 
            // oQuantity
            // 
            this.oQuantity.Text = "Order Quantity";
            this.oQuantity.Width = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Total Amount:";
            // 
            // cb_company
            // 
            this.cb_company.Cursor = System.Windows.Forms.Cursors.Default;
            this.cb_company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_company.FormattingEnabled = true;
            this.cb_company.Location = new System.Drawing.Point(191, 375);
            this.cb_company.Margin = new System.Windows.Forms.Padding(4);
            this.cb_company.Name = "cb_company";
            this.cb_company.Size = new System.Drawing.Size(140, 24);
            this.cb_company.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(104, 375);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "Company:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(114, 183);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 18);
            this.label10.TabIndex = 25;
            this.label10.Text = "Quantity:";
            // 
            // nd_quantity
            // 
            this.nd_quantity.Location = new System.Drawing.Point(195, 183);
            this.nd_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.nd_quantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nd_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nd_quantity.Name = "nd_quantity";
            this.nd_quantity.Size = new System.Drawing.Size(83, 22);
            this.nd_quantity.TabIndex = 24;
            this.nd_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_productName.Location = new System.Drawing.Point(188, 141);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(0, 17);
            this.lbl_productName.TabIndex = 1;
            // 
            // btn_selectProduct
            // 
            this.btn_selectProduct.Location = new System.Drawing.Point(153, 109);
            this.btn_selectProduct.Name = "btn_selectProduct";
            this.btn_selectProduct.Size = new System.Drawing.Size(125, 29);
            this.btn_selectProduct.TabIndex = 0;
            this.btn_selectProduct.Text = "Select Product";
            this.btn_selectProduct.UseVisualStyleBackColor = true;
            this.btn_selectProduct.Click += new System.EventHandler(this.btn_selectProduct_Click);
            // 
            // lbl_totalAmount
            // 
            this.lbl_totalAmount.AutoSize = true;
            this.lbl_totalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_totalAmount.Location = new System.Drawing.Point(186, 320);
            this.lbl_totalAmount.Name = "lbl_totalAmount";
            this.lbl_totalAmount.Size = new System.Drawing.Size(0, 17);
            this.lbl_totalAmount.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Image = global::Inventory_Managment_System.Properties.Resources.plus;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(286, 462);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 46);
            this.button1.TabIndex = 28;
            this.button1.Text = "Create Order";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_add
            // 
            this.btn_add.Image = global::Inventory_Managment_System.Properties.Resources.shopping_cart;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(153, 235);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(125, 40);
            this.btn_add.TabIndex = 27;
            this.btn_add.Text = "Add to Cart";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 542);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CreateOrderForm";
            this.Text = "AddOrderForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nd_quantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_selectProduct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_company;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader pName;
        private System.Windows.Forms.ColumnHeader oQuantity;
        internal System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label lbl_totalAmount;
        internal System.Windows.Forms.NumericUpDown nd_quantity;
    }
}