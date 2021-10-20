using CollegeVS.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Xamarin.Forms;
using FFImageLoading;
using CollegeVS.Services;
using CollegeVS.Models.API;
using System.Threading.Tasks;

namespace CollegeVS.ViewModels
{
    public class ProfileGalleryViewModel : BindableObject
    {




        private ObservableCollection<ProfileGalleryModel> _info;
        public ObservableCollection<ProfileGalleryModel> Info
        {
            get { return _info; }
            set
            {

                _info = value;

            }

        }


        
    

        public ProfileGalleryViewModel(IHomeAPIStore homeAPIStore)
        {
            Task.Run(async () => { homeAPIStore.HomeModel = await homeAPIStore.GetCLGVSProfile(homeAPIStore.State.User_ID, ContentLoadFilter.SPECIFIC_USER, SortContentBy.DATE_DESC); });

            

            Info = new ObservableCollection<ProfileGalleryModel>
            {
                new ProfileGalleryModel()
                {

                    Username = "@Username",
                    College = "Harvard",
                    Name = "User Name",
                    Followers = 111,
                    Following = 112,
                    ProfilePicture = "UserIcon.png",
                    Rank = 1400


                    }

                   };


          
        }



    }
}





          
