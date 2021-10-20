using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeVS;
using CollegeVS.ViewModels;
using CollegeVS.Models;
using SlideOverKit;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollegeVS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CommentSlideUp : SlideMenuView
    {
       
        public CommentSlideUp()
        {


            InitializeComponent();
            BindingContext = new CommentViewModel();
            
            this.Commenting.Focused += (s, e) => { CommentBTN.IsVisible = false; };
            
            this.Commenting.Focused += (s, e) => { SetLayoutPosition(onFocus: true); };
        
            this.Commenting.Unfocused += (s, e) => { SetLayoutPosition(onFocus: false); };


            this.CommentingTwo.Focused += (s, e) => { CommentBTNTwo.IsVisible = false; };

            this.CommentingTwo.Focused += (s, e) => { SetLayoutPosition(onFocus: true); };

            this.CommentingTwo.Unfocused += (s, e) => { SetLayoutPosition(onFocus: false); };

            void SetLayoutPosition(bool onFocus)
            {
                Task.Delay(1000);
                
                if (onFocus)
                {
                   
                    if (Device.RuntimePlatform == Device.iOS)
                    {
                        this.EndStackLayout.TranslateTo (0, 32, 0);
                       
                    }
                    else if (Device.RuntimePlatform == Device.Android)
                    {
                        this.EndStackLayout.TranslateTo(0, -220, 0);
                    }
                }
                else
                {
                    if (Device.RuntimePlatform == Device.iOS)
                    {
                        this.EndStackLayout.TranslateTo(0, 0, 0);
                    }
                    else if (Device.RuntimePlatform == Device.Android)
                    {
                        this.EndStackLayout.TranslateTo(0, 0, 0);
                    }
                }

                if (onFocus)
                {

                    if (Device.RuntimePlatform == Device.iOS)
                    {
                        this.EndStackLayoutTwo.TranslateTo(0, 0, 0);

                    }
                    else if (Device.RuntimePlatform == Device.Android)
                    {
                        this.EndStackLayoutTwo.TranslateTo(0, -150, 0);
                    }
                }
                else
                {
                    if (Device.RuntimePlatform == Device.iOS)
                    {
                        this.EndStackLayoutTwo.TranslateTo(0, 0, 0);
                    }
                    else if (Device.RuntimePlatform == Device.Android)
                    {
                        this.EndStackLayoutTwo.TranslateTo(0, 0, 0);
                    }
                }

            }
            // You must set HeightRequest in this case
            
            // You must set IsFullScreen in this case, 
            // otherwise you need to set WidthRequest, 
            // just like the QuickInnerMenu sample
            this.IsFullScreen = true;
            this.MenuOrientations = MenuOrientation.BottomToTop;

            // You must set BackgroundColor, 
            // and you cannot put another layout with background color cover the whole View
            // otherwise, it cannot be dragged on Android
            this.BackgroundColor = Color.FromHex ("#1E1E1E");
            this.BackgroundViewColor = Color.Transparent;

            // In some small screen size devices, the menu cannot be full size layout.
            // In this case we need to set different size for Android.
          
        }
        public void FillInfo()
        {

        }
        public void Close_Clicked(object sender, EventArgs e)
        {
            
            this.HideWithoutAnimations();
        }

       public void CommentBTN_Clicked(object sender, EventArgs e)
        {
         
            Commenting.Text = "";
            Commenting.Unfocus();
        }

        public void CommentBTNTwo_Clicked(object sender, EventArgs e)
        {

            CommentingTwo.Text = "";
            CommentingTwo.Unfocus();
        }

        public void Commenting_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (Commenting.Text != "")
                CommentBTN.IsVisible = true;
            else
                CommentBTN.IsVisible = false;

          
        }

        public void CommentingTwo_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (CommentingTwo.Text != "")
                CommentBTNTwo.IsVisible = true;
            else
                CommentBTNTwo.IsVisible = false;



        }

        public void ExtraComment_Tapped(object sender, EventArgs e)
        {

            Commenting.Focus();
        }

        public void ExtraCommentTwo_Tapped(object sender, EventArgs e)
        {

            CommentingTwo.Focus();
        }

        public void Section_Tapped(object sender, EventArgs e)
        {

            Commenting.Unfocus();
            Commenting.Unfocus();

        }

        async void User_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("OtherUserProfile");

        }

        async void You_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Profile");

        }
    }
}