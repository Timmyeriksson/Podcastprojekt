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
            if (Validation.delete(lb_category))
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
                cb_interval.Items.Add("20");
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

            if (Validation.tfNotEmpty(txtBox_new_pod, "Podcast name ") && Validation.tfNotEmpty(txtBox_url, "URL ") && Validation.categoryBoxNotEmpty(cb_category) && Validation.categoryBoxNotEmpty(cb_interval))
            {
                var podName = txtBox_new_pod.Text;
                var url = txtBox_url.Text;
                var category = cb_category.SelectedItem.ToString();
                var interval = cb_interval.SelectedItem.ToString();


                pod.PodInfo(podName, url, category, interval);

                MessageBox.Show("Podcast Added");
            }

        }
        private void lb_category_MouseClick(object sender, MouseEventArgs e)
        {
            lb_podcast.Items.Clear();
            clb_episodes.Items.Clear();
            richtb_description.Clear();
            fillPodcastList(lb_category.Text, lb_podcast);
        }

        private void lb_podcast_MouseClick(object sender, MouseEventArgs e)
        {
            if (lb_podcast.SelectedItem != null)
            {
                clb_episodes.Items.Clear();
                richtb_description.Clear();
                var category = lb_category.SelectedItem.ToString();
                var prePath = lb_podcast.SelectedItem.ToString();
                episode.getEpisodes(category, prePath, clb_episodes);
                episode.setPlayed(category, prePath, clb_episodes);
            }

        }

        private void btn_play_podcast_Click(object sender, EventArgs e)
        {
            if (Validation.clbEmpty(clb_episodes))
            {
                string url;
                episode.getPodcastUrl(lb_category.SelectedItem.ToString(), lb_podcast.SelectedItem.ToString(), clb_episodes.SelectedItem.ToString(), out url);
                episode.setPlayed(lb_category.SelectedItem.ToString(), lb_podcast.SelectedItem.ToString(), clb_episodes);

                Process.Start(url);
            }

        }

        private void clb_episodes_MouseClick_1(object sender, MouseEventArgs e)
        {
            if(clb_episodes.SelectedItem != null)
            {
                richtb_description.Clear();
                {
                    var category = lb_category.SelectedItem.ToString();
                    var name = lb_podcast.SelectedItem.ToString();
                    var chosenEp = clb_episodes.SelectedItem.ToString();
                    episode.getDescription(category, name, chosenEp, richtb_description);
                }
            }
            
        }


        private void btn_delete_podcast_MouseClick(object sender, MouseEventArgs e)
        {
            if (Validation.delete(lb_podcast))
            {

                var confirm = MessageBox.Show("Do you want to delete this podcast?", "Delete Podcast", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    {
                        var category = lb_category.SelectedItem.ToString();
                        var name = lb_podcast.SelectedItem.ToString();

                        feed.Remove(category, name);
                        lb_podcast.Items.Clear();
                        clb_episodes.Items.Clear();

                        fillPodcastList(lb_category.Text, lb_podcast);

                        MessageBox.Show("Podcast deleted");
                    }
                }
            }


        }


        private async void btn_edit_category_Click(object sender, EventArgs e)
        {

            if (Validation.listBoxEmpty(lb_category) && Validation.tfNotEmpty(txtBox_edit_category, "Category name "))
            {
                var cat = lb_category.SelectedItem.ToString();
                var confirm = MessageBox.Show("Do you want to update the category: " + cat + "?", "Update category", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    await edit.EditCategory(lb_category, txtBox_edit_category);
                    lb_category.Items.Clear();
                    cb_category.Items.Clear();
                    FillCategoryList();
                    txtBox_edit_category.Clear();
                }
                else
                {
                    txtBox_edit_category.Clear();
                }
            }

        }

        private void btn_edit_podcast_name_Click(object sender, EventArgs e)
        {


            if (Validation.tfNotEmpty(txtBox_new_pod, "Podcast name ") && Validation.listBoxEmpty(lb_podcast))
            {
                var pod = lb_podcast.SelectedItem.ToString();
                var confirm = MessageBox.Show("Do you want to update " + pod + "?", "Update podcast", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {

                    edit.EditPod(lb_category, lb_podcast, txtBox_new_pod);
                    lb_category.Items.Clear();
                    cb_category.Items.Clear();
                    lb_podcast.Items.Clear();
                    clb_episodes.Items.Clear();
                    txtBox_new_pod.Clear();
                    FillCategoryList();
                }
            }


        }


        private void btn_edit_pod_location_Click(object sender, EventArgs e)
        {
            if (Validation.listBoxEmpty(lb_podcast) && Validation.categoryBoxNotEmpty(cb_category))
            {
                var pod = lb_podcast.SelectedItem.ToString();
                var cat = cb_category.SelectedItem.ToString();
                var confirm = MessageBox.Show("Do you want to update " + pod + " to the category: " + cat + "?", "Update podcast", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    edit.EditLocation(lb_category, lb_podcast, cb_category);

                    lb_category.Items.Clear();
                    cb_category.Items.Clear();
                    lb_podcast.Items.Clear();
                    clb_episodes.Items.Clear();
                    FillCategoryList();
                }
            }
        }

        private void btn_edit_podcast_url_Click(object sender, EventArgs e)
        {
            if (Validation.tfNotEmpty(txtBox_url, "The URL field ") && Validation.categoryBoxNotEmpty(cb_category) && Validation.intervalBoxNotEmpty(cb_interval) && Validation.listBoxEmpty(lb_category) && Validation.listBoxEmpty(lb_podcast) && Validation.validURL(txtBox_url.Text))
            {

                var category = lb_category.SelectedItem.ToString();
                var podName = lb_podcast.SelectedItem.ToString();
                var url = txtBox_url.Text;
                var cat = cb_category.SelectedItem.ToString();
                var interval = cb_interval.SelectedItem.ToString();


                feed.Remove(category, podName);
                pod.PodInfo(podName, url, cat, interval);

                lb_category.Items.Clear();
                cb_category.Items.Clear();
                lb_podcast.Items.Clear();
                clb_episodes.Items.Clear();
                FillCategoryList();

                MessageBox.Show("URL updated");
            }

        }



        private void btn_delete_podcast_Click(object sender, EventArgs e)
        {

        }
    }
}
