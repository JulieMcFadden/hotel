using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvc.Models
{
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
    public class Room
    {
        public int id { get; set; }
        [Display(Name = "Guests")]
        public int occupants { get; set; }
    }
    public class Reservation
    {
        public int id { get; set; }
        [Display(Name="Check In")]
        [DataType(DataType.Date)]
        public DateTime check_in_date { get; set; }
        [Display(Name = "Check Out")]
        [DataType(DataType.Date)]
        public DateTime check_out_date { get; set; }
        [Display(Name = "# Rooms")]
        public int room_count { get; set; }
        public DateTime reserve_date { get; set; }
        public DateTime cancel_date { get; set; }
        [Display(Name = "Notes")]
        public string notes { get; set; }

        [Display(Name = "Location")]
        public string geonameid { get; set; }
        public IEnumerable<Room> Rooms { get; set; }

    }
}