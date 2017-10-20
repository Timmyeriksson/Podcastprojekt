using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Podcast
    {
        public string name { get; set; }
        public string url { get; set; }
        public string category { get; set; }
        public int interval { get; set; }

        
        public void podInfo(string name, string url, string category, int interval)
        {
            this.name = name;
            this.url = url;
            this.category = category;
            this.interval = interval;
        } 
    }
}
