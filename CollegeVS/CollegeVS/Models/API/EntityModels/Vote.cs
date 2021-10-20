using System;
namespace CollegeVS.Models.API.EntityModels
{
    public partial class Vote
    {
        public int Like_ID { get; set; }
        public int User_ID { get; set; }
        public int Video_ID { get; set; }
        public bool Voted { get; set; }
        public Nullable<System.DateTime> DateUpvoted { get; set; }
    }
}
