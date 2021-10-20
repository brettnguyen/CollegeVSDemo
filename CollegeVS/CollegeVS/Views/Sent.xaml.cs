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
	public partial class Sent : ContentPage
	{
		public Sent()
		{
			InitializeComponent();
		}

		private void Sent_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new CLGVSHome());
		}
	}
}