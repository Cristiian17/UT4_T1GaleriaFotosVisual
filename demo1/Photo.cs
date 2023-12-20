using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    public class Photo
    {
        public Photo()
        {
        }
        public Photo(string path)
        {
            Source = path;
        }
       

        public string Source { get; set; }

        public override string ToString() => Source;
    }
}
