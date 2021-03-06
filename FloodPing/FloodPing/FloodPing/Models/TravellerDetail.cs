﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace FloodPing.Models
{
    public class TravellerDetail
    {
        public TravellerDetail()
        {
        }
        // Table that store the location of the traveller Detail.
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int stranded_long { get; set; }
        public int stranded_lat { get; set; }
        public string traveller_name { get; set; }
        public string emergency_detail { get; set; }
    }
}
