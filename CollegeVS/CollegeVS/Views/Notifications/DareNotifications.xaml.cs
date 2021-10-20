using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CollegeVS.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollegeVS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DareNotifications : ContentView
    {
		public class ListDare
		{
			public string DareTitle { get; set; }

			public string DareImagePath { get; set; }

			public string DareTXUserName { get; set; }

			public string BorderColor { get; set; }

			public string BackgroundColor { get; set; }

			public string ViewDetails { get; set; }


		}
		List<ListDare> list;

	
		
			public DareNotifications()
        {
            InitializeComponent();
            
           
            this.BindingContext = new NotificationsViewModel();
			list = new List<ListDare>();

			list.Add(new ListDare
			{
				DareTitle = "Do it now Gohan",
				DareImagePath = "thepartyicon.png",
				DareTXUserName = "@BrettNguyen",
				BorderColor = "Red",
				BackgroundColor = "Red",
				ViewDetails = "True"
			});

			list.Add(new ListDare
			{
				DareTitle = "Do it now Gohan",
				DareImagePath = "thepartyicon.png",
				DareTXUserName = "@BrettNguyen",
				BorderColor = "Red",
				BackgroundColor = "Red",
				ViewDetails = "False"
			});

			list.Add(new ListDare
			{
				DareTitle = "Do it now Gohan",
				DareImagePath = "thepartyicon.png",
				DareTXUserName = "@BrettNguyen",
				BorderColor = "Red",
				BackgroundColor = "Red",
				ViewDetails = "False"

			});

			ListDares.ItemsSource = list;

		}

		async void Details_Clicked(object sender, EventArgs e)
        {
			await Shell.Current.GoToAsync("ViewDareDetails");
		}
		

	}
}