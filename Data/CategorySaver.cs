using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Data
{
    public class CategorySaver
    {
        public bool newFolder(string category)
        {
            try
            {
                string folderName = category;

                Directory.CreateDirectory(folderName);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}

