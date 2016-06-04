﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloodPing.Models
{
   public class SafeRoutes
    {
        public SafeRoutes()
        {

        }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string LocationName { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
