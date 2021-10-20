using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollegeVS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BottomHalfOfCreatePostPage : ContentView
    {

		public BottomHalfOfCreatePostPage()
        {
            InitializeComponent();
        }

        private void Parties_Clicked(object sender, EventArgs e)
        {
            parties.BorderWidth = 2;
            sports.BorderWidth = 0;
            dorms.BorderWidth = 0;
            food.BorderWidth = 0;
            clubs.BorderWidth = 0;
            other.BorderWidth = 0;
        }
        private void Sports_Clicked(object sender, EventArgs e)
        {
            parties.BorderWidth = 0;
            sports.BorderWidth = 2;
            dorms.BorderWidth = 0;
            food.BorderWidth = 0;
            clubs.BorderWidth = 0;
            other.BorderWidth = 0;
        }
        private void Dorms_Clicked(object sender, EventArgs e)
        {
            parties.BorderWidth = 0;
            sports.BorderWidth = 0;
            dorms.BorderWidth = 2;
            food.BorderWidth = 0;
            clubs.BorderWidth = 0;
            other.BorderWidth = 0;
        }
        private void Food_Clicked(object sender, EventArgs e)
        {
            parties.BorderWidth = 0;
            sports.BorderWidth = 0;
            dorms.BorderWidth = 0;
            food.BorderWidth = 2;
            clubs.BorderWidth = 0;
            other.BorderWidth = 0;
        }
        private void Clubs_Clicked(object sender, EventArgs e)
        {
            parties.BorderWidth = 0;
            sports.BorderWidth = 0;
            dorms.BorderWidth = 0;
            food.BorderWidth = 0;
            clubs.BorderWidth = 2;
            other.BorderWidth = 0;
        }
        private void Other_Clicked(object sender, EventArgs e)
        {
            parties.BorderWidth = 0;
            sports.BorderWidth = 0;
            dorms.BorderWidth = 0;
            food.BorderWidth = 0;
            clubs.BorderWidth = 0;
            other.BorderWidth = 2;
        }

    }

}