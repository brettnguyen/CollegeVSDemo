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
	public partial class Leaderboard : ContentPage
	{
		public class LeaderboardPost
		{
			public string Number { get; set; }

			public string CollegeName { get; set; }

			public string CollegePoints { get; set; }

			public string PartyPoints { get; set; }

			public string SportsPoints { get; set; }

			public string DormsPoints { get; set; }

			public string FoodPoints { get; set; }

			public string ClubsPoints { get; set; }

			public string OtherPoints { get; set; }

			public string ChallengePoints { get; set; }


		}
		List<LeaderboardPost> list;

		public Leaderboard()
		{
			InitializeComponent();
			list = new List<LeaderboardPost>();
			

			list.Add(new LeaderboardPost
			{
				Number = "1",
				CollegeName = "Harvard",
				CollegePoints = "100,000",
				PartyPoints = "100",
				SportsPoints = "100",
				DormsPoints = "100",
				FoodPoints = "100",
				ClubsPoints = "100",
				OtherPoints = "100",
				ChallengePoints = "1000"


			});
			list.Add(new LeaderboardPost
			{
				Number = "2",
				CollegeName = "Yale",
				CollegePoints = "90,000",
				PartyPoints = "50",
				SportsPoints = "50",
				DormsPoints = "50",
				FoodPoints = "50",
				ClubsPoints = "50",
				OtherPoints = "50",
				ChallengePoints = "900"


			});
			list.Add(new LeaderboardPost
			{
				Number = "3",
				CollegeName = "Arizona State",
				CollegePoints = "80,000",
				PartyPoints = "40",
				SportsPoints = "40",
				DormsPoints = "40",
				FoodPoints = "40",
				ClubsPoints = "40",
				OtherPoints = "40",
				ChallengePoints = "800"


			});
			list.Add(new LeaderboardPost
			{
				Number = "4",
				CollegeName = "Ohio State",
				CollegePoints = "70,000",
				PartyPoints = "30",
				SportsPoints = "30",
				DormsPoints = "30",
				FoodPoints = "30",
				ClubsPoints = "30",
				OtherPoints = "30",
				ChallengePoints = "700"


			});
			list.Add(new LeaderboardPost
			{
				Number = "5",
				CollegeName = "Flordia State",
				CollegePoints = "60,000",
				PartyPoints = "30",
				SportsPoints = "30",
				DormsPoints = "30",
				FoodPoints = "30",
				ClubsPoints = "30",
				OtherPoints = "30",
				ChallengePoints = "700"


			});
			list.Add(new LeaderboardPost
			{
				Number = "6",
				CollegeName = "Penn State",
				CollegePoints = "50,000",
				PartyPoints = "30",
				SportsPoints = "30",
				DormsPoints = "30",
				FoodPoints = "30",
				ClubsPoints = "30",
				OtherPoints = "30",
				ChallengePoints = "700"


			});
			list.Add(new LeaderboardPost
			{
				Number = "7",
				CollegeName = "Clemnson univeristy",
				CollegePoints = "40,000",
				PartyPoints = "30",
				SportsPoints = "30",
				DormsPoints = "30",
				FoodPoints = "30",
				ClubsPoints = "30",
				OtherPoints = "30",
				ChallengePoints = "700"


			});
			list.Add(new LeaderboardPost
			{
				Number = "8",
				CollegeName = "SUNY Plattsburgh",
				CollegePoints = "30,000",
				PartyPoints = "30",
				SportsPoints = "30",
				DormsPoints = "30",
				FoodPoints = "30",
				ClubsPoints = "30",
				OtherPoints = "30",
				ChallengePoints = "700"


			});
			
				list.Add(new LeaderboardPost
				{
					Number = "9",
					CollegeName = "University at Buffalo",
					CollegePoints = "20,000",
					PartyPoints = "30",
					SportsPoints = "30",
					DormsPoints = "30",
					FoodPoints = "30",
					ClubsPoints = "30",
					OtherPoints = "30",
					ChallengePoints = "700"


				});
			list.Add(new LeaderboardPost
			{
				Number = "10",
				CollegeName = "SUNY Brockport",
				CollegePoints = "10,000",
				PartyPoints = "30",
				SportsPoints = "30",
				DormsPoints = "30",
				FoodPoints = "30",
				ClubsPoints = "30",
				OtherPoints = "30",
				ChallengePoints = "700"


			});


			LeaderboardPosts.ItemsSource = list;

			CloseLeaderboard.Clicked += CloseLeaderboard_Clicked;
		}

		async void CloseLeaderboard_Clicked(object sender, EventArgs e)
		{
			

			await Shell.Current.GoToAsync("..");
		}
		 
    }
}