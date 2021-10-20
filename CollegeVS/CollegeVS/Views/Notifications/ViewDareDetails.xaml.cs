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
    public partial class ViewDareDetails : ContentPage
    {
        public class ReferenceDetails
        {
            public string Reference { get; set; }

            public string Details { get; set; }
        }
            public ViewDareDetails()
        {
            InitializeComponent();
        }
       async void BackArrow_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PopModalAsync();
        }
    }
}