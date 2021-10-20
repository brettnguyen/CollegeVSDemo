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
    public class HighlightViewModel : BindableObject
    {

        public ObservableCollection<HomeModel> highlights { get; set; }

        public ICommand SetStatusCommand { get; set; }

        public ICommand RemoveStatusCommand { get; set; }










        public HighlightViewModel()
        {
            highlights = new ObservableCollection<HomeModel>()
            {
               new HomeModel()
                {
                    ProfilePicture = "UserIcon.png",
                Username = "User Name",
                PostImage = "Harvard.jpg",
                PostDetail = "This is collegeVS",
                PostUpvoteCount = 100,
                PostCommentCount = "7",
                PostTime = "2 weeks",

                College = "Harvard",
                Category = "clearbackgrounddorms.png",
              
                },


            };
            SetStatusCommand = new Command(SetStatus);
            RemoveStatusCommand = new Command(RemoveStatus);




        }

        void SetStatus()
        {
            HomeModel selectedLike = highlights.Where(c => c.Seen == true)
                .FirstOrDefault();

            if (selectedLike != null)
            {
                // Change the value and update UI automatically
                selectedLike.Seen = false;
            }




            HomeModel selectedunlike = highlights.Where(c => c.Back == false)
                .FirstOrDefault();

            if (selectedunlike != null)
            {
                // Change the value and update UI automatically
                selectedunlike.Back = true;
            }

        }


        void RemoveStatus()
        {
            HomeModel selectedunlike = highlights.Where(c => c.Back == true)
                .FirstOrDefault();

            if (selectedunlike != null)
            {
                // Change the value and update UI automatically
                selectedunlike.Back = false;
            }

            HomeModel selectedLike = highlights.Where(c => c.Seen == false)
                .FirstOrDefault();

            if (selectedLike != null)
            {
                // Change the value and update UI automatically
                selectedLike.Seen = true;
            }
        }




    }
}

