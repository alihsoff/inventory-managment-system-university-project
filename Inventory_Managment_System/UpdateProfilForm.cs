using Inventory_Managment_System.Config;
using Inventory_Managment_System.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class UpdateProfilForm : Form
    {
        bool isNewFile = false;
        public IMSEntities entities = new IMSEntities();
        public UpdateProfilForm()
        {
            InitializeComponent();
            loadData();
        }

        internal void loadData() {
            txt_email.Text = ConfigUser.configUser.User.U_EMAIL;
            txt_fullName.Text = ConfigUser.configUser.User.U_FULL_NAME;
            setImage(FileUtil.imageFileLocation + ConfigUser.configUser.User.U_IMAGE);
        }

        private void setImage(String fileName)
        {
            pb_image.Image = Image.FromFile(fileName);
            pb_image.ImageLocation = fileName;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            T_USER user = entities.T_USER.Find(ConfigUser.configUser.User.U_ID);
            user.U_EMAIL = txt_email.Text;
            user.U_FULL_NAME = txt_fullName.Text;
            if (!String.IsNullOrEmpty(txt_password.Text))
            {
                user.U_PASSWORD = txt_password.Text;
            }
            if (isNewFile)
            {
                String imgName = pb_image.ImageLocation.Substring(pb_image.ImageLocation.LastIndexOf("\\"));
                user.U_IMAGE = imgName;
                FileUtil.fileUpload(pb_image.ImageLocation, imgName);
            }
            ConfigUser.configUser.User = user;
            entities.SaveChanges();
            loadData();
            MessageBox.Show("User has been updated");
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                setImage(openFileDialog1.FileName);
                isNewFile = true;
            }
        }
    }
}
