namespace Inventory_Managment_System
{
    partial class UserMain
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_currency = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_companyName = new System.Windows.Forms.Label();
            this.lbl_fullName = new System.Windows.Forms.Label();
            this.pb_userImage = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_orderCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userImage)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbl_companyName);
            this.panel1.Controls.Add(this.lbl_fullName);
            this.panel1.Controls.Add(this.pb_userImage);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 524);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.Controls.Add(this.lbl_currency);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(628, 302);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 222);
            this.panel2.TabIndex = 1;
            // 
            // lbl_currency
            // 
            this.lbl_currency.AutoSize = true;
            this.lbl_currency.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currency.Location = new System.Drawing.Point(29, 57);
            this.lbl_currency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_currency.Name = "lbl_currency";
            this.lbl_currency.Size = new System.Drawing.Size(83, 32);
            this.lbl_currency.TabIndex = 1;
            this.lbl_currency.Text = "loading...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily currency ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::Inventory_Managment_System.Properties.Resources.logout;
            this.button2.Location = new System.Drawing.Point(814, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 38);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.Image = global::Inventory_Managment_System.Properties.Resources.refresh;
            this.btn_refresh.Location = new System.Drawing.Point(744, 38);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(37, 38);
            this.btn_refresh.TabIndex = 22;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 21;
            this.button1.Text = "Edit Profil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_companyName
            // 
            this.lbl_companyName.AutoSize = true;
            this.lbl_companyName.Location = new System.Drawing.Point(156, 65);
            this.lbl_companyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_companyName.Name = "lbl_companyName";
            this.lbl_companyName.Size = new System.Drawing.Size(108, 17);
            this.lbl_companyName.TabIndex = 20;
            this.lbl_companyName.Text = "Company Name";
            // 
            // lbl_fullName
            // 
            this.lbl_fullName.AutoSize = true;
            this.lbl_fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_fullName.Location = new System.Drawing.Point(137, 28);
            this.lbl_fullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fullName.Name = "lbl_fullName";
            this.lbl_fullName.Size = new System.Drawing.Size(149, 25);
            this.lbl_fullName.TabIndex = 19;
            this.lbl_fullName.Text = "Name Surname";
            // 
            // pb_userImage
            // 
            this.pb_userImage.Image = global::Inventory_Managment_System.Properties.Resources.user;
            this.pb_userImage.Location = new System.Drawing.Point(23, 15);
            this.pb_userImage.Margin = new System.Windows.Forms.Padding(4);
            this.pb_userImage.Name = "pb_userImage";
            this.pb_userImage.Size = new System.Drawing.Size(107, 108);
            this.pb_userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_userImage.TabIndex = 18;
            this.pb_userImage.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Inventory_Managment_System.Properties.Resources.plus;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(305, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(234, 50);
            this.button3.TabIndex = 24;
            this.button3.Text = "CREATE ORDER";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SpringGreen;
            this.panel5.Controls.Add(this.lbl_orderCount);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(272, 359);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(267, 123);
            this.panel5.TabIndex = 25;
            // 
            // lbl_orderCount
            // 
            this.lbl_orderCount.AutoSize = true;
            this.lbl_orderCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_orderCount.ForeColor = System.Drawing.Color.Red;
            this.lbl_orderCount.Location = new System.Drawing.Point(111, 66);
            this.lbl_orderCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_orderCount.Name = "lbl_orderCount";
            this.lbl_orderCount.Size = new System.Drawing.Size(190, 38);
            this.lbl_orderCount.TabIndex = 6;
            this.lbl_orderCount.Text = "orderCount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(111, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "My Orders";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Inventory_Managment_System.Properties.Resources.order;
            this.pictureBox3.Location = new System.Drawing.Point(13, 20);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(89, 87);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 520);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserMain";
            this.Text = "UserMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_userImage)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_currency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_companyName;
        private System.Windows.Forms.Label lbl_fullName;
        private System.Windows.Forms.PictureBox pb_userImage;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_orderCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}