using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloodPing.Models
{
    public class LocationsNames
    {

        public LocationsNames()
        {

        }
             
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public String Name { get; set; }
        public String Address{ get; set; }
   
    }
}
