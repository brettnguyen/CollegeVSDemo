using System;
namespace CollegeVS.Models.API.EntityModels
{
    public partial class Video
    {
        public int Video_Id { get; set; }
        public string Title { get; set; }
        public string Uploader_Name { get; set; }
        public int Uploader_Id { get; set; }
        public string Category { get; set; }
        public string School_Name { get; set; }
        public System.DateTime Upload_Date { get; set; }
        public int Votes { get; set; }
        public string Location { get; set; }
        public int CommentCount { get; set; }
        public int ShareCount { get; set; }
        public Nullable<int> School_Id { get; set; }
        public string ContentType { get; set; }
        public int Flag { get; set; }
        public bool IsDareResponse { get; set; }
        public Nullable<int> DareResponseID { get; set; }
        public bool IsOriginalDare { get; set; }
        public Nullable<int> AnonymousUploaderID { get; set; }
        public bool IsForFaceoff { get; set; }
        public int FaceoffAssignmentID { get; set; }
        public int FaceoffID { get; set; }
        public bool WentViral { get; set; }
        public int FaceoffFinalCV { get; set; }
    }
}
