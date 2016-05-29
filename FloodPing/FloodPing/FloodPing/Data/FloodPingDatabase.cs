﻿using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FloodPing.Models;

namespace FloodPing.Data
{
    public class FloodPingDatabase
    {

        static object locker = new object();
        SQLiteConnection database;

        public FloodPingDatabase()
        {
            database = DependencyService.Get<ISQLite>().GetConnection();
            // create the messages table
            database.CreateTable<EmergencyMessages>();
            
            // Create the stranded traveller table.
            // This reset the records every time the app is started to
            // simulate strandeed travellers.
            // 
            // In real situation this is likely to be a web server to
            // retrieve this information from the central servers.
            database.DropTable<StrandedTravellers>();
            database.CreateTable<StrandedTravellers>();

            // For the purposes of the MVP, reset the stranded customers when the app
            // has been started.
            
            //Insert the records.
            StrandedTravellers StrandedTraveller = new StrandedTravellers();
            StrandedTraveller.stranded_lat = 0;
            StrandedTraveller.stranded_long = 0;
            StrandedTraveller.stranded_orginialtime = DateTime.Now;
            StrandedTraveller.stranded_lastupdatetime = DateTime.Now;
            this.StrandedTravellerSaveItem(StrandedTraveller);

            StrandedTraveller.ID = 0;
            StrandedTraveller.stranded_lat = 0;
            StrandedTraveller.stranded_long = 1;
            StrandedTraveller.stranded_orginialtime = DateTime.Now;
            StrandedTraveller.stranded_lastupdatetime = DateTime.Now;
            this.StrandedTravellerSaveItem(StrandedTraveller);

            StrandedTraveller.ID = 0;
            StrandedTraveller.stranded_lat = 1;
            StrandedTraveller.stranded_long = 0;
            StrandedTraveller.stranded_orginialtime = DateTime.Now;
            StrandedTraveller.stranded_lastupdatetime = DateTime.Now;
            this.StrandedTravellerSaveItem(StrandedTraveller);

            StrandedTraveller.ID = 0;
            StrandedTraveller.stranded_lat = 1;
            StrandedTraveller.stranded_long = 1;
            StrandedTraveller.stranded_orginialtime = DateTime.Now;
            StrandedTraveller.stranded_lastupdatetime = DateTime.Now;
            this.StrandedTravellerSaveItem(StrandedTraveller);
        }

        // Method to insert or update stranded travellers.
        public int StrandedTravellerSaveItem(StrandedTravellers item)
        {
            lock (locker)
            {
                if (item.ID != 0)
                {
                    database.Update(item);
                    return item.ID;
                }
                else
                {
                    return database.Insert(item);
                }
            }
        }

        // Method to insert or update messages sent from the app.
        public int EmergencyMessageSaveItem(EmergencyMessages item)
        {
            lock (locker)
            {
                if (item.ID != 0)
                {
                    database.Update(item);
                    return item.ID;
                }
                else
                {
                    return database.Insert(item);
                }
            }
        }

        // Method that returns the total number of stranded travllers.
        public int StrandedTravellerCount ()
        {
            var allItems = database.Table<StrandedTravellers>().ToList();
            return allItems.Count();
        }

        // Method that returns a list of all the stranded travellers.
        public IEnumerable<StrandedTravellers> GetStrandedTravellers()
        {
            lock (locker)
            {
                return database.Table<StrandedTravellers>().ToList();
            }
            
        }

        public IEnumerable<EmergencyMessages> GetEmergencyMessages()
        {
            lock (locker)
            {
                return database.Table<EmergencyMessages>().ToList();
            }

        }
    }
}
