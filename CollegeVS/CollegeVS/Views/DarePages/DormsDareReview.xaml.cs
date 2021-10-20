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
    public partial class DormsDareReview : ContentPage
    {
        public DormsDareReview()
        {
            InitializeComponent();
        }
        async void BackArrow_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
        async void Next_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Dares/SentIncoming");


        }
    }
}