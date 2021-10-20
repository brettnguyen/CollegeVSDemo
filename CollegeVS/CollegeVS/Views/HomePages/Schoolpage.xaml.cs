using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeVS.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SlideOverKit;
using CollegeVS.ViewModels;
using System.Collections.ObjectModel;

namespace CollegeVS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Schoolpage : MenuContainerPage
    {

		public ObservableCollection<HomeModel> schools { get; set; }
		public Schoolpage()
        {
            InitializeComponent();
			schools = new ObservableCollection<HomeModel>()
		{
			new HomeModel(){
				  ProfilePicture = "UserIcon.png",
				Username = "Username",
				PostImage = "SUNYPlattsburgh",
				PostDetail = "This is collegeVS",
				PostUpvoteCount = 100,
				PostCommentCount = "7",
				PostTime = "2 weeks",
				Seen = true,
				Back = false,
				College = "Plattsburgh",
				Category = "clearbackgroundparty.png"},
			new HomeModel(){
				  ProfilePicture = "UserIcon.png",
				Username = "SUNYPlattsburgh",
				PostImage = "cvlogo.jpg",
				PostDetail = "This is collegeVS",
				PostUpvoteCount = 90,
				PostCommentCount = "7",
				PostTime = "1 week",
				Seen = true,
				Back = false,
				College = "Plattsburgh",
				Category = "clearbackgroundsports.png"},

			new HomeModel(){ ProfilePicture = "UserIcon.png",
				Username = "Username",
				PostImage = "cvlogo.jpg",
				PostDetail = "This is collegeVS",
				PostUpvoteCount = 80,
				PostCommentCount = "7",
				PostTime = "15 mins",
				Seen = true,
				Back = false,
				College = "Plattsburgh",
				Category = "clearbackgroundother.png"
				  },
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
				Category = "clearbackgrounddorms.png"
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
				Category = "clearbackgroundclubs.png"
				  },

		};
			this.BindingContext = this;
			this.SlideMenu = new CommentSlideUp();
			this.PopupViews.Add("FirstPopup", new SortPopup());
			this.PopupViews.Add("SecondPopup", new SchoolInfoPopUp());

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


		async void BackArrow_Tapped(object sender, EventArgs e)
        {
			await Shell.Current.Navigation.PopToRootAsync();
		}

		void Sort_Tapped(object sender, EventArgs e)
		{

			this.ShowPopup("FirstPopup");


		}

		void Comment_Clicked(Object sender, EventArgs e)
		{

			this.ShowMenu();

		}


		async void User_Tapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("OtherUserProfile");

		}


		void InfoIcon_Tapped(object sender, EventArgs e)
		{
			

		}

		void InfoIcon2_Tapped(object sender, EventArgs e)
		{
			
		}


		void Post_Tapped(object sender, EventArgs e)
		{

			
		}

		public void ExpandInfo_Changed(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			


		}

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
			this.ShowPopup("SecondPopup");
		}
    }
}