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
        bool test;
        private ObservableCollection<HomeModel> _highlights;
        public ObservableCollection<HomeModel> highlights
        {
            get { return _highlights; }
            set { SetProperty(ref _highlights, value); }
        }
           

        private HomeModel currentItem2;
        public HomeModel CurrentItem2
        {
            get { return currentItem2; }
            set { SetProperty(ref currentItem2, value); }
        }

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

        public ICommand testCommand { get; }
      
        public Command<object> ItemAppearingCommand { get; set; }

        public Command<object> ItemDisappearingCommand { get; set; }

        public Command<object> ItemSwipedCommand { get; set; }






        public HighlightViewModel()
        {
            

           
            SetStatusCommand = new Command(SetStatus);
            RemoveStatusCommand = new Command(RemoveStatus);
            checkCommand = new Command(check);
            StopCommand = new AsyncCommand<MediaElement>(InvokePlayPauseCommandAsync);
         
            ItemAppearingCommand = new Command<object>(OnItemAppearing);
            ItemDisappearingCommand = new Command<object>(OnItemDisapearing);
            ItemSwipedCommand = new Command<object>(ItemSwiped);


        }

        private void ItemSwiped(object obj)
        {
           
        }

            private void OnItemDisapearing(object obj)
        {
           
            if (obj is ItemDisappearingEventArgs itemDisappearingEventArgs)
             {
            if (itemDisappearingEventArgs.Item is HomeModel item)
            {
                    
                    item.IsPlaying = false;
                    

             }
           }
        }


        private MediaElement _mediaElement;

        private void OnItemAppearing(object obj)
        {
          

            if (obj is ItemAppearingEventArgs itemAppearedEventArgs)
            {
                if (itemAppearedEventArgs.Item is HomeModel item)
                {
                    item.Stopped = false;
                    item.IsPlaying = true;
                   
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

            //   if (currentItem.PostVideo != null)
            //    {
            //    MediaElement mediaElement = new MediaElement();
            //   mediaElement.Pause();

            // }
          if( CurrentItem.Stopped == true)
            {
                CurrentItem.Stopped = false;
            }
          else
            {
                CurrentItem.Stopped = true;
            }
           // int index = highlights.IndexOf(obj);
            
            //highlights[index].Stopped = true;

            

            //highlights[index].Seen = false;
           // highlights[index].Back = true;

        }
        void SetStatus(Object obj)
        {
           
            if (currentItem != null)
            {
                // Change the value and update UI automatically
                currentItem.Seen = false;
                currentItem.Back = true;
            }

        }


        void RemoveStatus(Object obj)
        {

            if (currentItem != null)
            {
                // Change the value and update UI automatically
                currentItem.Seen = true;
                currentItem.Back = false;
            }


        }

        public void OnAppearing()
        {
            IsBusy = true;



            
            CreateItems();
           
            IsBusy = false;
        }
        public  void OnDisappearing()
        {
            IsBusy = true;
            CurrentItem.Stopped = true;
             highlights = new ObservableRangeCollection<HomeModel>();
            IsBusy = false;
        }
       

            private void CreateItems()
        {
            highlights = new ObservableCollection<HomeModel>()
            {


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
              new HomeModel(){
                ProfilePicture = "UserIcon.png",
                Username = "User Name",
             
                //PostImage = "Harvard.jpg",
                PostVideo = "https://sec.ch9.ms/ch9/5d93/a1eab4bf-3288-4faf-81c4-294402a85d93/XamarinShow_mid.mp4",
                PostDetail = "This is collegeasgargwegwaegwaegwegwaegeawVS",
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

