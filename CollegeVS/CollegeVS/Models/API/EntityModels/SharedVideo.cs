using System;
namespace CollegeVS.Models.API.EntityModels
{
    public partial class SharedVideo
    {
        public int Id { get; set; }
        public int SharingUserID { get; set; }
        public int UploaderID { get; set; }
        public int SharedVideoID { get; set; }
        public System.DateTime SharedDate { get; set; }
        public int UnShared { get; set; }
    }
}
