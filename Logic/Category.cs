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
        CategorySaver saveFolder = new CategorySaver();
        public void NewFolder(string category)
        {
           saveFolder.newFolder(category);
        }
    }
}
