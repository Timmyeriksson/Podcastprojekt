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

        public static bool checkValidURL(string url)
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
        public static bool intervalBoxNotEmpty(ComboBox cb, ListBox list)
        {
            if (cb.Text == "")
            {
                MessageBox.Show("Please choose an update interval.");
                cb.Focus();
                return false;
            }
            else if (cb.SelectedItem == list.SelectedItem)
            {
                MessageBox.Show("The chosen update interval is already selected for the podcast");
                cb.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool listBoxNotEmpty(ListBox list)
        {
            if (list.Text == "")
            {
                MessageBox.Show("Please choose a podcast to delete from the podcast list");
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
