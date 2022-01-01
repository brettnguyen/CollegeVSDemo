using System;
using System.Collections.Generic;
using CollegeVS.ViewModels;
using Xamarin.Forms;

namespace CollegeVS.Views.Comment
{
    public partial class UserComment : ContentView
    {
        public UserComment()
        {
            InitializeComponent();
            BindingContext = new CommentViewModel();
        }
    }
}
