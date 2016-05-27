using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace FloodPing.Models
{
    public class StrandedTravellers
    {
        public StrandedTravellers()
        {

        }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public double stranded_long { get; set; }
        public double stranded_lat { get; set; }
        public DateTime stranded_orginialtime { get; set; }
        public DateTime stranded_lastupdatetime { get; set; }
    }

}
