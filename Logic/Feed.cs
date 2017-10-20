using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Feed
    {
        public void remove(string category)
        {
            string path = Directory.GetCurrentDirectory() + @"\categories\" + category;

            Directory.Delete(path, true);
        }

        public void remove(string category, string namn)
        {
            string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + namn + @".xml";

            File.Delete(path);
        }

        public void addPod(string name, string url, string category, string interval)
        {

        }
    }
}
