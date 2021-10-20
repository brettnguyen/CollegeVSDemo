using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeVS.Models;
using CollegeVS.ViewModels;
using SlideOverKit;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollegeVS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HighlightPage : MenuContainerPage
    {
		public ObservableCollection<HomeModel> highlights { get; set; }
		public HighlightPage()
		{
			InitializeComponent();
			highlights = new ObservableCollection<HomeModel>()
		{
			new HomeModel(){
				ProfilePicture = "UserIcon.png",
				Username = "SteveHarvey",
				PostImage = "SUNYPlattsburgh.jpg",
				PostDetail = "This is collegeVS",
				PostUpvoteCount = 100,
				PostCommentCount = "7",
				PostTime = "2 weeks",

				College = "Plattsburgh",
				Title = "#1 Party Post",
				Category = "clearbackgroundparty.png",
				Seen = true,
				Back = false,},

			new HomeModel(){
				ProfilePicture = "UserIcon.png",
				Username = "Username",
				PostImage = "cvlogo.jpg",
				PostDetail = "This is collegeVS",
				PostUpvoteCount = 90,
				PostCommentCount = "7",
				PostTime = "1 week",
				Seen = true,
				Back = false,
				College = "Plattsburgh",
				Title = "#1 Sports Post",
				Category = "clearbackgroundsports.png"},

			new HomeModel(){
				ProfilePicture = "UserIcon.png",
				Username = "Username",
				PostImage = "Harvard.jpg",
				PostDetail = "This is collegeVS",
								Seen = true,
				Back = false,
				PostUpvoteCount = 80,
				PostCommentCount = "7",
				PostTime = "15 mins",

				College = "Harvard",
				Title = "#1 Dorms Post",
				Category = "clearbackgrounddorms.png"},

			new HomeModel(){
				ProfilePicture = "UserIcon.png",
				Username = "Username",
				PostImage = "cvlogo.jpg",
				PostDetail = "This is collegeVS",
				PostUpvoteCount = 70,
				PostCommentCount = "7",
				PostTime = "1 hour",
								Seen = true,
				Back = false,
				College = "Plattsburgh",
				Title = "#1 Clubs Post",
				Category = "clearbackgroundclubs.png"
				},

			new HomeModel(){
				ProfilePicture = "UserIcon.png",
				Username = "Username",
				PostImage = "cvlogo.jpg",
				PostDetail = "This is collegeVS",
				PostUpvoteCount = 60,
				PostCommentCount = "7",
				PostTime = "15 hours",
								Seen = true,
				Back = false,
				College = "Plattsburgh",
				Title = "#1 Food Post",
				Category = "clearbackgroundfood.png"},

	new HomeModel(){
				ProfilePicture = "SteveHarvey.jpg",
				Username = "SteveHarvey",
				PostImage = "cvlogo.jpg",
				PostDetail = "This is collegeVS",
				PostUpvoteCount = 60,
				PostCommentCount = "7",
				PostTime = "15 hours",
								Seen = true,
				Back = false,
				College = "Plattsburgh",
				Title = "#1 Other Post",
				Category = "clearbackgroundother.png"},


		};
			this.BindingContext = this;

			this.SlideMenu = new CommentSlideUp();



		

		

		}
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
		void Comment_Clicked(Object sender, EventArgs e)
		{

			this.ShowMenu();

		}
		async void College_Tapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("Schoolpage");
		}

		async void User_Tapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("OtherUserProfile");

		}
	}

}