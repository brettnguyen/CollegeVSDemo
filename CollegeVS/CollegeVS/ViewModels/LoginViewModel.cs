using CollegeVS.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using FFImageLoading;
using CollegeVS.Services;
using CollegeVS.Models.API;
using Xamarin.Essentials;

namespace CollegeVS.ViewModels
{
	public class LoginViewModel : BaseViewModel
	{
		//IAuthStore authStore;
		//IHomeAPIStore _homeAPIStore;

		public Command LoginCommand { get; }
	

		public LoginViewModel()
		{
			//this.authStore = auth;
			//this._homeAPIStore = homeAPIStore;

			LoginCommand = new Command(OnLoginClicked);

		}

		private async void OnLoginClicked(object obj)
		{
		//UserSessionState state = await authStore.Login("User3", "password");
		//_homeAPIStore.State = state;
		//if(state != null && state.EmailToken != null)
		//{

		//await SecureStorage.SetAsync("esw", state.EmailToken);
		//}

		//Console.WriteLine("finished api call");
		// Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
		await Shell.Current.GoToAsync($"//{nameof(CLGVSHome)}");

		}





	}
}
