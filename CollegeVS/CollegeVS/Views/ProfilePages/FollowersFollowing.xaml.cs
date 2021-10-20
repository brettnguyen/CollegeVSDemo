using System;
using System.Collections.Generic;
using CollegeVS.ViewModels;
using Xamarin.Forms;

namespace CollegeVS.Views
{
    public partial class FollowersFollowing : ContentPage
    {
        public FollowersFollowing()
        {
            BindingContext = new FollowingFollowersViewModel();
            InitializeComponent();
        }
        async void BackArrow_Clicked(object sender, EventArgs e)
        {

            await Shell.Current.Navigation.PopToRootAsync();
        }

        public void Followers_Tapped(object sender, EventArgs e)
        {

            TheCarousel.Position = 0;
            OnPropertyChanged("Position");
            if (TheCarousel.Position != 0)
                TheFollower.TextColor = Color.LightGray;
            else
                TheFollower.TextColor = Color.White;
        }

        public void Following_Tapped(object sender, EventArgs e)
        {

            TheCarousel.Position = 1;
            OnPropertyChanged("Position");

            if (TheCarousel.Position != 1)
                TheFollowing.TextColor = Color.LightGray;
            else
                TheFollowing.TextColor = Color.White;
        }




        void TheCarousel_Scrolled(System.Object sender, Xamarin.Forms.ItemsViewScrolledEventArgs e)
        {

            if (TheCarousel.Position != 0)
                TheFollower.TextColor = Color.LightGray;
            else
            TheFollower.TextColor = Color.White;
            

            if (TheCarousel.Position != 1)
                TheFollowing.TextColor = Color.LightGray;
            else
            TheFollowing.TextColor = Color.White;

            






        }
    }
}