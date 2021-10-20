using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using CollegeVS.Models;
namespace CollegeVS.ViewModels
{
    public class FollowingFollowersViewModel : BindableObject
    {

        private ObservableCollection<FollowingFollowersModel> info;
        public ObservableCollection<FollowingFollowersModel> Info
        {
            get { return info; }
            set
            {

                info = value;
                OnPropertyChanged();
            }

        }

        private ObservableCollection<FollowingModel> following;
        public ObservableCollection<FollowingModel> Following
        {
            get { return following; }
            set
            {

                following = value;
                OnPropertyChanged();
            }

        }

        private ObservableCollection<FollowersModel> followers;
        public ObservableCollection<FollowersModel> Followers
        {
            get { return followers; }
            set
            {

                followers = value;
                OnPropertyChanged();
            }

        }

        public FollowingFollowersViewModel()
        {

            Info = new ObservableCollection<FollowingFollowersModel>
            {
                new FollowingFollowersModel()
                {
                    Nothing ="Nothing"
                },
                new FollowingFollowersModel()
                {
                    Nothing ="Empty"
                }


            };

            Following = new ObservableCollection<FollowingModel>(new List<FollowingModel>
            {
               new FollowingModel {FollowingUsername = "James", FollowingProfilePic = "SteveHarvey.jpg", FollowingRealName = "James", Visible = "True", VisibleTwo ="False"  }

            });

            Followers = new ObservableCollection<FollowersModel>(new List<FollowersModel>
            {
                new FollowersModel { FollowerUsername ="SteveHarvey", FollowerProfilePic = "SteveHarvey.jpg", FollowerRealName = "Steve Harvey", Visible = "True", VisibleTwo ="False" },
                new FollowersModel { FollowerUsername ="SteveHarvey", FollowerProfilePic = "SteveHarvey.jpg", FollowerRealName = "Steve Harvey" , Visible = "False", VisibleTwo ="True" }

            });
        }
    }
}
