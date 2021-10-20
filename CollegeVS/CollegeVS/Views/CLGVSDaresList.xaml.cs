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

namespace CollegeVS.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CLGVSDaresList : ContentPage
	{
		public class ListDare
		{
			public string DareTitle { get; set; }

			public string DareImagePath { get; set; }

			public string DareTXUserName { get; set; }

			public string BorderColor { get; set; }

			public string BackgroundColor { get; set; }


		}
		List<ListDare> list;

		Post post;
		public CLGVSDaresList(Post p)
		{
			InitializeComponent();
			post = p;
			list = new List<ListDare>();

			list.Add(new ListDare
			{
				DareTitle = "Do it now Gohan",
				DareImagePath = "PartyIcon.png",
				DareTXUserName = "From: Brett",
				BorderColor = "Red",
				BackgroundColor = "Red"
			});

			list.Add(new ListDare
			{
				DareTitle = "Do it now Gohan",
				DareImagePath = "PartyIcon.png",
				DareTXUserName = "From: Brett",
				BorderColor = "Yellow",
				BackgroundColor = "Red"
			});

			list.Add(new ListDare
			{
				DareTitle = "Do it now Gohan",
				DareImagePath = "PartyIcon.png",
				DareTXUserName = "From: Brett",
				BorderColor = "Red",
				BackgroundColor = "Red"
			});

			ListDares.ItemsSource = list;

			FillInfo();
		}
		protected override void OnAppearing()
		{
			base.OnAppearing();
			FillInfo();
		}
		public void FillInfo()
		{



		}

		async void DareAccepted(object sender, EventArgs e)
		{
			post.Dare_Selected(sender, e);
			post.BindingContext = list[1];
			await Shell.Current.GoToAsync("..");


		}

	}
}