using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CollegeVS.Views
{
    public partial class LeaderboardContent : ContentView
    {
        public LeaderboardContent()
        {
            InitializeComponent();
        }

        void Expander_PropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

            if (ExpanderLeader.IsExpanded != true)
                BlueArrow.Rotation = 90;
            else
                BlueArrow.Rotation = 180;

            if (ExpanderLeader.IsExpanded != true)
                ExitExpander.IsVisible = false;
            else
                ExitExpander.IsVisible = true ;




        }

        void ExitExpander_Tapped(System.Object sender, System.EventArgs e)
        {
            ExpanderLeader.IsExpanded = false ;

            ExitExpander.IsVisible = false;
        }

        


    }
}
