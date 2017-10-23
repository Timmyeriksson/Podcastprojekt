using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Logic
{
    public class Podcast
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Category { get; set; }
        public string Interval { get; set; }

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
