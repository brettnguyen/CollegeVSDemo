using System;
using System.Collections.Generic;
using Lottie.Forms;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using CollegeVS.Models;
using Xamarin.Forms;

namespace CollegeVS.ViewModels
{
    public class SchoolPageViewModel : BindableObject
    {

        public ObservableCollection<HomeModel> schools { get; set; }

        public ICommand SetStatusCommand { get; set; }

        public ICommand RemoveStatusCommand { get; set; }











        public SchoolPageViewModel()
        {
            schools = new ObservableCollection<HomeModel>()
            {
               new HomeModel()
                {
               ProfilePicture = "SteveHarvey.jpg",
				Username = "SteveHarvey",
				PostImage = "Darnell.jpeg",
				PostDetail = "This is collegeVS",
				PostUpvoteCount = 100,
				PostCommentCount = "7",
				PostTime = "2 weeks",
				Seen = true,
				Back = false,
				College = "Plattsburgh",
				Category = "clearbackgroundparty.png"
                },

                new HomeModel()
                {
               ProfilePicture = "SteveHarvey.jpg",
                Username = "SteveHarvey",
                PostImage = "cvlogo.jpg",
                PostDetail = "This is collegeVS",
                PostUpvoteCount = 90,
                PostCommentCount = "7",
                PostTime = "1 week",
                Seen = true,
                Back = false,
                College = "Plattsburgh",
                Category = "clearbackgroundsports.png"
                },

                new HomeModel()
                {
             ProfilePicture = "SteveHarvey.jpg",
                Username = "SteveHarvey",
                PostImage = "cvlogo.jpg",
                PostDetail = "This is collegeVS",
                PostUpvoteCount = 80,
                PostCommentCount = "7",
                PostTime = "15 mins",
                Seen = true,
                Back = false,
                College = "Plattsburgh",
                Category = "clearbackgroundother.png"
                },

                 new HomeModel()
                {
                     ProfilePicture = "SteveHarvey.jpg",
                Username = "SteveHarvey",
                PostImage = "cvlogo.jpg",
                PostDetail = "This is collegeVS",
                PostUpvoteCount = 70,
                PostCommentCount = "7",
                PostTime = "1 hour",
                Seen = true,
                Back = false,
                College = "Plattsburgh",
                Category = "clearbackgrounddorms.png"
                },

                  new HomeModel()
                {
ProfilePicture = "SteveHarvey.jpg",
				Username = "SteveHarvey",
				PostImage = "cvlogo.jpg",
				PostDetail = "This is collegeVS",
				PostUpvoteCount = 60,
				PostCommentCount = "7",
				PostTime = "15 hours",
				Seen = true,
				Back = false,
				College = "Plattsburgh",
				Category = "clearbackgroundclubs.png"
                },
            };
            SetStatusCommand = new Command(SetStatus);
            RemoveStatusCommand = new Command(RemoveStatus);




        }

        void SetStatus()
        {
            HomeModel selectedLike = schools.Where(c => c.Seen == true)
                .FirstOrDefault();

            if (selectedLike != null)
            {
                // Change the value and update UI automatically
                selectedLike.Seen = false;
            }




            HomeModel selectedunlike = schools.Where(c => c.Back == false)
                .FirstOrDefault();

            if (selectedunlike != null)
            {
                // Change the value and update UI automatically
                selectedunlike.Back = true;
            }

        }


        void RemoveStatus()
        {
            HomeModel selectedunlike = schools.Where(c => c.Back == true)
                .FirstOrDefault();

            if (selectedunlike != null)
            {
                // Change the value and update UI automatically
                selectedunlike.Back = false;
            }

            HomeModel selectedLike = schools.Where(c => c.Seen == false)
                .FirstOrDefault();

            if (selectedLike != null)
            {
                // Change the value and update UI automatically
                selectedLike.Seen = true;
            }
        }




    }
}

