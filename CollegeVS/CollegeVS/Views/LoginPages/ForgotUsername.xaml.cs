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
    public partial class ForgotUsername : ContentPage
    {
        public ForgotUsername()
        {
            InitializeComponent();
            
        }
       async void BackArrow_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PopToRootAsync();
        }
    }
}