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
		private readonly HighlightViewModel _highlightViewModel;
		public HighlightPage()
		{
			InitializeComponent();

			_highlightViewModel = new HighlightViewModel();
			BindingContext = _highlightViewModel;

			Device.BeginInvokeOnMainThread(async () =>
			{
				//_highlightViewModel.OnAppearing();
			});
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
			//await Shell.Current.GoToAsync("OtherUserProfile");

			if (ListPosts.Position > 0)
			{
				ListPosts.Position--;
			}

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
			
			if (mediaElements != null)
			{
				if (ListPosts.CurrentItem == ListPosts.CurrentItem)
				{
					//mediaElements[e.PreviousPosition].Pause();
					//mediaElements[e.CurrentPosition].Play();


				}
			}
			else
            {

            }

			
			
			

		}
		protected override void OnAppearing()
		{
			base.OnAppearing();

			_highlightViewModel.OnAppearing();


		}


		protected override void OnDisappearing()
		{
			base.OnDisappearing();



			_highlightViewModel.Gone();
		}
		void ListPosts_CurrentItemChanged(System.Object sender, Xamarin.Forms.CurrentItemChangedEventArgs e)
        {
			
			//mediaElement.Pause();

		}

		void ListPosts_Scrolled(System.Object sender, Xamarin.Forms.ItemsViewScrolledEventArgs e)
		{
			if (mediaElements != null)
			{
				if (ListPosts.IsDragging == true)
				{
					//mediaElements[e.CenterItemIndex].Pause();
					//mediaElements[e.FirstVisibleItemIndex].Pause();
					//mediaElements[e.FirstVisibleItemIndex].Stop();
					//mediaElements[e.LastVisibleItemIndex].Pause();
				}
				else
				{
					//mediaElements[e.FirstVisibleItemIndex].Play();
					//mediaElements[e.LastVisibleItemIndex].Pause();
				}
			}

			else
            {

            }

		}

     

        void previewVideo_PropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
			
		}


    }

}