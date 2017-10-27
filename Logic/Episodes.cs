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
        Episode eps = new Episode();
        Podcast pods = new Podcast();
        List<Episode> episodes = new List<Episode>();

        public void getEpisodes(string category, string prePath, CheckedListBox chlBox)
        {
            string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + prePath + @".xml";

            XmlDocument xdcDocument = new XmlDocument();
            xdcDocument.Load(path);

            foreach (XmlNode xndNode in xdcDocument.DocumentElement.SelectNodes("item"))
            {
                var title = xndNode.SelectSingleNode("title");
                var titlestring = title.ToString();
                chlBox.Items.Add(title.InnerText);
            }
        }

        public void setPlayed(string category, string name, CheckedListBox chlBox)
        {
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
                    chlBox.SetItemChecked(i, true);
                }
                i++;
            }
        }

        public void getDescription(string category, string name, string chosenEp, RichTextBox textBox)
        {
            string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + name + @".xml";

            XmlDocument xdcDocument = new XmlDocument();
            xdcDocument.Load(path);

            foreach (XmlNode xndNode in xdcDocument.DocumentElement.SelectNodes("item"))
            {
                var title = xndNode.SelectSingleNode("title");
                if (chosenEp.Equals(title.InnerText))
                {
                    var description = xndNode.SelectSingleNode("description");
                    textBox.Text = description.InnerText;
                }
            }
        }

        public void getPodcastUrl(string category, string namn, string selectedPod, out string url)
        {
            XmlDocument xml = new XmlDocument();

            string[] minArray = selectedPod.Split('(');
            string selected = minArray[0];

            string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + namn + @".xml";
            xml.Load(path);

            url = "";

            foreach (XmlNode node in xml.DocumentElement.SelectNodes("item"))
            {
                XmlNode enclosure = node.SelectSingleNode("enclosure");
                XmlNode title = node.SelectSingleNode("title");
                XmlNode status = node.SelectSingleNode("status");
                if (title.InnerText.Equals(selected))
                {
                    url = enclosure.InnerText;
                    status.InnerText = "Listened to.";
                    xml.Save(path);
                }
            }
        }
    }
}