using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeVS.Models
{
  public class ProfileGalleryModel
    {

        public int Id { get; set; }
        public string GalleryImage { get; set; }

        public string ProfilePicture { get; set; }

        public string Username { get; set; }
        public string Name { get; set; }
        public string College { get; set; }
        public int Followers { get; set; }
        public int Following { get; set; }
        public int Rank { get; set; }

        public string PostTime { get; set; }


        public string PostDetail { get; set; }

        public int PostUpvoteCount { get; set; }

        public int PostCommentCount { get; set; }

        public int PostShareCount { get; set; }

        public string Upvotestate { get; set; }

        public string Category { get; set; }

    }
}
