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
    public partial class ClubsReferenceDarePage : ContentPage
    {
        public ClubsReferenceDarePage()
        {
            InitializeComponent();
        }
        async void BackArrow_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }

        async void Next_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("ClubsReview");

        }

        void Details_PropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {


            if (Details.Text != "")
                Next.IsVisible = true;

            else
                Next.IsVisible = false;


            if (Details.Text != "")
                Skip.IsVisible = false;

            else
                Skip.IsVisible = true;

        }
    }
}