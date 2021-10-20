using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SlideOverKit;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollegeVS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SortPopup : SlidePopupView
    {
        public const int iOSTopMargin = 0;
        
        public const int AndroidTopMargin = 0;
        public const int WinPHoneTopMargin = 0;
       



        public SortPopup()
        {
            InitializeComponent();

            // In this case, you must set both LeftMargin and TopMarin
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
         
            DoneButton.Clicked += (object sender, EventArgs e) => {
                this.HideMySelf();
            };

            
        }

     void Recent_Tapped(Object sender, EventArgs e)
        {
            RecentBlue.IsVisible = true;
            HighestBlue.IsVisible = false;
            LowestBlue.IsVisible = false;
            PartiesBlue.IsVisible = false;
            SportsBlue.IsVisible = false;
            FoodBlue.IsVisible = false;
            DormsBlue.IsVisible = false;
            ClubsBlue.IsVisible = false;
            OtherBlue.IsVisible = false;

            RecentWhiteText.IsVisible = true;
            HighestWhiteText.IsVisible = false;
            LowestWhiteText.IsVisible = false;
            PartiesWhiteText.IsVisible = false;
            SportsWhiteText.IsVisible = false;
            FoodWhiteText.IsVisible = false;
            DormsWhiteText.IsVisible = false;
            ClubsWhiteText.IsVisible = false;
            OtherWhiteText.IsVisible = false;

        }

        void Highest_Tapped (Object sender, EventArgs e)
        {
            RecentBlue.IsVisible = false;
            HighestBlue.IsVisible = true;
            LowestBlue.IsVisible = false;
            PartiesBlue.IsVisible = false;
            SportsBlue.IsVisible = false;
            FoodBlue.IsVisible = false;
            DormsBlue.IsVisible = false;
            ClubsBlue.IsVisible = false;
            OtherBlue.IsVisible = false;


            RecentWhiteText.IsVisible = false;
            HighestWhiteText.IsVisible = true;
            LowestWhiteText.IsVisible = false;
            PartiesWhiteText.IsVisible = false;
            SportsWhiteText.IsVisible = false;
            FoodWhiteText.IsVisible = false;
            DormsWhiteText.IsVisible = false;
            ClubsWhiteText.IsVisible = false;
            OtherWhiteText.IsVisible = false;

        }

        void Lowest_Tapped (Object sender, EventArgs e )
        {
            RecentBlue.IsVisible = false;
            HighestBlue.IsVisible = false;
            LowestBlue.IsVisible = true;
            PartiesBlue.IsVisible = false;
            SportsBlue.IsVisible = false;
            FoodBlue.IsVisible = false;
            DormsBlue.IsVisible = false;
            ClubsBlue.IsVisible = false;
            OtherBlue.IsVisible = false;

            RecentWhiteText.IsVisible = false;
            HighestWhiteText.IsVisible = false;
            LowestWhiteText.IsVisible = true;
            PartiesWhiteText.IsVisible = false;
            SportsWhiteText.IsVisible = false;
            FoodWhiteText.IsVisible = false;
            DormsWhiteText.IsVisible = false;
            ClubsWhiteText.IsVisible = false;
            OtherWhiteText.IsVisible = false;
        }

        void Parties_Tapped(Object sender, EventArgs e)
        {
            RecentBlue.IsVisible = false;
            HighestBlue.IsVisible = false;
            LowestBlue.IsVisible = false;
            PartiesBlue.IsVisible = true;
            SportsBlue.IsVisible = false;
            FoodBlue.IsVisible = false;
            DormsBlue.IsVisible = false;
            ClubsBlue.IsVisible = false;
            OtherBlue.IsVisible = false;

            RecentWhiteText.IsVisible = false;
            HighestWhiteText.IsVisible = false;
            LowestWhiteText.IsVisible = false;
            PartiesWhiteText.IsVisible = true;
            SportsWhiteText.IsVisible = false;
            FoodWhiteText.IsVisible = false;
            DormsWhiteText.IsVisible = false;
            ClubsWhiteText.IsVisible = false;
            OtherWhiteText.IsVisible = false;

        }
        void Sports_Tapped(Object sender, EventArgs e)
        {
            RecentBlue.IsVisible = false;
            HighestBlue.IsVisible = false;
            LowestBlue.IsVisible = false;
            PartiesBlue.IsVisible = false;
            SportsBlue.IsVisible = true;
            FoodBlue.IsVisible = false;
            DormsBlue.IsVisible = false;
            ClubsBlue.IsVisible = false;
            OtherBlue.IsVisible = false;

            RecentWhiteText.IsVisible = false;
            HighestWhiteText.IsVisible = false;
            LowestWhiteText.IsVisible = false;
            PartiesWhiteText.IsVisible = false;
            SportsWhiteText.IsVisible = true;
            FoodWhiteText.IsVisible = false;
            DormsWhiteText.IsVisible = false;
            ClubsWhiteText.IsVisible = false;
            OtherWhiteText.IsVisible = false;

        }
        void Food_Tapped(Object sender, EventArgs e)
        {
            RecentBlue.IsVisible = false;
            HighestBlue.IsVisible = false;
            LowestBlue.IsVisible = false;
            PartiesBlue.IsVisible = false;
            SportsBlue.IsVisible = false;
            FoodBlue.IsVisible = true;
            DormsBlue.IsVisible = false;
            ClubsBlue.IsVisible = false;
            OtherBlue.IsVisible = false;

            RecentWhiteText.IsVisible = false;
            HighestWhiteText.IsVisible = false;
            LowestWhiteText.IsVisible = false;
            PartiesWhiteText.IsVisible = false;
            SportsWhiteText.IsVisible = false;
            FoodWhiteText.IsVisible = true;
            DormsWhiteText.IsVisible = false;
            ClubsWhiteText.IsVisible = false;
            OtherWhiteText.IsVisible = false;

        }
        void Dorms_Tapped(Object sender, EventArgs e)
        {
            RecentBlue.IsVisible = false;
            HighestBlue.IsVisible = false;
            LowestBlue.IsVisible = false;
            PartiesBlue.IsVisible = false;
            SportsBlue.IsVisible = false;
            FoodBlue.IsVisible = false;
            DormsBlue.IsVisible = true;
            ClubsBlue.IsVisible = false;
            OtherBlue.IsVisible = false;

            RecentWhiteText.IsVisible = false;
            HighestWhiteText.IsVisible = false;
            LowestWhiteText.IsVisible = false;
            PartiesWhiteText.IsVisible = false;
            SportsWhiteText.IsVisible = false;
            FoodWhiteText.IsVisible = false;
            DormsWhiteText.IsVisible = true;
            ClubsWhiteText.IsVisible = false;
            OtherWhiteText.IsVisible = false;

        }

        void Clubs_Tapped(Object sender, EventArgs e)
        {
            RecentBlue.IsVisible = false;
            HighestBlue.IsVisible = false;
            LowestBlue.IsVisible = false;
            PartiesBlue.IsVisible = false;
            SportsBlue.IsVisible = false;
            FoodBlue.IsVisible = false;
            DormsBlue.IsVisible = false;
            ClubsBlue.IsVisible = true;
            OtherBlue.IsVisible = false;

            RecentWhiteText.IsVisible = false;
            HighestWhiteText.IsVisible = false;
            LowestWhiteText.IsVisible = false;
            PartiesWhiteText.IsVisible = false;
            SportsWhiteText.IsVisible = false;
            FoodWhiteText.IsVisible = false;
            DormsWhiteText.IsVisible = false;
            ClubsWhiteText.IsVisible = true;
            OtherWhiteText.IsVisible = false;

        }

        void Other_Tapped(Object sender, EventArgs e)
        {
            RecentBlue.IsVisible = false;
            HighestBlue.IsVisible = false;
            LowestBlue.IsVisible = false;
            PartiesBlue.IsVisible = false;
            SportsBlue.IsVisible = false;
            FoodBlue.IsVisible = false;
            DormsBlue.IsVisible = false;
            ClubsBlue.IsVisible = false;
            OtherBlue.IsVisible = true;

            RecentWhiteText.IsVisible = false;
            HighestWhiteText.IsVisible = false;
            LowestWhiteText.IsVisible = false;
            PartiesWhiteText.IsVisible = false;
            SportsWhiteText.IsVisible = false;
            FoodWhiteText.IsVisible = false;
            DormsWhiteText.IsVisible = false;
            ClubsWhiteText.IsVisible = false;
            OtherWhiteText.IsVisible = true;

        }

        void SortBack_Tapped(Object sender, EventArgs e)
        {
            this.HideMySelf();

        }

    }
}