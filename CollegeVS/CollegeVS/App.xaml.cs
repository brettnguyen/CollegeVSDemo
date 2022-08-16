using CollegeVS.Services;
using CollegeVS.Views;
using System;
using Plugin.SharedTransitions;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CollegeVS.ViewModels;
using CollegeVS.Models;


namespace CollegeVS
{
	public partial class App : Application
	{

		const int smallWightResolution = 768;
		const int smallHeightResolution = 1280;

	

		public App()
		{

			InitializeComponent();

			LoadStyles();
			Plugin.Media.CrossMedia.Current.Initialize();
			
			MainPage =  new AppShell();
		 

		}

		void LoadStyles()
		{
			if (IsASmallDevice())
			{
				dictionary.MergedDictionaries.Add(SmallDevicesStyle.SharedInstance);
			}
			else
			{
				dictionary.MergedDictionaries.Add(GeneralDevicesStyle.SharedInstance);
			}
		}

		public static bool IsASmallDevice()
		{
			// Get Metrics
			var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;

			// Width (in pixels)
			var width = mainDisplayInfo.Width;

			// Height (in pixels)
			var height = mainDisplayInfo.Height;
			return (width <= smallWightResolution && height <= smallHeightResolution);
		}


		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}

	}
}
