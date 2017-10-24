using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.ServiceModel.Syndication;

namespace Logic
{
    public class Podcast
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Category { get; set; }
        public string Interval { get; set; }
        public string Description { get; set; }
        List<Podcast> pods = new List<Podcast>();
        public void PodInfo(string name, string url, string category, string interval)
        {
            RssReader rss = new RssReader();


            this.Name = name;
            this.Url = url;
            this.Category = category;
            this.Interval = interval;


            rss.ReadRSS(name, url, category);
        }
    }
}
