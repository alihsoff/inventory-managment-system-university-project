using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System.Util
{
    class FileUtil
    {
        public static String imageFileLocation = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\img\\";

        public static void fileUpload(String filePath, String imgName)
        {
            File.Copy(filePath, imageFileLocation + imgName);
        }

        public static void deleteFile(String filePath)
        {
            File.Delete(imageFileLocation + filePath);
        }

    }
}
