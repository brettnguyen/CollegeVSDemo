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
using PanCardView;
using Lottie.Forms;
using Xamarin.CommunityToolkit.UI.Views;

namespace CollegeVS.Views
{


	[XamlCompilation(XamlCompilationOptions.Compile)]
	[DesignTimeVisible(false)]






	public partial class CLGVSHome : MenuContainerPage
	{

		private readonly HighlightViewModel _highlightViewModel;
		public CLGVSHome()
		{


			InitializeComponent();
			_highlightViewModel = new HighlightViewModel();
			BindingContext = _highlightViewModel;
			

			
		
			this.SlideMenu = new CommentSlideUp();


			









			this.PopupViews.Add("FirstPopup", new SortPopup());

			

		}

		//protected override async void OnAppearing()
		//{
		//	BindingContext.
		//}

		

		void Sort_Clicked(object sender, EventArgs e)
		{

			this.ShowPopup("FirstPopup");


		}

	//	void Comment_Clicked(Object sender, EventArgs e)
		//{

		//	this.ShowMenu();

			


	//	}

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
			//mediaElement.Stop();
			_highlightViewModel.OnAppearing();

			
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			
			_highlightViewModel.OnDisappearing();
		}

		void Info_Clicked(object sender, EventArgs e)
		{
			ExitFrame.IsVisible = true;
			ExpandInfo.IsExpanded = true;
			Info.IsVisible = false;
			Info2.IsVisible = true;
			RandomBar.IsVisible = true;
			ListPosts.IsEnabled = false;
		}

		void Info2_Clicked(object sender, EventArgs e)
		{
			ExitFrame.IsVisible = false;
			ExpandInfo.IsExpanded = false;
			Info.IsVisible = true;
			Info2.IsVisible = false;
			RandomBar.IsVisible = false;
			ListPosts.IsEnabled = true;
		}

		void Post_Tapped(object sender, EventArgs e)
		{

			ExitFrame.IsVisible = false;
			ExpandInfo.IsExpanded = false;

			Info.IsVisible = true;
			Info2.IsVisible = false;
			RandomBar.IsVisible = false;
			ListPosts.IsEnabled = true;
		}

		public void ExpandInfo_Changed(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (ExpandInfo.IsExpanded != true)
				
			ListPosts.IsEnabled = true;

			else
				
			ListPosts.IsEnabled = false;

			if (ExpandInfo.IsExpanded != true)

				ExitFrame.IsVisible = false;

			else

				ExitFrame.IsVisible = true;



		}
	//	List<MediaElement> mediaElements = new List<MediaElement>();
	//	MediaElement mediaElement = new MediaElement();

	//	void previewVideo_BindingContextChanged(System.Object sender, System.EventArgs e)
	//	{
		//	mediaElement = sender as MediaElement;

		//	var element = sender as MediaElement;
//
		//	mediaElements.Add(element);

		//}

	

     //   void ListPosts_ItemAppearing(PanCardView.CardsView view, PanCardView.EventArgs.ItemAppearingEventArgs args)
     // {

			//mediaElement.Play();
			//mediaElements[args.Index].Play();
			//mediaElements[args.Index].Stop();

			//	
		//}

     // void ListPosts_ItemDisappearing(PanCardView.CardsView view, PanCardView.EventArgs.ItemDisappearingEventArgs args)
     //  {

			//mediaElement.Pause();
			//mediaElement.Stop();

			//mediaElement.Pause();
			//mediaElement.Pause();
			//mediaElement.Pause();


			//mediaElements[args.Index].Pause();



//
	//	}

       
        void ListPosts_UserInteracted(PanCardView.CardsView view, PanCardView.EventArgs.UserInteractedEventArgs args)
        {
			


		}

       

      async  void ListPosts_ItemSwiped(PanCardView.CardsView view, PanCardView.EventArgs.ItemSwipedEventArgs args)
        {
		
			

		
		}

		void ListPosts_ItemAppeared(PanCardView.CardsView view, PanCardView.EventArgs.ItemAppearedEventArgs args)
        {
			//ListPosts.IsNextItemPanInteractionEnabled = false;
		
			//ListPosts.IsPrevItemPanInteractionEnabled = true;
		}

    


		

    

		//ItemAppearingCommand="{Binding ItemAppearingCommand}"
          //ItemDisappearingCommand="{Binding ItemDisappearingCommand}"


    }
}