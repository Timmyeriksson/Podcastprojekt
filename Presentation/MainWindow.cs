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
            fillIntervalList();
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
            if (Validation.tfNotEmpty(txtBox_new_category, "New category "))
            {
                lb_category.Items.Clear();
                cb_category.Items.Clear();
                var categoryName = txtBox_new_category.Text;
                cat.NewFolder(categoryName);
                FillCategoryList();
            }
        }

        internal void FillCategoryList()
        {
            try
            {
                string[] catArray = Directory.GetDirectories(Directory.GetCurrentDirectory());

                foreach (string cat in catArray)
                {
                    string[] trimmedCat = cat.Split('\\');
                    int length = trimmedCat.Length - 1;
                    string fixedCat = trimmedCat[length];
                    lb_category.Items.Add(fixedCat);
                    cb_category.Items.Add(fixedCat);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        internal void fillPodcastList(string category, ListBox list)
        {
            try
            {
                string[] podArray = Directory.GetFiles(category);

                foreach(string pod in podArray)
                {
                    string[] splitPod = pod.Split('\\');
                    string trim = splitPod[splitPod.Length - 1];
                    string[] trimmedArray = trim.Split('.');
                    string fixedPod = trimmedArray[0];
                    lb_podcast.Items.Add(fixedPod);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void fillIntervalList()
        {
            try
            {
                cb_interval.Items.Add("2000");
                cb_interval.Items.Add("5000");
                cb_interval.Items.Add("10000");
                cb_interval.Items.Add("300000");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        private void btn_add_podcast_Click(object sender, EventArgs e)
        {
            if(Validation.tfNotEmpty(txtBox_new_pod, "Podcast name ") && Validation.tfNotEmpty(txtBox_url, "URL ") && Validation.categoryBoxNotEmpty(cb_category, lb_category) && Validation.intervalBoxNotEmpty(cb_interval, lb_podcast))
            {             
                var podName = txtBox_new_pod.Text;
                var url = txtBox_url.Text;
                var category = cb_category.SelectedItem.ToString();
                var interval = cb_interval.SelectedItem.ToString();
                pod.PodInfo(podName, url, category, interval);
            }            
        }

        private void lb_category_MouseClick(object sender, MouseEventArgs e)
        {
            lb_podcast.Items.Clear();
            fillPodcastList(lb_category.Text, lb_podcast);
        }
    }
}
