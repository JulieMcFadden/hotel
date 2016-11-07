using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using mvc.Models;

namespace mvc.DAL
{
    public class ReservationInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ReservationContext>
    {
        protected override void Seed(ReservationContext context)
        {
            var ammenities = new List<Ammenity>
            {
                new Ammenity {id=1,description="crib" },
                new Ammenity {id=2,description="hot tub" },
                new Ammenity {id=3,description="sleeper sofa" },
                new Ammenity {id=4,description="balcony" }
            };
            var rooms = new List<Room>
            {
                new Room {id=1,description="101",occupancy_max=4,status=0},
                new Room {id=2,description="102",occupancy_max=4,status=0},
                new Room {id=3,description="103",occupancy_max=4,status=0},
                new Room {id=4,description="104",occupancy_max=4,status=0},
                new Room {id=5,description="201",occupancy_max=4,status=0},
                new Room {id=6,description="202",occupancy_max=4,status=0},
                new Room {id=7,description="203",occupancy_max=4,status=0},
            };
            var customers = new List<User>
            {
                new User { id=1,first_name="Julie",last_name="McFadden",email_address="she@juliemcfadden.com",user_name="juliemcfadden",phone_number="501-772-7470",address1="10017 Bentley Way",city="Tampa",state="FL",zip_code="33626"},
                new User { id=2,first_name="Eric",last_name="Packwood",email_address="epackwood@reservations.com",user_name="ericpackwood",phone_number="",address1="",city="",state="",zip_code=""},
                new User { id=3,first_name="John",last_name="Doe",email_address="jd@juliemcfadden.com",user_name="johndoe",phone_number="501-772-7470",address1="10017 Bentley Way",city="Tampa",state="FL",zip_code="33626"},
                new User { id=4,first_name="Tom",last_name="Waits",email_address="tw@juliemcfadden.com",user_name="tomwaits",phone_number="501-772-7470",address1="10017 Bentley Way",city="Tampa",state="FL",zip_code="33626"},
                new User { id=5,first_name="Maynard",last_name="Keenan",email_address="tool@juliemcfadden.com",user_name="mjk",phone_number="501-772-7470",address1="10017 Bentley Way",city="Tampa",state="FL",zip_code="33626"}
            };
            var reservations = new List<Reservation>
            {
                new Reservation {id=1, check_in_date=DateTime.Now.AddDays(4), check_out_date=DateTime.Now.AddDays(6), room_count=1, reserve_date=DateTime.Now.AddDays(-4),cancel_date=DateTime.Now.AddDays(3) },
                new Reservation {id=2, check_in_date=DateTime.Now.AddDays(5), check_out_date=DateTime.Now.AddDays(8), room_count=1, reserve_date=DateTime.Now.AddDays(-3),cancel_date=DateTime.Now.AddDays(4) },
                new Reservation {id=3, check_in_date=DateTime.Now.AddDays(3), check_out_date=DateTime.Now.AddDays(4), room_count=1, reserve_date=DateTime.Now.AddDays(-1),cancel_date=DateTime.Now.AddDays(2) },
                new Reservation {id=4, check_in_date=DateTime.Now.AddDays(2), check_out_date=DateTime.Now.AddDays(6), room_count=1, reserve_date=DateTime.Now.AddDays(-10),cancel_date=DateTime.Now.AddDays(1) },
            };
        }
    }
}