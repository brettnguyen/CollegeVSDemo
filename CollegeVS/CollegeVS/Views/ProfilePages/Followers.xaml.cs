using System;
using System.Collections.Generic;
using CollegeVS.ViewModels;
using Xamarin.Forms;

namespace CollegeVS.Views
{
    public partial class Followers : ContentView
    {
        public Followers()
        {
            BindingContext = new FollowingFollowersViewModel();
            InitializeComponent();
        }
    }
}
