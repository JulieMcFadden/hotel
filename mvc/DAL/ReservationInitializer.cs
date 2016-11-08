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

            var customers = new List<User>
            {
                new User { id=1,first_name="Julie",last_name="McFadden",email_address="she@juliemcfadden.com",user_name="juliemcfadden",phone_number="501-772-7470",address1="10017 Bentley Way",city="Tampa",state="FL",zip_code="33626"},
                new User { id=2,first_name="Eric",last_name="Packwood",email_address="epackwood@reservations.com",user_name="ericpackwood",phone_number="",address1="",city="",state="",zip_code=""},
                new User { id=3,first_name="John",last_name="Doe",email_address="jd@juliemcfadden.com",user_name="johndoe",phone_number="501-772-7470",address1="10017 Bentley Way",city="Tampa",state="FL",zip_code="33626"},
                new User { id=4,first_name="Tom",last_name="Waits",email_address="tw@juliemcfadden.com",user_name="tomwaits",phone_number="501-772-7470",address1="10017 Bentley Way",city="Tampa",state="FL",zip_code="33626"},
                new User { id=5,first_name="Maynard",last_name="Keenan",email_address="tool@juliemcfadden.com",user_name="mjk",phone_number="501-772-7470",address1="10017 Bentley Way",city="Tampa",state="FL",zip_code="33626"}
            };

        }
    }
}