using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Data
{
    public abstract class AbstractRssReader
    {
        public string readRSS(string url)
        {
            var xml = "";

            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString("http://alexosigge.libsyn.com/rss");
            }

            var newXmlDoc = new XmlDocument();
            newXmlDoc.LoadXml(xml);

            string path = "C:\\test.xml";
            XmlTextWriter writer = new XmlTextWriter(path, null);

            return url;
        }

    }
}
