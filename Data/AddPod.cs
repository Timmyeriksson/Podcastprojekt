using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Data
{
    public class AddPod
    {
        public void AddNewPod(string name, string category, string url, int interval)
        {
            RssReader rss = new RssReader();
            XmlDocument doc = rss.ReadRSS(url);
            string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + name + @".xml";

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            int i = 0;

            XmlWriter xmlOut = XmlWriter.Create(path, settings);

            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("channel");
            xmlOut.WriteElementString("interval", interval.ToString());
            xmlOut.WriteElementString("url", url);
            xmlOut.WriteElementString("lastSync", DateTime.Now.ToString());
            foreach (XmlNode item
               in doc.DocumentElement.SelectNodes("channel/item"))
            {
                var title = item.SelectSingleNode("title");
                var description = item.SelectSingleNode("description");
                var enclosure = item.SelectSingleNode("enclosure/@url");

                xmlOut.WriteStartElement("item");
                if (description != null)
                {
                    if (description.InnerText.Equals(""))
                    {
                        xmlOut.WriteElementString("description", "Unfortunately, no description is available.");
                    }
                    else
                    {
                        xmlOut.WriteElementString("description", description.InnerText);
                    }
                }


                xmlOut.WriteElementString("title", title.InnerText);
                xmlOut.WriteElementString("enclosure", enclosure.InnerText);
                xmlOut.WriteElementString("status", "Unlistened");

                xmlOut.WriteEndElement();
                i++;
            }

            xmlOut.WriteEndDocument();
            xmlOut.Close();
        }
    }
}

