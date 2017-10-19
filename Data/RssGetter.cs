using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Data
{
    public class RssGetter
    {
        public bool newFolder(string category)
        {
            string folderName = category;

            var folder = Directory.GetCurrentDirectory() + @"\categories";
            var list = Directory.GetDirectories(folder);
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\categories\" + category);
            foreach (var cat in list)
            {
                var info = new DirectoryInfo(cat);               
            }

            return true;
        }


    }
}

