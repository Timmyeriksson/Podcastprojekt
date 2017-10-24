using Data.Enteties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Logic
{
    public class Episodes
    {
        List<Episode> episodes = new List<Episode>();
        public void getEpisodes(string category, string prePath, CheckedListBox chlBox)
        {
            var path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + prePath + @".xml";

            var xml = XmlReader.Create(path);
            var feed = SyndicationFeed.Load(xml);
            xml.Close();


            if (episodes.Count == 0)
            {
                foreach (var episode in feed.Items)
                {
                    var pod = new Episode()
                    {
                        Title = episode.Title.Text,
                        Description = episode.Summary.Text,
                        ListenedTo = false
                    };
                    foreach (var link in episode.Links)
                    {
                        pod.Url = link.Uri.OriginalString;
                        continue;
                    }
                    episodes.Add(pod);
                }
                foreach (var item in episodes)
                {
                    chlBox.Items.Add(item, false);
                }
            }
            else
            {
                episodes.Clear();
                foreach (var episode in feed.Items)
                {
                    var pod = new Episode()
                    {
                        Title = episode.Title.Text,
                        Description = episode.Summary.Text,
                        ListenedTo = false
                    };
                    foreach (var link in episode.Links)
                    {
                        pod.Url = link.Uri.OriginalString;
                        continue;
                    }
                    episodes.Add(pod);
                }
                foreach (var item in episodes)
                {
                    chlBox.Items.Add(item, false);
                }
            }
        }

        public void getDescription(string name, RichTextBox richtb)
        {

            var desc = from x in episodes
                       where x.Title == name
                       select x.Description;

            richtb.AppendText(desc.Single().ToString());

        }

        public string getUrl(string episode)
        {

            var query = from c in episodes
                        where c.Title == episode
                        select c.Url;

            return query.Single().ToString();
        }
    }
}