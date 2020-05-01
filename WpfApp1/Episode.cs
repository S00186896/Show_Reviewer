using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Episode
    {
        //Properties
        public int numberOfEpisode { get; set; }
        public string Name { get; set; }
        public string Review { get; set; }
        public int Rating { get; set; }


        //Display with string
        public override string ToString()
        {
            return $"Episode: {numberOfEpisode} {Name}";
        }

    }
}
