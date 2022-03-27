using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeVS.Models;
using CollegeVS.ViewModels;
using SlideOverKit;
using Xamarin.CommunityToolkit.UI.Views;
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
				PostVideo = "https://sec.ch9.ms/ch9/5d93/a1eab4bf-3288-4faf-81c4-294402a85d93/XamarinShow_mid.mp4",
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
				PostVideo = "https://sec.ch9.ms/ch9/5d93/a1eab4bf-3288-4faf-81c4-294402a85d93/XamarinShow_mid.mp4",
				Seen = true,
				Back = false,
				College = "Plattsburgh",
				Title = "#1 Sports Post",
				Category = "clearbackgroundsports.png"},

			


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
			

			//this.ShowMenu();

		}
		async void College_Tapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("Schoolpage");
		}

		async void User_Tapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("OtherUserProfile");

		}
		
		List<MediaElement> mediaElements = new List<MediaElement>();
//
		MediaElement mediaElement = new MediaElement();
	
	void previewVideo_BindingContextChanged(System.Object sender, System.EventArgs e)
        {
		
			
			var element = sender as MediaElement;
			mediaElements.Add(element);
			mediaElement = sender as MediaElement;
		//	
				
			
		}

        void ListPosts_PositionChanged(System.Object sender, Xamarin.Forms.PositionChangedEventArgs e)
        {

			if (ListPosts.IsDragging == false)
			{
			mediaElements[e.PreviousPosition].Stop();
				mediaElements[e.PreviousPosition].Pause();

			}
			
			if (ListPosts.IsDragging == true)
			{
				mediaElements[e.PreviousPosition].Pause();
			}
			
			

		}
		protected override void OnAppearing()
		{
			base.OnAppearing();
		

		}
		void ListPosts_CurrentItemChanged(System.Object sender, Xamarin.Forms.CurrentItemChangedEventArgs e)
        {
			
			//mediaElement.Pause();

		}

		void ListPosts_Scrolled(System.Object sender, Xamarin.Forms.ItemsViewScrolledEventArgs e)
		{

		
		if(ListPosts.IsDragging == true)
			{
				mediaElements[e.FirstVisibleItemIndex].Pause();
				mediaElements[e.CenterItemIndex].Pause();
				
			}
			if (ListPosts.IsDragging == false)
			{
				
				mediaElements[e.CenterItemIndex].Play();
			}
		}

       void ListPosts_RemainingItemsThresholdReached(System.Object sender, System.EventArgs e)
        {
			
		}

        void previewVideo_PropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
			if(ListPosts.IsDragging == true)
            {
				if(ListPosts.Position != null)
                {
					mediaElement.Pause();
				}
				
			}
		}


    }

}