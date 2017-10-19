using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.IO;

namespace Logic
{
    public class Category
    {
        RssGetter rss = new RssGetter();

        public void newFolder(string category)
        {
            rss.newFolder(category);
        }

        public void remove(string category)
        {
            string path = Directory.GetCurrentDirectory() + @"\categories\" + category;

            Directory.Delete(path, true);
        }

    }
}
