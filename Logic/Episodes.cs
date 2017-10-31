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
        List<Episodes> episodes = new List<Episodes>();
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }

        public void getEpisodes(string category, string prePath)
        {
            try
            {
                string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + prePath + @".xml";
                XmlDocument xdcDocument = new XmlDocument();
                xdcDocument.Load(path);
                if (episodes != null)
                {
                    episodes.Clear();
                    foreach (XmlNode xndNode in xdcDocument.DocumentElement.SelectNodes("item"))
                    {
                        var title = xndNode.SelectSingleNode("title");
                        var description = xndNode.SelectSingleNode("description");
                        var eppis = new Episodes()
                        {
                            Title = title.InnerText,
                            Description = description.InnerText,

                        };
                        episodes.Add(eppis);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        public List<Episodes> getepList()
        {

            return episodes;
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
