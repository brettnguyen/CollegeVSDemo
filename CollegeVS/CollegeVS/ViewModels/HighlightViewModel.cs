using System;
using System.Collections.Generic;
using Lottie.Forms;
using System.Collections.ObjectModel;
using System.Linq;
using SlideOverKit;

using Xamarin.Essentials;
using System.Windows.Input;
using CollegeVS.Models;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.CommunityToolkit.ObjectModel;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using PanCardView.EventArgs;

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


        public ICommand checkCommand { get; }

        

        public ICommand StopCommand { get; }

        public Command<object> ItemAppearingCommand { get; set; }

        public Command<object> ItemDisappearingCommand { get; set; }






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
                Category = "clearbackgrounddorms.png",
                commentid = 0},
            new HomeModel(){
                ProfilePicture = "UserIcon.png",
                Username = "User Name",
                //PostImage = "Harvard.jpg",
                PostVideo = "https://sec.ch9.ms/ch9/5d93/a1eab4bf-3288-4faf-81c4-294402a85d93/XamarinShow_mid.mp4",
                PostDetail = "This is collegeVS",
                PostUpvoteCount = 100,
                PostCommentCount = "7",
                PostTime = "2 weeks",
                Seen = true,
                Back = false,
                College = "Harvard",
                Category = "clearbackgrounddorms.png",
                commentid = 1,
            },

            };
            SetStatusCommand = new Command(SetStatus);
            RemoveStatusCommand = new Command(RemoveStatus);
            checkCommand = new Command(check);
            StopCommand = new AsyncCommand<MediaElement>(InvokePlayPauseCommandAsync);

            ItemAppearingCommand = new Command<object>(OnItemAppearing);
            ItemDisappearingCommand = new Command<object>(OnItemDisapearing);

          
        }

        private void OnItemDisapearing(object obj)
        {
            if (obj is MediaElement mediaElement)
            {
                if (currentItem.PostVideo == null)
                {
                    mediaElement.Pause();
                }
            }
            //if (obj is ItemDisappearingEventArgs itemDisappearingEventArgs)
            // {
            //if (itemDisappearingEventArgs.Item is HomeModel item)
            //{
            //    item.IsPlaying = false;
            //}
            // }
        }

        private void OnItemAppearing(object obj)
        {
            if (obj is MediaElement mediaElement)
            {
               
                if (currentItem.PostVideo != null)
                {
                    
                    mediaElement.Play();
                }
            }
            //if (obj is ItemAppearingEventArgs itemAppearedEventArgs)
            //{
            //if (itemAppearedEventArgs.Item is HomeModel item)
            //{
            //  item.IsPlaying = true;
            // }
            // }
        }
        private Task InvokePlayPauseCommandAsync(MediaElement mediaElement)
        {
            if (mediaElement.CurrentState == MediaElementState.Playing)
            {
                mediaElement.Pause();
            }
            else
            {
                mediaElement.Play();
            }
            return Task.CompletedTask;
        }


        void check(object obj)
        {
            if (obj is MediaElement mediaElement)
            {
                if (currentItem.PostVideo != null)
                {
                    mediaElement.Pause();
                }
            }
          
           
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

        public async void OnAppearing()
        {
            IsBusy = true;

            CreateItems();
            await Task.Delay(2500);
            IsBusy = false;
        }
        public  void OnDisappearing()
        {
            highlights.Clear();
        }
        private void CreateItems()
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
                Category = "clearbackgrounddorms.png",
                commentid = 0},
            new HomeModel(){
                ProfilePicture = "UserIcon.png",
                Username = "User Name",
                //PostImage = "Harvard.jpg",
                PostVideo = "https://sec.ch9.ms/ch9/5d93/a1eab4bf-3288-4faf-81c4-294402a85d93/XamarinShow_mid.mp4",
                PostDetail = "This is collegeVS",
                PostUpvoteCount = 100,
                PostCommentCount = "7",
                PostTime = "2 weeks",
                Seen = true,
                Back = false,
                College = "Harvard",
                Category = "clearbackgrounddorms.png",
                commentid = 1,
            },

            };

            CurrentItem = highlights[0];
        }

        }
}

