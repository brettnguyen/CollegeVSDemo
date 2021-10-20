using System;
using System.Collections.Generic;
using SlideOverKit;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollegeVS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchoolInfoPopUp : SlidePopupView
    {
        public const int iOSTopMargin = 0;

        public const int AndroidTopMargin = 0;
        public const int WinPHoneTopMargin = 0;

        public SchoolInfoPopUp()
        {
            InitializeComponent();

            this.LeftMargin = 0;
            this.BackgroundViewColor = Color.Transparent;

            // In some small screen Android devices, the menu cannot be layout with full size.
            // In this case, we just set LeftMargin and TopMargin,
            // you do not need to set the HeightRequest or WidthRequest, as they are no effect in Pop up View.
            // If the view is too small for Android devices, we can reduce the TopMargin.
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    this.TopMargin = iOSTopMargin;
                    break;
                case Device.Android:
                    this.TopMargin = AndroidTopMargin;
                    break;
                case Device.UWP:
                    this.TopMargin = WinPHoneTopMargin;
                    break;
            }

            // The menu will hide without animation, 
            // If you want to have the animation, you can call the MenuContainerPage.HideMenu(), 
            // But you cannot call it from this View, cause of cycle references, you can sent a message to ContainerPage

                
            
        }

        void Done_Tapped(System.Object sender, System.EventArgs e)
        {
            this.HideMySelf();
        }
    }
}
