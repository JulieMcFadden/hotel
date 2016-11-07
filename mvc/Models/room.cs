using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc.Models
{
    public enum room_status { Available, Reserved, Occupied}
    public class User
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email_address { get; set; }
        public string user_name { get; set; }
        public string phone_number { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zip_code { get; set; }
    }
    public class Hotel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string geonameid { get; set; }

        public IEnumerable<Room> Rooms { get; set; }
    }
    public class Room
    {
        public int id { get; set; }
        public string description { get; set; }
        public int occupancy_max { get; set; }
        public int occupants { get; set; }
        public room_status status { get; set; }
        public int hotel_id { get; set; }
        public Hotel Hotel { get; set; }

        public IEnumerable<Ammenity> Ammenities { get; set; }
    }
    public class Ammenity
    {
        public int id { get; set; }
        public string description { get; set; }
        public float value { get; set; }
    }
    public class Reservation
    {
        public int id { get; set; }
        public DateTime check_in_date { get; set; }
        public DateTime check_out_date { get; set; }
        public int room_count { get; set; }
        public DateTime reserve_date { get; set; }
        public DateTime cancel_date { get; set; }
        public string notes { get; set; }

        public int user_id { get; set; }
        public User Customer { get; set; }

        public IEnumerable<Room> Rooms { get; set; }

    }
}