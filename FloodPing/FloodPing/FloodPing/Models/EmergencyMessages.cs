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

        // Table to locally store the history of broadcast message.
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string messageType { get; set; }
        public string message { get; set; }
        public DateTime message_sentdate { get; set; }

    }

}
