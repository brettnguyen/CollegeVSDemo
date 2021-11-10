using CollegeVS.ViewModels;
using CollegeVS.Views;
using System;
using System.Collections.Generic;


using Xamarin.Forms;
using System.Diagnostics;

namespace CollegeVS
{
	public partial class AppShell
    {
        public AppShell()
        {

            InitializeComponent();
            

            Routing.RegisterRoute("Login", typeof(LoginPage));
            Routing.RegisterRoute("Register", typeof(Register));
            Routing.RegisterRoute("Register2", typeof(RegisterPage2));
            Routing.RegisterRoute("ForgotPassword", typeof(ForgotPassword));
            Routing.RegisterRoute("ForgotUsername", typeof(ForgotUsername));

            Routing.RegisterRoute("Home", typeof(CLGVSHome));
            Routing.RegisterRoute("Leaderboard", typeof(Leaderboard));
            Routing.RegisterRoute("Challenge", typeof(Challenge));

            Routing.RegisterRoute("Highlight", typeof(HighlightPage));


          
           
            Routing.RegisterRoute("PartiesDare", typeof(DarePostBox));
            Routing.RegisterRoute("PartiesRef", typeof(ReferenceDarePage));
            Routing.RegisterRoute("PartiesReview", typeof(DareReview));
            Routing.RegisterRoute("ClubsDare", typeof(ClubsDarePost));
            Routing.RegisterRoute("ClubsRef", typeof(ClubsReferenceDarePage));
            Routing.RegisterRoute("ClubsReview", typeof(ClubsDareReview));
            Routing.RegisterRoute("DormsDare", typeof(DormsDarePost));
            Routing.RegisterRoute("DormsRef", typeof(DormsReferenceDarePage));
            Routing.RegisterRoute("DormsReview", typeof(DormsDareReview));
            Routing.RegisterRoute("FoodDare", typeof(FoodDarePost));
            Routing.RegisterRoute("FoodRef", typeof(FoodReferenceDarePage));
            Routing.RegisterRoute("FoodReview", typeof(FoodDareReview));
            Routing.RegisterRoute("SportsDare", typeof(SportsDarePost));
            Routing.RegisterRoute("SportsRef", typeof(SportsReferenceDarePage));
            Routing.RegisterRoute("SportsReview", typeof(SportsDareReview));
            Routing.RegisterRoute("Randomizer", typeof(Randomizer));

            Routing.RegisterRoute("Notifications", typeof(Notifications));
         
            Routing.RegisterRoute("ViewDareDetails", typeof(ViewDareDetails));
            Routing.RegisterRoute("CheckDareView", typeof(CheckDareView));

            Routing.RegisterRoute("Post", typeof(Post));
            Routing.RegisterRoute("Profile", typeof(CLGVSProfile));
            Routing.RegisterRoute("EditProfile", typeof(EditProfile));
            Routing.RegisterRoute("OtherUserProfile", typeof(OtherUserProfile));
            Routing.RegisterRoute("ProfilePic", typeof(ProfilePic));

            Routing.RegisterRoute("Schoolpage", typeof(Schoolpage));

            Routing.RegisterRoute("Darelist", typeof(CLGVSDaresList));

            Routing.RegisterRoute("FollowingFollowers", typeof(FollowingFollowers));

            Routing.RegisterRoute("FollowersFollowing", typeof(FollowersFollowing));
            Routing.RegisterRoute("CreateSentIncoming", typeof(CreateSentIncoming));
            Routing.RegisterRoute("SentIncoming", typeof(SentIncoming));




        }
        

    }
}
