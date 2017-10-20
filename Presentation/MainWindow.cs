using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Logic;
using System.IO;

namespace Presentation
{
    public partial class MainWindow : Form
    {
        Category cat = new Category();
        Feed feed = new Feed();
        Podcast pod = new Podcast();

        public MainWindow()
        {
            InitializeComponent();
            FillCategoryList();
        }

        private void btn_delete_category_Click(object sender, EventArgs e)
        {
            if (Validation.listBoxNotEmpty(lb_category))
            {
                var confirm = MessageBox.Show("Do you want to delete the category?", "Delete Category", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    var folderToDelete = lb_category.SelectedItem.ToString();
                    feed.Remove(folderToDelete);
                    lb_category.Items.Clear();
                    cb_category.Items.Clear();
                    FillCategoryList();
                }
            }
        }

        private void btn_add_category_Click(object sender, EventArgs e)
        {
            if (Validation.tfNotEmpty(txtBox_new_category, "Category field "))
            {
                lb_category.Items.Clear();
                cb_category.Items.Clear();
                var categoryName = txtBox_new_category.Text;
                cat.NewFolder(categoryName);
                FillCategoryList();
            }
        }

        public void FillCategoryList()
        {
            string[] catArray = Directory.GetDirectories(Directory.GetCurrentDirectory() + @"\categories");

            foreach (String cat in catArray)
            {
                string[] trimmedCat = cat.Split('\\');
                int length = trimmedCat.Length - 1;
                string fixedCat = trimmedCat[length];
                lb_category.Items.Add(fixedCat);
                cb_category.Items.Add(fixedCat);
            }
        }

        
        private void btn_add_podcast_Click(object sender, EventArgs e)
        { 
            var podName = txtBox_new_pod.Text;
            var url = txtBox_url.Text;

            var category = cb_category.SelectedItem.ToString();
            var interval = txtBox_interval.Text;
            int number;
            bool result = Int32.TryParse(interval, out number);
            if (result)
            {
                pod.PodInfo(podName, url, category, number);
            }
            
        } 
    }
}
