using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Android.Content;
using CollegeVS.ViewModels;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Xamarin.CommunityToolkit.Core;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollegeVS.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Post : ContentPage
	{
		public static event EventHandler<ImageSource> PhotoCapturedEvent;
		public static event EventHandler<MediaSource> VideoCapturedEvent;
		public static event EventHandler<int> CameraOrientationEvent;
		public Post()
		{

			InitializeComponent();
			this.BindingContext = new PostViewModel();
			PhotoCapturedEvent += (sender, source) =>
			{
				Capture.IsVisible = false;
				cameraView.IsVisible = false;
				previewPicture.IsVisible = true;
				Exit.IsVisible = true;
				Next.IsVisible = true;
				Dare.IsVisible = true;
				//Filters.IsVisible = true;
				//Gallery.IsVisible = true;
				EditorPancakeView.IsVisible = true;
				BottomPancakeView.IsVisible = true;
				previewPicture.Source = source;
				//previewPicture.Rotation = 270;
				//previewPicture.RotationY = 180;
				//previewPicture.HeightRequest = 4000;
				//previewPicture.WidthRequest = 640;
				//previewPicture.Aspect = (Aspect)1;
			};

			VideoCapturedEvent += (sender, source) =>
			{
				Capture.IsVisible = false;
				cameraView.IsVisible = false;
				Exit.IsVisible = true;
				Next.IsVisible = true;
				Dare.IsVisible = true;
				//Filters.IsVisible = true;
				//Gallery.IsVisible = true;
				EditorPancakeView.IsVisible = true;
				BottomPancakeView.IsVisible = true;
				previewVideo.Source = source;
				//previewVideo.Play();
				//previewPicture.Rotation = 270;
				//previewPicture.RotationY = 180;
				//previewPicture.HeightRequest = 4000;
				//previewPicture.WidthRequest = 640;
				//previewPicture.Aspect = (Aspect)1;
			};
			CameraOrientationEvent += (sender, source) =>
			{
				if (source == 1)
				{
					previewVideo.Aspect = (Aspect)2;
				}
				else
				{
					previewVideo.Aspect = (Aspect)1;
				}
				previewVideo.IsVisible = true;
			};

		}

		async void Dare_Clicked(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("Darelist");
		}

		public static void OnPhotoCaptured(ImageSource src)
		{
			PhotoCapturedEvent?.Invoke(new Post(), src);
		}

		public static void OnVideoCaptured(MediaSource src)
		{
			VideoCapturedEvent?.Invoke(new Post(), src);
		}
		public static void OnOrientation(int src)
		{
			CameraOrientationEvent?.Invoke(new Post(), src);
		}

		async void Post_Clicked(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync($"//{nameof(CLGVSHome)}");
		}


		public void Dare_Selected(object sender, EventArgs e)
		{
			BottomPancakeView.IsVisible = false;
			BottomPancakeViewDare.IsVisible = true;
		}

		void ExitDare(object sender, EventArgs e)
		{
			BottomPancakeView.IsVisible = true;
			BottomPancakeViewDare.IsVisible = false;
		}
	
		void CloseImage(object sender, EventArgs e)
		{
			previewPicture.IsVisible = false;
			previewVideo.IsVisible = false;
			Exit.IsVisible = false;
			Next.IsVisible = false;
			Dare.IsVisible = false;
			//Filters.IsVisible = false;
			//Gallery.IsVisible = false;
			EditorPancakeView.IsVisible = false;
			BottomPancakeView.IsVisible = false;
			BottomPancakeViewDare.IsVisible = false;
			cameraView.IsVisible = true;
			//Capture.IsVisible = true;
		}



		
		protected override void OnAppearing()
		{
			base.OnAppearing();

			previewPicture.IsVisible = false;
			previewVideo.IsVisible = false;
			//previewVideo.IsVisible = false;
			Exit.IsVisible = false;
			Next.IsVisible = false;
			Dare.IsVisible = false;
			//Filters.IsVisible = false;
			//Gallery.IsVisible = false;
			EditorPancakeView.IsVisible = false;
			BottomPancakeView.IsVisible = false;
			BottomPancakeViewDare.IsVisible = false;
			cameraView.IsVisible = true;
			//FlashToggle.IsVisible = true;
			//Capture.IsVisible = true;
		}
	}
}