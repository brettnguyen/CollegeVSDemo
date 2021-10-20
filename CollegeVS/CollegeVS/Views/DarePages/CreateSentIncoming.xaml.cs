using System;
using System.Collections.Generic;
using CollegeVS.Models;
using CollegeVS.ViewModels;
using Xamarin.Forms;

namespace CollegeVS.Views
{
    public partial class CreateSentIncoming : ContentPage
    {

        public CreateSentIncoming()
        {
            
            InitializeComponent();
            BindingContext = new CreateSentIncomingViewModel();
            

        }

        
        protected override void OnAppearing()
        {
          
          
        }

      

        void TheCarousel_Scrolled(System.Object sender, Xamarin.Forms.ItemsViewScrolledEventArgs e)
        {
            if (TheCarousel.Position != 0)
                Create.Opacity = 0.6;

            else
                Create.Opacity = 1;

            if (TheCarousel.Position != 1)
                Sent.Opacity = 0.6;

            else
                Sent.Opacity = 1;

            if (TheCarousel.Position != 2)
                Incoming.Opacity = 0.6;

            else
                Incoming.Opacity = 1;



        }

       void Create_Tapped(object sender, EventArgs e)
        {

            TheCarousel.Position = 0;
            OnPropertyChanged("Position");
            if (TheCarousel.Position != 0)
                Create.Opacity = 0.6;

            else
                Create.Opacity = 1;

            if (TheCarousel.Position != 1)
                Sent.Opacity = 0.6;

            else
                Sent.Opacity = 1;

            if (TheCarousel.Position != 2)
                Incoming.Opacity = 0.6;

            else
                Incoming.Opacity = 1;

        }

         void Sent_Tapped(object sender, EventArgs e)
        {


            TheCarousel.Position = 1;
            OnPropertyChanged("Position");
            if (TheCarousel.Position != 0)
                Create.Opacity = 0.6;

            else
                Create.Opacity = 1;

            if (TheCarousel.Position != 1)
                Sent.Opacity = 0.6;

            else
                Sent.Opacity = 1;

            if (TheCarousel.Position != 2)
                Incoming.Opacity = 0.6;

            else
                Incoming.Opacity = 1;

        }

       void Incoming_Tapped(object sender, EventArgs e)
        {
            TheCarousel.Position = 2;
            OnPropertyChanged("Position");
            if (TheCarousel.Position != 0)
                Create.Opacity = 0.6;

            else
                Create.Opacity = 1;

            if (TheCarousel.Position != 1)
                Sent.Opacity = 0.6;

            else
                Sent.Opacity = 1;

            if (TheCarousel.Position != 2)
                Incoming.Opacity = 0.6;

            else
                Incoming.Opacity = 1;

        }


    }
}
