using System;
namespace CollegeVS.Models.API.EntityModels
{
    public partial class User
    {
        public int User_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public byte[] Password { get; set; }
        public string Email { get; set; }
        public string School_Name { get; set; }
        public int School_Id { get; set; }
        public string Avatar_Location { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public System.DateTime JoinDate { get; set; }
        public string AboutMe { get; set; }
        public int Followers { get; set; }
        public int Following { get; set; }
        public int Points { get; set; }
        public int Posts { get; set; }
        public int Parties { get; set; }
        public int Clubs { get; set; }
        public int Sports { get; set; }
        public int Food { get; set; }
        public int Dorms { get; set; }
        public int Other { get; set; }
        public int NotificationFlag { get; set; }
        public int SharedVideosCount { get; set; }
        public string Background_Location { get; set; }
        public int Comments { get; set; }
        public Nullable<System.DateTime> NextTimestamp { get; set; }
        public bool IsInDare { get; set; }
        public int DareQueueCount { get; set; }
        public bool Verified { get; set; }
        public bool ShowTutorial { get; set; }
        public byte[] EmailVerifyToken { get; set; }
        public Nullable<int> lastVideoId { get; set; }
        public Nullable<System.DateTime> NextTimeStampNotifs { get; set; }
        public bool IsAlumni { get; set; }
    }
}
