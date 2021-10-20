using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CollegeVS.ViewModels;

namespace CollegeVS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Notifications : ContentPage
    {
        public class NotificationInfo
        {
           public string PostImage { get; set; }
           public string PostCommentImage { get; set; }
            public string ChallengeImage { get; set; }
            public string UserImage { get; set; }
            public string Username { get; set; }
            public string Details { get; set; }

         
        }

        List<NotificationInfo> list;



        public Notifications()
        {
            InitializeComponent();
         

            list = new List<NotificationInfo>();

            list.Add(new NotificationInfo
            {
              PostImage = "cvlogo.jpg",
              Username = "Your post",
                Details = "recieved 1 Upvote",
                                PostCommentImage = null

            });

            list.Add(new NotificationInfo
            {
                UserImage = "SteveHarvey.jpg",
                Username = "SteveHarvey",
                Details = "commented on your post",
                PostCommentImage = "cvlogo.jpg"

            });

            list.Add(new NotificationInfo
            {
               ChallengeImage = "checkmark",
               Username = "You completed",
                Details = "a challenge you gained 10 points",
                PostCommentImage = null

            });

            list.Add(new NotificationInfo
            {
                UserImage = "SteveHarvey.jpg",
                Username = "SteveHarvey",
                Details = "followed you",
                PostCommentImage = null



            });

            NotificationInfos.ItemsSource = list;

            this.BindingContext = new NotificationsViewModel();
        }

    }
        
    }
