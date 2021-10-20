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
    public partial class RankAndAccoladesMenu : SlideMenuView
    {
        public class Accolades
        {
            public string Image { get; set; }
        }
        List<Accolades> list;
        public RankAndAccoladesMenu()
        {
            InitializeComponent();
            list = new List<Accolades>();
            list.Add(new Accolades
            {
         Image = "inv.png"
          

            });
            list.Add(new Accolades
            {
                Image = "inv.png"


            });
            list.Add(new Accolades
            {
                Image = "inv.png"


            });
            list.Add(new Accolades
            {
                Image = "inv.png"


            });
            list.Add(new Accolades
            {
                Image = "inv.png"


            });
            list.Add(new Accolades
            {
                Image = "inv.png"


            });
            list.Add(new Accolades
            {
                Image = "inv.png"


            });
            list.Add(new Accolades
            {
                Image = "inv.png"


            });
            list.Add(new Accolades
            {
                Image = "inv.png"


            });
            list.Add(new Accolades
            {
                Image = "inv.png"


            });

            ListAccolades.ItemsSource = list;
            // You must set IsFullScreen in this case, 
            // otherwise you need to set HeightRequest, 
            // just like the QuickInnerMenu sample
            this.IsFullScreen = true;
            // You must set WidthRequest in this case
            this.HeightRequest = 400;
            this.MenuOrientations = MenuOrientation.BottomToTop;

            // You must set BackgroundColor, 
            // and you cannot put another layout with background color cover the whole View
            // otherwise, it cannot be dragged on Android
            this.BackgroundColor = Color.FromHex("#1E1E1E");

            // This is shadow view color, you can set a transparent color
            this.BackgroundViewColor = Color.Transparent;

            
        }
        void Close_Clicked(object sender, EventArgs e)
        {
            this.HideWithoutAnimations();
        }
    }
}
    
