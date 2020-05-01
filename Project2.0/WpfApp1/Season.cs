using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Season
    {
        //Properties
        public int numberOfSeason { get; set; }
        public string SeasonName { get; set; }

        //Display with string
        public override string ToString()
        {
            return $"({numberOfSeason}).  {SeasonName}";
        }
    }
}
