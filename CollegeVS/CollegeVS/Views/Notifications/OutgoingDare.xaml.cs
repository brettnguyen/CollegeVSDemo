using CollegeVS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollegeVS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OutgoingDare : ContentView
    {
        public class ListDare
        {
            public string DareTitle { get; set; }

            public string DareImagePath { get; set; }

            public string DareTXUserName { get; set; }

            public string BorderColor { get; set; }

            public string BackgroundColor { get; set; }

			public string BackgroundColorChoice { get; set; }

			public string CheckChoice { get; set; }

			public string VisibleOne { get; set; }

			public string VisibleTwo { get; set; }




		}
        List<ListDare> list;
        public OutgoingDare()
        {
			
            InitializeComponent();
			this.BindingContext = new NotificationsViewModel();
			list = new List<ListDare>();

			list.Add(new ListDare
			{
				DareTitle = "Grab a Drink",
				DareImagePath = "PartyIcon.png",
				DareTXUserName = "From: Brett",
				BorderColor = "Red",
				BackgroundColor = "Red",
				BackgroundColorChoice = "Green",
				CheckChoice = "Check it out!",
				VisibleOne = "True",
				VisibleTwo = "False"

			});

			list.Add(new ListDare
			{
				DareTitle = "Grab a Drink",
				DareImagePath = "PartyIcon.png",
				DareTXUserName = "From: Brett",
				BorderColor = "Red",
				BackgroundColor = "Red",
					BackgroundColorChoice = "#C01C1C",
				VisibleOne = "False",
				VisibleTwo = "True",
					CheckChoice = "Awaiting..."

			});

			list.Add(new ListDare
			{
				DareTitle = "Grab a Drink",
				DareImagePath = "PartyIcon.png",
				DareTXUserName = "From: Brett",
				BorderColor = "Red",
				BackgroundColor = "Red",
					BackgroundColorChoice = "Green",
					CheckChoice = "Check it out!",
				VisibleOne = "True",
				VisibleTwo = "False"
			});

			ListDares.ItemsSource = list;

		
	}
		async void Check_Clicked(object sender, EventArgs e)
		{
			await Shell.Current.Navigation.PushModalAsync(new CheckDareView());
		}

		
	}
}