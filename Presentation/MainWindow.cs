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
            try
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
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btn_add_category_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
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
                MessageBox.Show(e.Message);
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
                MessageBox.Show(e.Message);
            }
        }

        public void fillIntervalList()
        {
            try
            {
                cb_interval.Items.Add("1");
                cb_interval.Items.Add("2");
                cb_interval.Items.Add("3");
                cb_interval.Items.Add("4");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void btn_add_podcast_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.tfNotEmpty(txtBox_new_pod, "Podcast name ") && Validation.tfNotEmpty(txtBox_url, "URL ") && Validation.categoryBoxNotEmpty(cb_category) && Validation.intervalBoxNotEmpty(cb_interval))
                {
                    var podName = txtBox_new_pod.Text;
                    var url = txtBox_url.Text;
                    var category = cb_category.SelectedItem.ToString();
                    var interval = cb_interval.SelectedItem.ToString();
                    var remadeInterval = 0;
                    if (interval == "1")
                    {
                        remadeInterval = 60 * 60 * 1000;
                        pod.PodInfo(podName, url, category, remadeInterval);
                    }
                    else if (interval == "2")
                    {
                        remadeInterval = 2 * 60 * 60 * 1000;
                        pod.PodInfo(podName, url, category, remadeInterval);
                    }
                    else if (interval == "3")
                    {
                        remadeInterval = 3 * 60 * 60 * 1000;
                        pod.PodInfo(podName, url, category, remadeInterval);
                    }
                    else if (interval == "4")
                    {
                        remadeInterval = 4 * 60 * 60 * 1000;
                        pod.PodInfo(podName, url, category, remadeInterval);
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }
        private void lb_category_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                lb_podcast.Items.Clear();
                clb_episodes.Items.Clear();
                richtb_description.Clear();
                fillPodcastList(lb_category.Text, lb_podcast);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void lb_podcast_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (lb_podcast.SelectedItem != null)
                {
                    clb_episodes.Items.Clear();
                    richtb_description.Clear();
                    var category = lb_category.SelectedItem.ToString();
                    var prePath = lb_podcast.SelectedItem.ToString();
                    episode.getEpisodes(category, prePath);
                    var list = episode.getepList();
                    foreach (var item in list)
                    {
                            clb_episodes.Items.Add(item.Title.ToString());
                    }
                    SetPlayed();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btn_play_podcast_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.clbEmpty(clb_episodes))
                {
                    string url;
                    episode.getPodcastUrl(lb_category.SelectedItem.ToString(), lb_podcast.SelectedItem.ToString(), clb_episodes.SelectedItem.ToString(), out url);
                    SetPlayed();

                    Process.Start(url);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        public void SetPlayed()
        {
            try
            {
                var category = lb_category.SelectedItem.ToString();
                var name = lb_podcast.SelectedItem.ToString();
                string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + name + @".xml";

                XmlDocument xdcDocument = new XmlDocument();
                xdcDocument.Load(path);

                int i = 0;

                foreach (XmlNode xndNode in xdcDocument.DocumentElement.SelectNodes("item"))
                {
                    var title = xndNode.SelectSingleNode("title");
                    var status = xndNode.SelectSingleNode("status");

                    if (status.InnerText.Equals("Listened to."))
                    {
                        clb_episodes.SetItemChecked(i, true);
                    }
                    i++;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void clb_episodes_MouseClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                if (clb_episodes.SelectedItem != null)
                {
                    richtb_description.Clear();
                    {
                        var category = lb_category.SelectedItem.ToString();
                        var name = lb_podcast.SelectedItem.ToString();
                        var chosenEp = clb_episodes.SelectedItem.ToString();
                        var list = episode.getepList();
                        foreach (var item in list)
                        {
                            if (item.Title == chosenEp)
                            {
                                var desci = item.Description;
                                if (desci != null)
                                {
                                    richtb_description.Text = desci;
                                }
                                else
                                {
                                    richtb_description.Text = "No description is available.";
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }


        private void btn_delete_podcast_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Validation.delete(lb_podcast))
                {

                    var confirm = MessageBox.Show("Do you want to delete this podcast?", "Delete Podcast", MessageBoxButtons.YesNo);

                    if (confirm == DialogResult.Yes)
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
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
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
                    var pod = txtBox_edit_category.Text;
                    await edit.EditCategory(cat, pod);
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
            try
            {
                if (Validation.tfNotEmpty(txtBox_new_pod, "Podcast name ") && Validation.listBoxEmpty(lb_podcast))
                {
                    var pod = lb_podcast.SelectedItem.ToString();
                    var confirm = MessageBox.Show("Do you want to update " + pod + "?", "Update podcast", MessageBoxButtons.YesNo);

                    if (confirm == DialogResult.Yes)
                    {
                        var cat = lb_category.SelectedItem.ToString();
                        var newPod = txtBox_new_pod.Text;
                        edit.EditPod(cat, pod, newPod);
                        lb_category.Items.Clear();
                        cb_category.Items.Clear();
                        lb_podcast.Items.Clear();
                        clb_episodes.Items.Clear();
                        txtBox_new_pod.Clear();
                        FillCategoryList();
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }


        private void btn_edit_pod_location_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.listBoxEmpty(lb_podcast) && Validation.categoryBoxNotEmpty(cb_category))
                {
                    var pod = lb_podcast.SelectedItem.ToString();
                    var cat = cb_category.SelectedItem.ToString();
                    var oldCat = lb_category.SelectedItem.ToString();
                    var confirm = MessageBox.Show("Do you want to update " + pod + " to the category: " + cat + "?", "Update podcast", MessageBoxButtons.YesNo);

                    if (confirm == DialogResult.Yes)
                    {
                        edit.EditLocation(oldCat, pod, cat);

                        lb_category.Items.Clear();
                        cb_category.Items.Clear();
                        lb_podcast.Items.Clear();
                        clb_episodes.Items.Clear();
                        FillCategoryList();
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btn_edit_podcast_url_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.tfNotEmpty(txtBox_url, "The URL field ") && Validation.categoryBoxNotEmpty(cb_category) && Validation.intervalBoxNotEmpty(cb_interval)
                    && Validation.listBoxEmpty(lb_category) && Validation.listBoxEmpty(lb_podcast) && Validation.validURL(txtBox_url.Text))
                {

                    var category = lb_category.SelectedItem.ToString();
                    var podName = lb_podcast.SelectedItem.ToString();
                    var url = txtBox_url.Text;
                    var cat = cb_category.SelectedItem.ToString();
                    var interval = cb_interval.SelectedItem.ToString();
                    var remadeInterval = 0;
                    if (interval == "1")
                    {
                        remadeInterval = 60 * 60 * 1000;
                        feed.Remove(category, podName);
                        pod.PodInfo(podName, url, category, remadeInterval);
                    }
                    else if (interval == "2")
                    {
                        remadeInterval = 2 * 60 * 60 * 1000;
                        feed.Remove(category, podName);
                        pod.PodInfo(podName, url, category, remadeInterval);
                    }
                    else if (interval == "3")
                    {
                        remadeInterval = 3 * 60 * 60 * 1000;
                        feed.Remove(category, podName);
                        pod.PodInfo(podName, url, category, remadeInterval);
                    }
                    else if (interval == "4")
                    {
                        remadeInterval = 4 * 60 * 60 * 1000;
                        feed.Remove(category, podName);
                        pod.PodInfo(podName, url, category, remadeInterval);
                    }

                    lb_category.Items.Clear();
                    cb_category.Items.Clear();
                    lb_podcast.Items.Clear();
                    clb_episodes.Items.Clear();
                    FillCategoryList();

                    MessageBox.Show("URL updated");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btn_update_interval_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.listBoxEmpty(lb_podcast) && Validation.intervalBoxNotEmpty(cb_interval))
                {
                    var catt = lb_category.SelectedItem.ToString();
                    var podd = lb_podcast.SelectedItem.ToString();
                    var interval = cb_interval.SelectedItem.ToString();
                    var remadeInterval = 0;
                    if (interval == "1")
                    {
                        remadeInterval = 60 * 60 * 1000;
                        pod.UpdateInterval(catt, podd, remadeInterval);
                    }
                    else if (interval == "2")
                    {
                        remadeInterval = 2 * 60 * 60 * 1000;
                        pod.UpdateInterval(catt, podd, remadeInterval);
                    }
                    else if (interval == "3")
                    {
                        remadeInterval = 3 * 60 * 60 * 1000;
                        pod.UpdateInterval(catt, podd, remadeInterval);
                    }
                    else if (interval == "4")
                    {
                        remadeInterval = 4 * 60 * 60 * 1000;
                        pod.UpdateInterval(catt, podd, remadeInterval);
                    }
                    MessageBox.Show("Interval updated");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

        }
    }
}
