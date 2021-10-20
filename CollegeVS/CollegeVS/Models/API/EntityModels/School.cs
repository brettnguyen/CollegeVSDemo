using System;
namespace CollegeVS.Models.API.EntityModels
{
    public partial class School
    {
        public int School_Id { get; set; }
        public string Name { get; set; }
        public string Color1 { get; set; }
        public string Color2 { get; set; }
        public string Banner_Location { get; set; }
        public int MembersCount { get; set; }
        public string MembersList { get; set; }
        public int SubscriberCount { get; set; }
        public int FaceOffWins { get; set; }
        public int OverallRank { get; set; }
        public int PointsRank { get; set; }
        public int SubsRank { get; set; }
        public int Points { get; set; }
        public int Parties { get; set; }
        public int Clubs { get; set; }
        public int Food { get; set; }
        public int Sports { get; set; }
        public string Conference { get; set; }
        public string Region { get; set; }
        public int Dorms { get; set; }
        public string Emblem_Location { get; set; }
        public int Other { get; set; }
        public bool IsInFaceoff { get; set; }
        public bool IsInDowntime { get; set; }
    }
}
