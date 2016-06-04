using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloodPing.Models
{
    public class FloodLocation
    {

        public FloodLocation()
        {

        }
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public String PlaceName { get; set; }
        public String Chance { get; set; }
        public String Location { get; set; }



    }
}
