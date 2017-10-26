using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Data
{
    public class RssReader
    {
        public XmlDocument ReadRSS(string urlString)
        {
            var xml = "";
            using (var client = new System.Net.WebClient())
            {
                client.Encoding = Encoding.UTF8;
                xml = client.DownloadString(urlString);
            }
            XmlDocument dom = new XmlDocument();
            dom.LoadXml(xml);
            return dom;
        }


    }
}
