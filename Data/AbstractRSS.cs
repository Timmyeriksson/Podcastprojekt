using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Data
{
    public abstract class AbstractRSS
    {
        public abstract XmlDocument ReadRSS(string urlString);
        public virtual void WriteXmlDoc(string name, string url, string category)
        {
            Console.WriteLine(url + "" + category + "" + name);
        }
    }
}
