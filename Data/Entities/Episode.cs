using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Enteties
{
   public class Episode
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public bool ListenedTo { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
