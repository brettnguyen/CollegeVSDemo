using System;
using CollegeVS.Models;
using Xamarin.Forms;

namespace CollegeVS.Controls
{
    public class FollowingFollowersDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate FollowingTemp { get; set; }
        public DataTemplate FollowersTemp { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {

            return ((FollowingFollowersModel)item).Nothing.Contains("Nothing") ? FollowingTemp : FollowersTemp;

        }


    }
}
