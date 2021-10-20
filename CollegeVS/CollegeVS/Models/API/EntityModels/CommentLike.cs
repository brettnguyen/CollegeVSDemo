using System;
namespace CollegeVS.Models.API.EntityModels
{
    public partial class CommentLike
    {
        public int CommentLikeID { get; set; }
        public int CommentID { get; set; }
        public int TxUserID { get; set; }
        public int RxUserID { get; set; }
        public bool IsLiked { get; set; }
    }
}
