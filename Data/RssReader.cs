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
        public void ReadRSS(string name, string url, string category)
        {
            using (var client = new WebClient())
            {
                string path = Directory.GetCurrentDirectory() + @"\categories\" + category + @"\" + name + ".xml";
                client.DownloadFile(url, path);
                client.Dispose();
                   
            }
        }

    }
}
