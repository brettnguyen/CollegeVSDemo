using System;
using System.Collections.Generic;
using CollegeVS.ViewModels;
using Xamarin.Forms;

namespace CollegeVS.Views.Comment
{
    public partial class OtherUser : ContentView
    {
        public OtherUser()
        {
            InitializeComponent();
            BindingContext = new CommentViewModel();
        }

       
    }
}
