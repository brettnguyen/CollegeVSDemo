using System;
using System.Collections.Generic;
using CollegeVS.ViewModels;
using Xamarin.Forms;

namespace CollegeVS.Views
{
    public partial class DareCreation : ContentView
    {
        public DareCreation()
        {
            InitializeComponent();
			this.BindingContext = new CLGVSDaresViewModel();


		}
		async void PartyDare_Tapped(object sender, EventArgs e)
		{

			await Shell.Current.GoToAsync("PartiesDare");
		}

		async void FoodDare_Tapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("FoodDare");
		}

		async void SportsDare_Tapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("SportsDare");
		}

		async void ClubsDare_Tapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("ClubsDare");
		}

		async void DormsDare_Tapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("DormsDare");
		}

		async void Randomizer_Tapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("PartiesDare");
		}

		
	}
}
