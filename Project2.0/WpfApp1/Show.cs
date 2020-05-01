using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Show
    {
        //Properties
        public string ShowName { get; set; }
        public List<Season> Seasons { get; set; }


        public Show()
        {
            Seasons = new List<Season>();
        }

        //Display with string
        public override string ToString()
        {
            return $"{ShowName}";
        }
    }
}
