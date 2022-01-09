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
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			
			InitializeComponent();
			//BindingContext = new CommentViewModel();
			this.BindingContext = new LoginViewModel();
			//this.BindingContext = Startup.ServiceProvider.GetService<LoginViewModel>();
		}

	async void Login_Clicked(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("//Home");
		}
		async void Register_Clicked(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("Register");
		}

	 	async void ForgotPass_Tapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("ForgotPassword");
		}

		async void ForgotUser_Tapped(object sender, EventArgs e)
		{
			await Shell.Current.GoToAsync("ForgotUsername");
		}
	}
}