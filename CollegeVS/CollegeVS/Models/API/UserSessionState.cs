using System;
namespace CollegeVS.Models.API
{
    public class UserSessionState
    {
        public string Username { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public string Email { get; set; }

        public int User_ID { get; set; }

        public DateTime? Birthday { get; set; }

        public string School { get; set; }

        public int School_Id { get; set; }

        public DateTime JoinDate { get; set; }

        public string EmailToken { get; set; }

        public bool Valid_Login { get; set; }
    }
}
