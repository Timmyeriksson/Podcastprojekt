using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class Edit
    {
        public void EditCategory(ListBox list, TextBox text)
        {
            var category = list.SelectedItem.ToString();
            string categoryName = Directory.GetCurrentDirectory() + @"\" + category;

            string newCat = text.Text;
            string newPath = Directory.GetCurrentDirectory() + @"\" + newCat;

            Directory.Move(categoryName, newPath);
        }

        public void EditPod(ListBox cat, ListBox file, TextBox text)
        {

            var category = cat.SelectedItem.ToString();
            var fileName = file.SelectedItem.ToString();
            string currentName = Directory.GetCurrentDirectory() + @"\" + category + @"\" + fileName + ".xml";

            string newName = text.Text;
            string newPath = Directory.GetCurrentDirectory() + @"\" + category +  @"\" + newName + ".xml";

            Directory.Move(currentName, newPath);
        }

        public void EditLocation(ListBox cat, ListBox pod, ComboBox newCat)
        {
            var category = cat.SelectedItem.ToString();
            var fileName = pod.SelectedItem.ToString();
            string currentName = Directory.GetCurrentDirectory() + @"\" + category + @"\" + fileName + ".xml";

            /*Ny kategori*/ var file = newCat.SelectedItem.ToString();
            string newPath = Directory.GetCurrentDirectory() + @"\" + file + @"\" + fileName + ".xml";

            Directory.Move(currentName, newPath);
        }
    }
}
