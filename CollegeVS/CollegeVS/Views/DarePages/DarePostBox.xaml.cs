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
    public partial class DarePostBox : ContentPage
    {
        public DarePostBox()
        {
            InitializeComponent();
           
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();


            
            Device.BeginInvokeOnMainThread(async () =>
            {
                await System.Threading.Tasks.Task.Delay(1);
                SearchUser.Focus();
            });

        }

     

        async void BackArrow_Clicked(object sender, EventArgs e)
        {
            
            await Shell.Current.Navigation.PopToRootAsync();
        }

        async void Next_Tapped(object sender, EventArgs e)
        {

            await Shell.Current.GoToAsync("PartiesRef");
        }

        void ChangeFrame_Tapped(System.Object sender, System.EventArgs e)
        {
            DareTitle.Focus();
            ChangeFrame.IsVisible = false;
            ChangeFrameTop.IsVisible = false;
            ChangeFrameTwo.IsVisible = true;
            ChangeFrameTopTwo.IsVisible = true;
        }

        void ChangeFrameTwo_Tapped(System.Object sender, System.EventArgs e)
        {
            SearchUser.Focus();
            ChangeFrame.IsVisible = true;
            ChangeFrameTop.IsVisible = true;
            ChangeFrameTwo.IsVisible = false;
            ChangeFrameTopTwo.IsVisible = false;
        }



    }
}