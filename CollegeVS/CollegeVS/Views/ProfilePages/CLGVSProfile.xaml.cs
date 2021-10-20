using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeVS.Models;
using CollegeVS.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SlideOverKit;

using FFImageLoading;
using Plugin.DeviceOrientation;
using Xamarin.Essentials;
using System.ComponentModel;

namespace CollegeVS.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	
	public partial class CLGVSProfile : MenuContainerPage
	{


		public CLGVSProfile()
		{
			
			InitializeComponent(); 
			BindingContext = Startup.ServiceProvider.GetService<ProfileGalleryViewModel>();

			this.SlideMenu = new RankAndAccoladesMenu();

			List<ProfileGalleryModel> ProfileGalleryModels = new List<ProfileGalleryModel>();

			ProfileGalleryModels.Add(new ProfileGalleryModel
			{

				GalleryImage = "Harvard.jpg"

			});
			ProfileGalleryModels.Add(new ProfileGalleryModel
			{

				GalleryImage = "SUNYPlattsburgh.jpg"

			});

			ProfileGalleryModels.Add(new ProfileGalleryModel
			{

				GalleryImage = "cvlogo.jpg"

			});


			ListImages.BindingContext = ProfileGalleryModels;

		}





		async void EditProfile_Tapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("EditProfile");

		}

		void MenuRank_Tapped(object sender, EventArgs e)
        {

			this.ShowMenu();

		}
	

		async void ViewProfilePic_Tapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("ProfilePic");
		}

		async void Following_Tapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("FollowingFollowers");
		}

		async void Followers_Tapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("FollowersFollowing");
		}
	}
}