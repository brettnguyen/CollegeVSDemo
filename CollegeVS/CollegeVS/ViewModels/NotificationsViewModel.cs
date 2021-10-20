using CollegeVS.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using CollegeVS.Views;

namespace CollegeVS.ViewModels
{
    public class NotificationsViewModel : BaseViewModel
    {
		public Command ReturnToCLGVSHome { get; }
		public NotificationsViewModel()
		{
			ReturnToCLGVSHome = new Command(OnReturnClicked);

		}
		private async void OnReturnClicked(object obj)
		{
			// Prefixing with `//` switches to a different navigation stack instead of pushing to the active one

			await Shell.Current.Navigation.PopToRootAsync();
		}

	}
    
}
