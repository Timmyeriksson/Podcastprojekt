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
        public void AddNewPod(string name, string url, string category, string interval)
        {
            RssReader rss = new RssReader();

            XmlDocument document = rss.ReadRSS(url);
            string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + name + @".xml";
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");
            int i = 0;
            XmlWriter write = XmlWriter.Create(path, settings);

            write.WriteStartDocument();
            write.WriteStartElement("channel");
            write.WriteStartElement("interval", interval);
            write.WriteStartElement("url", url);
            write.WriteStartElement("lastUpdate", DateTime.Now.ToString());
            foreach (XmlNode item in document.DocumentElement.SelectNodes("channel/item"))
            {
                var title = item.SelectSingleNode("title");
                var description = item.SelectSingleNode("description");
                var enclosure = item.SelectSingleNode("enclosure/@url");

                write.WriteStartElement("item");
                write.WriteAttributeString("ID", "podcast" + i);
                if (description.InnerText.Equals(""))
                {
                    write.WriteElementString("description", "There is no description available");
                }
                else
                {
                    write.WriteElementString("description", description.InnerText);
                }

                write.WriteElementString("title", title.InnerText);
                write.WriteElementString("enclosure", enclosure.InnerText);
                write.WriteElementString("status", "Not played");

                write.WriteEndElement();
                i++;
            }
            write.WriteEndDocument();
            write.Close();
        }
    }
}
