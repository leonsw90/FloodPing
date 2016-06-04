using System;
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
            database.CreateTable<LocationsNames>();
            
            // Create the stranded traveller table.
            // This reset the records every time the app is started to
            // simulate strandeed travellers.
            // 
            // In real situation this is likely to be a web server to
            // retrieve this information from the central servers.
            database.DropTable<StrandedTravellers>();
            database.CreateTable<StrandedTravellers>();

            database.DropTable<TravellerDetail>();
            database.CreateTable<TravellerDetail>();

            // For the purposes of the MVP, reset the stranded customers when the app
            // has been started.

            //Insert the records.
            StrandedTravellers StrandedTraveller = new StrandedTravellers();
            StrandedTraveller.stranded_lat = 0;
            StrandedTraveller.stranded_long = 0;
            StrandedTraveller.stranded_orginialtime = DateTime.Now;
            StrandedTraveller.stranded_lastupdatetime = DateTime.Now;
            StrandedTraveller.traveller_name = "Jane";
            StrandedTraveller.emergency_detail = "Trapped in car, middle of road.";
            this.StrandedTravellerSaveItem(StrandedTraveller);

            StrandedTraveller.ID = 0;
            StrandedTraveller.stranded_lat = 0;
            StrandedTraveller.stranded_long = 1;
            StrandedTraveller.stranded_orginialtime = DateTime.Now;
            StrandedTraveller.stranded_lastupdatetime = DateTime.Now;
            StrandedTraveller.traveller_name = "John";
            StrandedTraveller.emergency_detail = "Trapped in road, no exit.";
            this.StrandedTravellerSaveItem(StrandedTraveller);

            StrandedTraveller.ID = 0;
            StrandedTraveller.stranded_lat = 1;
            StrandedTraveller.stranded_long = 0;
            StrandedTraveller.stranded_orginialtime = DateTime.Now;
            StrandedTraveller.stranded_lastupdatetime = DateTime.Now;
            StrandedTraveller.traveller_name = "Mike";
            StrandedTraveller.emergency_detail = "Stuck in house,no way out.";
            this.StrandedTravellerSaveItem(StrandedTraveller);

            StrandedTraveller.ID = 0;
            StrandedTraveller.stranded_lat = 1;
            StrandedTraveller.stranded_long = 1;
            StrandedTraveller.stranded_orginialtime = DateTime.Now;
            StrandedTraveller.stranded_lastupdatetime = DateTime.Now;
            StrandedTraveller.traveller_name = "Jane";
            StrandedTraveller.emergency_detail = "Trapped in car.";
            this.StrandedTravellerSaveItem(StrandedTraveller);

            // Table to store the locations of the subhurbs
            LocationsNames LocationsNames = new LocationsNames();
            LocationsNames.Name = "Ipshwich";
            LocationsNames.Address = "Adress 1, City";
            this.LocationSaveItem(LocationsNames);


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

        public int TravellerDetailSaveItem(TravellerDetail item)
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

        public IEnumerable<TravellerDetail> GetTravellerDetail()
        {
            lock (locker)
            {
                return database.Table<TravellerDetail>().ToList();
            }

        }

        public StrandedTravellers GetTravellerDetail(int ID)
        {
            lock (locker)
            {
                return database.Get<StrandedTravellers>(ID);
            }
        }

        public IEnumerable<EmergencyMessages> GetEmergencyMessages()
        {
            lock (locker)
            {
                return database.Table<EmergencyMessages>().ToList();
            }

        }


        /// Method to save the subhurb data int database
        ///

        public int LocationSaveItem(LocationsNames item)
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



    }
}
