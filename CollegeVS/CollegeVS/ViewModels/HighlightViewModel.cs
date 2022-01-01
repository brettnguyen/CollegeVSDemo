using System;
using System.Collections.Generic;
using Lottie.Forms;
using System.Collections.ObjectModel;
using System.Linq;
using SlideOverKit;
using System.Windows.Input;
using CollegeVS.Models;
using Xamarin.Forms;

namespace CollegeVS.ViewModels
{
    public class HighlightViewModel : BaseViewModel
    {

        public ObservableCollection<HomeModel> highlights { get; set; }

        private HomeModel currentItem;
        public HomeModel CurrentItem
        {
            get { return currentItem; }
            set { SetProperty(ref currentItem, value); }
        }
        public ICommand SetStatusCommand { get; set; }

        public ICommand RemoveStatusCommand { get; set; }










        public HighlightViewModel()
        {
            highlights = new ObservableCollection<HomeModel>()
            {
             
           new HomeModel(){
                ProfilePicture = "UserIcon.png",
                Username = "User Name",
                PostImage = "Harvard.jpg",
                PostDetail = "This is collegeVS",
                PostUpvoteCount = 100,
                PostCommentCount = "7",
                PostTime = "2 weeks",
                Seen = true,
                Back = false,
                College = "Harvard",
                Category = "clearbackgrounddorms.png",},
            new HomeModel(){
                ProfilePicture = "UserIcon.png",
                Username = "User Name",
                PostImage = "Harvard.jpg",
                PostDetail = "This is collegeVS",
                PostUpvoteCount = 100,
                PostCommentCount = "7",
                PostTime = "2 weeks",
                Seen = true,
                Back = false,
                College = "Harvard",
                Category = "clearbackgrounddorms.png",},

            };
            SetStatusCommand = new Command(SetStatus);
            RemoveStatusCommand = new Command(RemoveStatus);




        }

        void SetStatus()
        {
            

            if (currentItem != null)
            {
                // Change the value and update UI automatically
                currentItem.Seen = false;
                currentItem.Back = true;
            }




           

        }


        void RemoveStatus()
        {

            if (currentItem != null)
            {
                // Change the value and update UI automatically
                currentItem.Seen = true;
                currentItem.Back = false;
            }


        }




    }
}

