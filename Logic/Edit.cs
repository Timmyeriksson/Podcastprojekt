using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Logic
{
    public class Edit
    {
        public Task EditCategory(string category, string newCat)
        {

            string categoryName = Directory.GetCurrentDirectory() + @"\" + category;
            string newPath = Directory.GetCurrentDirectory() + @"\" + newCat;

            return Task.Factory.StartNew(() =>
            {
                Directory.Move(categoryName, newPath);
            });

        }

        public void EditPod(string category, string pod, string newName)
        {
            try
            {
                //Current
                string currentName = Directory.GetCurrentDirectory() + @"\" + category + @"\" + pod + ".xml";

                //New
                string newPath = Directory.GetCurrentDirectory() + @"\" + category + @"\" + newName + ".xml";

                Directory.Move(currentName, newPath);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void EditLocation(string category, string fileName, string file)
        {
            try
            {
                //Current location

                string currentName = Directory.GetCurrentDirectory() + @"\" + category + @"\" + fileName + ".xml";

                // New location

                string newPath = Directory.GetCurrentDirectory() + @"\" + file + @"\" + fileName + ".xml";

                Directory.Move(currentName, newPath);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
