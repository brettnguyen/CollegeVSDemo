using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace CollegeVS.Models.DTOs
{
    public class DareUploadDTO
    {
        public string ContentTitle { get; set; }

        public string UploaderUsername { get; set; }

        public string Category { get; set; }

        public string ContentContextText { get; set; }

        public string SchoolName { get; set; }

        public int SchoolID { get; set; }

        public string RxUsername { get; set; }

        public FileResult File { get; set; }

    }
}
