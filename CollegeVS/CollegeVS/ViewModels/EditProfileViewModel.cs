using CollegeVS.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace CollegeVS.ViewModels
{
    public class EditProfileViewModel : BaseViewModel
    {
        public Command ReturnToCLGVSProfile { get; }
        public EditProfileViewModel()
        {
            ReturnToCLGVSProfile = new Command(OnCLGVSProfileClicked);
        }
        private async void OnCLGVSProfileClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//Profile/{nameof(CLGVSProfile)}");
        }

    }
}