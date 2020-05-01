using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Episode
    {
        //Properties
        public int numberOfEpisode { get; set; }
        public string Name { get; set; }

        //Display with string
        public override string ToString()
        {
            return $"{numberOfEpisode} {Name}";
        }

    }
}
