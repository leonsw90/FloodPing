using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace FloodPing.Models
{
    public class Events
    {
        public Events()
        {

        }

        // Table to locally store the history of broadcast message.
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string eventDescription { get; set; }
        public double eventLong { get; set; }
        public double eventLat { get; set; }
        public DateTime eventDateTime { get; set; }

    }

}
