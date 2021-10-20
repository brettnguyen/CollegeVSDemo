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
    public partial class CheckDareView : MenuContainerPage
    {




		public ObservableCollection<HomeModel> checkdare { get; set; }
		public CheckDareView()
        {
            InitializeComponent();

			checkdare = new ObservableCollection<HomeModel>()
		{
			new HomeModel(){
				ProfilePicture = "UserIcon.png",
				Username = "Username",
				PostImage = "cvlogo.jpg",
				PostDetail = "This is collegeVS",
				PostUpvoteCount = 100,
				PostCommentCount = "7",
				PostTime = "2 weeks",

				College = "Plattsburgh",
				Category = "clearbackgroundparty.png",

				Seen = true,
				Back = false, }

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
		async void College_Tapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("School");
		}

		async void BackArrow_Clicked(object sender, EventArgs e)
		{
			await Shell.Current.Navigation.PopModalAsync();
		}
		void Comment_Clicked(Object sender, EventArgs e)
		{
			
			this.ShowMenu();

		}
		async void User_Clicked(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("OtherUserProfile");
			
		}

		

		async void User_Tapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("OtherUserProfile");

		}
	}
}