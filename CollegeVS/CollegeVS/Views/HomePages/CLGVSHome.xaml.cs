using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using CollegeVS.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CollegeVS.Models;
using CollegeVS.Views;
using System.ComponentModel;
using SlideOverKit;
using Lottie.Forms;

namespace CollegeVS.Views
{


	[XamlCompilation(XamlCompilationOptions.Compile)]
	[DesignTimeVisible(false)]






	public partial class CLGVSHome : MenuContainerPage
	{

		public ObservableCollection<HomeModel> Items { get; set; }
		public CLGVSHome()
		{


			InitializeComponent();
			//this.BindingContext = new CLGVSHomeViewModel();
			//BindingContext = Startup.ServiceProvider.GetService<CLGVSHomeViewModel>();

			Items = new ObservableCollection<HomeModel>()
		{
			new HomeModel(){
				ProfilePicture = "UserIcon.png",
				Username = "User Name",
				PostImage = "Harvard.jpg",
				PostDetail = "This is collegeVS",
				PostUpvoteCount = 100,
				PostCommentCount = "7",
				PostTime = "2 weeks",
				Seen = true,
				Back = false,
				College = "Harvard",
				Category = "clearbackgrounddorms.png",},
			new HomeModel(){
				ProfilePicture = "UserIcon.png",
				Username = "User Name",
				PostImage = "Harvard.jpg",
				PostDetail = "This is collegeVS",
				PostUpvoteCount = 100,
				PostCommentCount = "7",
				PostTime = "2 weeks",
				Seen = true,
				Back = false,
				College = "Harvard",
				Category = "clearbackgrounddorms.png",},
			
		};
			this.BindingContext = this;
		
			this.SlideMenu = new CommentSlideUp();

		





		




			this.PopupViews.Add("FirstPopup", new SortPopup());

			FillInfo();

		}

		//protected override async void OnAppearing()
		//{
		//	BindingContext.
		//}

		void Upvote_Tapped(System.Object sender, System.EventArgs e)
		{
			HomeModel homeModel = ListPosts.CurrentItem as HomeModel;
			homeModel.Seen = false;
			homeModel.Back = true;
		}

		void Remove_Tapped(System.Object sender, System.EventArgs e)
		{

			HomeModel homeModel = ListPosts.CurrentItem as HomeModel;
			homeModel.Seen = true;
			homeModel.Back = false;
		}

		void Sort_Clicked(object sender, EventArgs e)
		{

			this.ShowPopup("FirstPopup");


		}

		void Comment_Clicked(Object sender, EventArgs e)
		{

			this.ShowMenu();

		}

		void Options_Clicked(Object sender, EventArgs e)
		{
			Shell.Current.FlyoutIsPresented = true;

		}
		async void Challenge_Tapped(object sender, EventArgs e)
		{


			await Shell.Current.GoToAsync("Challenge");
		}




		async void Leaderboard_Tapped(object sender, EventArgs e)
		{


			await Shell.Current.GoToAsync("Leaderboard");

		}

	

		async void College_Tapped(object sender, EventArgs e)
		{

			await Shell.Current.GoToAsync("Schoolpage");
		}



		async void User_Tapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("OtherUserProfile");

		}





		protected override void OnAppearing()
		{
			base.OnAppearing();

			FillInfo();
		}

		public void FillInfo()
		{



		}

		void Info_Clicked(object sender, EventArgs e)
		{
			ExitFrame.IsVisible = true;
			ExpandInfo.IsExpanded = true;
			Info.IsVisible = false;
			Info2.IsVisible = true;
			RandomBar.IsVisible = true;
			ListPosts.IsSwipeEnabled = false;
		}

		void Info2_Clicked(object sender, EventArgs e)
		{
			ExitFrame.IsVisible = false;
			ExpandInfo.IsExpanded = false;
			Info.IsVisible = true;
			Info2.IsVisible = false;
			RandomBar.IsVisible = false;
			ListPosts.IsSwipeEnabled = true;
		}

		void Post_Tapped(object sender, EventArgs e)
		{

			ExitFrame.IsVisible = false;
			ExpandInfo.IsExpanded = false;

			Info.IsVisible = true;
			Info2.IsVisible = false;
			RandomBar.IsVisible = false;
			ListPosts.IsSwipeEnabled = true;
		}

		public void ExpandInfo_Changed(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (ExpandInfo.IsExpanded != true)
				
			ListPosts.IsSwipeEnabled = true;

			else
				
			ListPosts.IsSwipeEnabled = false;

			if (ExpandInfo.IsExpanded != true)

				ExitFrame.IsVisible = false;

			else

				ExitFrame.IsVisible = true;



		}





	}
}