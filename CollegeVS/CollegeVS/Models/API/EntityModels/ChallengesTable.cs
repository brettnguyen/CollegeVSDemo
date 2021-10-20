using System;
namespace CollegeVS.Models.API.EntityModels
{
    public partial class ChallengesTable
    {
        public int Id { get; set; }
        public int User_ID { get; set; }
        public int Videos { get; set; }
        public int Images { get; set; }
        public int Upvotes { get; set; }
        public int Shares { get; set; }
        public int Schools_Visited { get; set; }
        public int Highest_Leaderboard_Position { get; set; }
        public int Points { get; set; }
        public int Videos_Viewed { get; set; }
        public System.TimeSpan Time_Spent { get; set; }
        public int Profiles_Visited { get; set; }
        public int Parties { get; set; }
        public int Sports { get; set; }
        public int Dorms { get; set; }
        public int Clubs { get; set; }
        public int Food { get; set; }
        public int Other { get; set; }
        public int RcvdVideoVotes { get; set; }
        public int RcvdImgVotes { get; set; }
        public int DaresSent { get; set; }
        public int DaresRcvd { get; set; }
        public int DaresAccepted { get; set; }
        public int DaresDeclined { get; set; }
        public int DaresPassed { get; set; }
        public int DaresFailed { get; set; }
        public int DareSentDeclines { get; set; }
        public int DareSentAccepts { get; set; }
        public int DareSentAttempts { get; set; }
        public int DareSentFails { get; set; }
        public int DareSentPasses { get; set; }
        public int DaresAttempted { get; set; }
    }
}
