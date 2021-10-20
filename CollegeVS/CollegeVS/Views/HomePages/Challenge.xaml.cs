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
    public partial class Challenge : ContentPage
    {

        public class ListChallenge
        {
            public string Challenge { get; set; }

            public string Numbers { get; set; }

        }

        List<ListChallenge> list;


        public Challenge()
        {
            InitializeComponent();

			list = new List<ListChallenge>();

			list.Add(new ListChallenge
			{
                Challenge = "Post videos",
                Numbers = "0/25"

            });
            list.Add(new ListChallenge
            {
                Challenge = "Post Images",
                Numbers = "0/25"

            });
            list.Add(new ListChallenge
            {
                Challenge = "Get Upvotes",
                Numbers = "0/25"

            });
            list.Add(new ListChallenge
            {
                Challenge = "Upvote Images",
                Numbers = "0/25"

            });
            list.Add(new ListChallenge
            {
                Challenge = "Upvote videos",
                Numbers = "0/25"

            });
            list.Add(new ListChallenge
            {
                Challenge = "Share images or videos",
                Numbers = "0/25"

            });
            list.Add(new ListChallenge
            {
                Challenge = "Visit Schools",
                Numbers = "0/25"

            });
            list.Add(new ListChallenge
            {
                Challenge = "Accumulate points",
                Numbers = "0/25"

            });
            list.Add(new ListChallenge
            {
                Challenge = "Visit Profiles",
                Numbers = "0/25"

            });
            list.Add(new ListChallenge
            {
                Challenge = "Dares",
                Numbers = "0/25"

            }) ;


            ListChallenges.ItemsSource = list;



			Challengebutton.Clicked += Challengebutton_Clicked;


        }
       async void Challengebutton_Clicked(object sender, EventArgs e)
        {


            await Shell.Current.GoToAsync("..");

        }
    }
}