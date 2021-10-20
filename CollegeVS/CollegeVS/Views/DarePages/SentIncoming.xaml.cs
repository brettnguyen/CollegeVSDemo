using System;
using System.Collections.Generic;
using CollegeVS.Models;
using CollegeVS.ViewModels;
using Xamarin.Forms;

namespace CollegeVS.Views
{
    public partial class SentIncoming : ContentPage
    {
        public SentIncoming()
        {
            InitializeComponent();
            BindingContext = new CreateSentIncomingViewModel();


        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


           

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();


            


        }

        void TheCarousel_Scrolled(System.Object sender, Xamarin.Forms.ItemsViewScrolledEventArgs e)
        {
            if (TheCarousel.Position != 0)
                CreateDare.TextColor = Color.LightGray;

            else
                CreateDare.TextColor = Color.White;

            if (TheCarousel.Position != 1)
                SentDare.TextColor = Color.LightGray;

            else
                SentDare.TextColor = Color.White;

            if (TheCarousel.Position != 2)
                IncomingDare.TextColor = Color.LightGray;

            else
                IncomingDare.TextColor = Color.White;



        }

        void Create_Tapped(object sender, EventArgs e)
        {

            TheCarousel.Position = 0;
            OnPropertyChanged("Position");
            if (TheCarousel.Position != 0)
                CreateDare.TextColor = Color.LightGray;

            else
                CreateDare.TextColor = Color.White;

            if (TheCarousel.Position != 1)
                SentDare.TextColor = Color.LightGray;

            else
                SentDare.TextColor = Color.White;

            if (TheCarousel.Position != 2)
                IncomingDare.TextColor = Color.LightGray;

            else
                IncomingDare.TextColor = Color.White;

        }

        void Sent_Tapped(object sender, EventArgs e)
        {


            TheCarousel.Position = 1;
            OnPropertyChanged("Position");
            if (TheCarousel.Position != 0)
                CreateDare.TextColor = Color.LightGray;

            else
                CreateDare.TextColor = Color.White;

            if (TheCarousel.Position != 1)
                SentDare.TextColor = Color.LightGray;

            else
                SentDare.TextColor = Color.White;

            if (TheCarousel.Position != 2)
                IncomingDare.TextColor = Color.LightGray;

            else
                IncomingDare.TextColor = Color.White;

        }

        void Incoming_Tapped(object sender, EventArgs e)
        {
            TheCarousel.Position = 2;
            OnPropertyChanged("Position");
            if (TheCarousel.Position != 0)
                CreateDare.TextColor = Color.LightGray;

            else
                CreateDare.TextColor = Color.White;

            if (TheCarousel.Position != 1)
                SentDare.TextColor = Color.LightGray;

            else
                SentDare.TextColor = Color.White;

            if (TheCarousel.Position != 2)
                IncomingDare.TextColor = Color.LightGray;

            else
                IncomingDare.TextColor = Color.White;

        }
    }
}
