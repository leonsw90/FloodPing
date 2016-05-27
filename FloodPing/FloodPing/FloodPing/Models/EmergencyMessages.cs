using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace FloodPing.Models
{
    public class EmergencyMessages
    {
        public EmergencyMessages()
        {

        }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string MessageType { get; set; }
        public string Message { get; set; }
        
    }

}
