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
        public void Remove(string category)
        {
            string path = Directory.GetCurrentDirectory() + @"\" + category;

            File.SetAttributes(path, FileAttributes.Normal);
            Directory.Delete(path, true);
        }

        public void Remove(string category, string namn)
        {

            string path = Directory.GetCurrentDirectory() + @"\" + category + @"\" + namn + @".xml";
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            if (File.Exists(path) && path != null)
            {

                File.SetAttributes(path, FileAttributes.Normal);

                File.Delete(path);
            }

        }
    }
}
