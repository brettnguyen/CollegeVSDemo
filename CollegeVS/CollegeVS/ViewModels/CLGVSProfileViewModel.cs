using CollegeVS.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace CollegeVS.ViewModels
{
	public class CLGVSProfileViewModel : BaseViewModel
	{
		public Command GoToProfilePic { get; }
		
		public CLGVSProfileViewModel()
		{
			GoToProfilePic = new Command(OnProfilePicClicked);
			
		}
		async void OnProfilePicClicked(object obj)
		{
			// Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
			await Shell.Current.GoToAsync($"//Number2/{nameof(ProfilePic)}");
		}



	}
}
