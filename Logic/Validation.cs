using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic
{
    public class Validation
    {

        public static bool tfNotEmpty(TextBox field, string label)
        {
            if (field.Text == "")
            {
                MessageBox.Show(label + "is a required field. Please enter a value before continuing.");
                field.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }





        public static bool listBoxEmpty(ListBox box)
        {

            if (box.Text == "")
            {
                MessageBox.Show("Please choose an item to update");
                box.Focus();
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool clbEmpty(CheckedListBox box)
        {

            if (box.Text == "")
            {
                MessageBox.Show("Please choose an episode to play");
                box.Focus();
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool validURL(string url)
        {
            try
            {
                var xml = "";
                using (var client = new System.Net.WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    xml = client.DownloadString(url);
                    return true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid URL.");
                return false;
            }
        }

        public static bool categoryBoxNotEmpty(ComboBox cb)
        {
            if (cb.Text == "")
            {
                MessageBox.Show("Please choose the new category");
                cb.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool intervalBoxNotEmpty(ComboBox cb)
        {
            if (cb.Text == "")
            {
                MessageBox.Show("An update interval is required");
                cb.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }



        public static bool delete(ListBox list)
        {
            if (list.Text == "")
            {
                MessageBox.Show("Please choose an item to delete");
                list.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
