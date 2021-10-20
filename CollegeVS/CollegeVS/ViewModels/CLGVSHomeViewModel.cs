using CollegeVS.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using CollegeVS.Views;

using System.Windows.Input;

using CollegeVS.Services;
using CollegeVS.Models.API;


namespace CollegeVS.ViewModels
{
	public class CLGVSHomeViewModel : BaseViewModel
	{


		public Command GoToNotifications { get; }

		//private IHomeAPIStore _homeAPIStore;

		//public CLGVSHomeModel HomeModel { get => _homeAPIStore.HomeModel; }

		public CLGVSHomeViewModel()
		{
			//_homeAPIStore = homeAPIStore;

			

			GoToNotifications = new Command(OnNotificationsClicked);

		}
		private async void OnNotificationsClicked(object obj)
		{

			//_homeAPIStore.HomeModel = await _homeAPIStore.GetCLGVSHome(CVUtilities.DEFAULT_HOME_PAGE_FILTER, SortContentBy.DATE_DESC);

			//if (HomeModel != null)
			//{
			//	Console.WriteLine(HomeModel.CurrentUserSchool.Name);
			//}
			// Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
			await Shell.Current.GoToAsync($"Notifications");
		}


	}
}