using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloodPing.Models
{
   public class FloodSatistics
    {
        public FloodSatistics()
        {

        }
        public int ID { get; set; }       
        public float Flood_stat { get; set; }
        public string location { get; set; }
        public DateTime year { get; set; }
       

    }
}
