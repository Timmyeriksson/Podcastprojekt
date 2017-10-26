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
using System.Diagnostics;
using System.Threading;

namespace Presentation
{
    public partial class MainWindow : Form
    {
        Category cat = new Category();
        Feed feed = new Feed();
        Podcast pod = new Podcast();
        Episodes episode = new Episodes();
        Edit edit = new Edit();

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

                foreach (string pod in podArray)
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

            if (Validation.tfNotEmpty(txtBox_new_pod, "Podcast name ") && Validation.tfNotEmpty(txtBox_url, "URL ") && Validation.categoryBoxNotEmpty(cb_category) && Validation.intervalBoxNotEmpty(cb_interval, lb_podcast))
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
            clb_episodes.Items.Clear();
            fillPodcastList(lb_category.Text, lb_podcast);
        }

        private void lb_podcast_MouseClick(object sender, MouseEventArgs e)
        {
            if (lb_podcast.SelectedItem != null)
            {
                clb_episodes.Items.Clear();
                var category = lb_category.SelectedItem.ToString();
                var prePath = lb_podcast.SelectedItem.ToString();
                episode.getEpisodes(category, prePath, clb_episodes);
            }

        }

        private void btn_play_podcast_Click(object sender, EventArgs e)
        {

            var selected = clb_episodes.SelectedItem.ToString();
            var url = episode.getUrl(selected);

            Process.Start(url);
        }

        private void clb_episodes_MouseClick_1(object sender, MouseEventArgs e)
        {
            richtb_description.Clear();
            var name = clb_episodes.SelectedItem.ToString();
            episode.getDescription(name, richtb_description);
        }
        

        private void btn_delete_podcast_MouseClick(object sender, MouseEventArgs e)
        {
            var category = lb_category.SelectedItem.ToString();
            var name = lb_podcast.SelectedItem.ToString();

            feed.Remove(category, name);
            lb_podcast.Items.Clear();

            fillPodcastList(lb_category.Text, lb_podcast);

        }


        private async void btn_edit_category_Click(object sender, EventArgs e)
        {
            await edit.EditCategory(lb_category, txtBox_edit_category);
            lb_category.Items.Clear();
            cb_category.Items.Clear();
            FillCategoryList();

        }

        private void btn_edit_podcast_name_Click(object sender, EventArgs e)
        {
            edit.EditPod(lb_category, lb_podcast, txtBox_new_pod);
            lb_category.Items.Clear();
            cb_category.Items.Clear();
            lb_podcast.Items.Clear();
            clb_episodes.Items.Clear();
            FillCategoryList();
        }


        private void btn_edit_pod_location_Click(object sender, EventArgs e)
        {
            edit.EditLocation(lb_category, lb_podcast, cb_category);
            lb_category.Items.Clear();
            cb_category.Items.Clear();
            lb_podcast.Items.Clear();
            clb_episodes.Items.Clear();
            FillCategoryList();
        }

        private void btn_edit_podcast_url_Click(object sender, EventArgs e)
        {



            lb_category.Items.Clear();
            cb_category.Items.Clear();
            lb_podcast.Items.Clear();
            clb_episodes.Items.Clear();
            FillCategoryList();
        }
    }
}
