using System;
using System.Collections.Generic;
using CollegeVS.ViewModels;
using Xamarin.Forms;

namespace CollegeVS.Views
{
    public partial class Following : ContentView
    {
        public Following()
        {
            BindingContext = new FollowingFollowersViewModel();
            InitializeComponent();
        }
    }
}
