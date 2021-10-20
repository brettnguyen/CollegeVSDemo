using System;
using System.Collections.Generic;
using CollegeVS.Models.API.EntityModels;
using CollegeVS.Models.API.HelperClasses;
using CollegeVS.Models.API.CVChallengePlugin;

namespace CollegeVS.Models.API
{
    #region Struct Models

    public struct ContentSortOptionModel
    {
        /// <summary>
        /// The html ID for this element
        /// </summary>
        public string htmlID;

        /// <summary>
        /// The value of the radio button, submitted to the controller
        /// </summary>
        public SortContentBy sortContentByValue;

        /// <summary>
        /// The visible display name for the sort option
        /// </summary>
        public string displayStr;

        /// <summary>
        /// The path to the visible image display
        /// </summary>
        public string imgUrl;

        /// <summary>
        /// Indicates if this items radio button is selected
        /// </summary>
        public bool selected;
    }

    public struct ContentFilterOptionModel
    {
        /// <summary>
        /// The html ID for this element
        /// </summary>
        public string htmlID;

        /// <summary>
        /// The value of the radio button, submitted to the controller
        /// </summary>
        public ContentLoadFilter loadFilterValue;

        /// <summary>
        /// The visible display name for the sort option
        /// </summary>
        public string displayStr;

        /// <summary>
        /// The path to the visible image display
        /// </summary>
        public string imgUrl;

        /// <summary>
        /// The category this filter refers to [OPTIONAL]
        /// </summary>
        public CVCategories category;

        /// <summary>
        /// Indicates if this items radio button is selected
        /// </summary>
        public bool selected;
    }

    #endregion




    public class CLGVSHomeModel
    {
        public struct UserChallengeProgressData
        {
            public string ChallengeSentence;
            public int UserProgress;
            public int TierGoal;

            public UserChallengeProgressData(string challengeSentence, int userProgress, int tierGoal)
            {
                ChallengeSentence = challengeSentence;
                UserProgress = userProgress;
                TierGoal = tierGoal;
            }
        }

        public CLGVSPageType PageType { get; set; }

        #region Content Properties

        /// <summary>
        /// Returns the main list of the videos wrappers that will be loaded on a page refresh
        /// </summary>
        public List<VideoWrapper> VideoWrappers { get; set; }

        /// <summary>
        /// Returns a single video wrapper
        /// </summary>
        public VideoWrapper VideoWrapper { get; set; }

        /// <summary>
        /// Returns the current load filter for the content
        /// </summary>
        public ContentLoadFilter CurrentContentLoadFilter { get; set; }

        /// <summary>
        /// A string representation of the filter 
        /// </summary>
        public string ContentFilterName { get; set; }

        /// <summary>
        /// A string representation of the sort order 
        /// </summary>
        public string ContentSortByName { get; set; }

        /// <summary>
        /// Returns the current sort-by ordering for the content
        /// </summary>
        public SortContentBy CurrentContentSortBy { get; set; }

        /// <summary>
        /// A list of the available content sort option models. Used to construct the Sort options list
        /// </summary>
        public IEnumerable<ContentSortOptionModel> ContentSortOptions { get; set; }

        /// <summary>
        /// A list of the available content filter option models. Used to construct the filter options list
        /// </summary>
        public IEnumerable<ContentFilterOptionModel> ContentFilterOptions { get; set; }

        // Holds the top videos for a given categories
        public IEnumerable<Video> TopPartiesContent { get; set; }
        public IEnumerable<Video> TopOtherContent { get; set; }
        public IEnumerable<Video> TopSportsContent { get; set; }
        public IEnumerable<Video> TopDormsContent { get; set; }
        public IEnumerable<Video> TopClubsContent { get; set; }
        public IEnumerable<Video> TopFoodContent { get; set; }

        #endregion Content Properties

        #region Dares Properties
        public bool dareInProgressExists { get; set; }
        public List<DareWrapper> DareWrappers { get; set; }
        public DareLoadFilter CurrentDaresFilter { get; set; }
        public User DaredUser { get; set; }
        public string category { get; set; }
        public string RXUsername { get; set; }
        public string title { get; set; }
        public string dareCategoryIcon { get; set; }
        public string hashtag { get; set; }

        #endregion Dares Properties



        #region Current User Properties

        /// <summary>
        /// Returns the <see cref="User"/> object of the currently logged in user 
        /// </summary>
        public User CurrentUser { get; set; }

        /// <summary>
        /// Returns the ID of the currently logged in user 
        /// </summary>
        public int CurrentUserID { get; set; }

        /// <summary>
        /// The current user's wrapper for extended functionality
        /// </summary>
        public UserWrapper CurrentUserWrapper { get; set; }

        /// <summary>
        /// The current user's school db obj
        /// </summary>
        public School CurrentUserSchool { get; set; }

        /// <summary>
        /// Returns the active user's challenge row from the database
        /// </summary>
        public ChallengesTable CurrentUserChallengeRow { get; set; }

        /// <summary>
        /// The current users account setting information
        /// </summary>
        public UserAccountSetting CurrentUserAccountSettings { get; set; }


        #endregion Current User Properties

        #region School Properties

        /// <summary>
        /// A list of all the schools fron the database
        /// </summary>
        public List<School> AllSchools { get; set; }

        #endregion School Properties


        //TODO Remove these challenge ones since they're only used within the model
        #region Challenge Properties

        /// <summary>
        /// The challenges plugin
        /// </summary>
        public CVChallengePlugin.CVChallengePlugin ChallengePlugin { get; set; }

        /// <summary>
        /// Holds the event handling for challenges
        /// </summary>
        //public ChallengeHandler ChallengeHandler { get; set; }

        /// <summary>
        /// Returns the users challenge status for all challenges in the challenge plugin
        /// </summary>
        public List<UserChallengeProgressData> UserChallengeProgress { get; set; }

        #endregion Challenge Properties


        

        public int VideoId { get; set; }
        //public UrlHelper Url { get; set; }
        public IEnumerable<Tuple<Comment, User>> CommentUserTuples { get; set; }


        #region Tutorial Functions
        /// <summary>
        /// Indicates if the tutorial should be shown when the page loads
        /// </summary>
        public bool ShowTutorial { get; set; }

        /// <summary>
        /// Indicates if a user is logged in and attempting to view the page
        /// </summary>
        public bool UserLoggedIn { get; set; }

        #endregion

        // TODO: Move to profile model
        #region Profile Model

        public User DesiredUser { get; set; }
        public School DesiredSchool { get; set; }
        public UserAccountSetting DesiredUserAccountSettigs { get; set; }

        public ChallengesTable DesiredUserChallengeRow { get; set; }

        public IEnumerable<User> Followers { get; set; }
        public IEnumerable<User> FollowingUsers { get; set; }
        public bool isFollowing { get; set; }

        public bool isBlocked { get; set; }
        public bool isBlocking { get; set; }

        public List<AccoladeDisplay> AccoladeDisplays { get; set; }

        /// <summary>
        /// Used to populate accolade information on the view 
        /// </summary>
        public struct AccoladeDisplay
        {
            /// <summary>
            /// The accolades image location
            /// </summary>
            public string AccImgLoc;
            public string ChallengeAccText;
            public int AccoladeLvl;
        }

        #endregion Profile Model

        // TODO: Move to school model
        #region School Model

        public School School { get; set; }
        public IEnumerable<School> SchoolsDescendingByPoints { get; set; }
        public double LengthOfPointsBar { get; set; }

        #endregion School Model





    }
}
