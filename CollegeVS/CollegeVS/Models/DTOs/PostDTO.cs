using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace CollegeVS.Models.DTOs
{
    public class PostDTO
    {
        public string PostTitle { get; set; }

        public string UploaderUsername { get; set; }

        public string Category { get; set; }

        public string SchoolName { get; set; }

        public int SchoolID { get; set; }

        public bool IsDareAttempt { get; set; }

        public int DareID { get; set; }

        public FileResult File { get; set; }






    }
}
