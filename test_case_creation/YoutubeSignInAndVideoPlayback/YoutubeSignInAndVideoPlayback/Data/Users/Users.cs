using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeSignInAndVideoPlayback.Data.Users
{
    public class Users
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public Users ValidUser()
        {
            Users result = new Users
            {
                Username = "mattaku.ad@gmail.com",
                Password = "Q!w2e3r4"
            };
            return result;
        }

        public Users InvalidUser()
        {
            Users result = new Users
            {
                Username = "1234ashfdqwert1234@gmail.com",
                Password = "test123"
            };
            return result;
        }
    }
}
