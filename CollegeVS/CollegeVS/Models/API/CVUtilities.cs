using System;
namespace CollegeVS.Models.API
{
    /// <summary>
    /// Available filters to apply to a content list
    /// <summary> 
    public enum ContentLoadFilter
    {
        /// <summary>
        /// Applies no filter
        /// </summary>
        ALL = 0,

        /// <summary>
        /// Filters out all content
        /// </summary>
        PLACEHOLDER = 1,

        /// <summary>
        /// Filters for content from one user alone
        /// </summary>
        SPECIFIC_USER = 2,

        /// <summary>
        /// Filters for content a specific user has posted and shared (Default Profile Page)
        /// </summary>
        SPECIFIC_USER_SHARES = 3,

        /// <summary>
        /// Filters for user's content from a specific school
        /// </summary>
        SPECIFIC_SCHOOL = 4,

        /// <summary>
        /// Filters for a single content
        /// </summary>
        SINGLE_CONTENT = 5,

        /// <summary>
        /// Filters for content from Parties category
        /// </summary>
        PARTIES = 6,

        /// <summary>
        /// Filters for content from Sports category
        /// </summary>
        SPORTS = 7,

        /// <summary>
        /// Filters for content from Dorms category
        /// </summary>
        DORMS = 8,

        /// <summary>
        /// Filters for content from Clubs category
        /// </summary>
        CLUBS = 9,

        /// <summary>
        /// Filters for content from Food category
        /// </summary>
        FOOD = 10,

        /// <summary>
        /// Filters for content from Other category
        /// </summary>
        OTHER = 11,

        /// <summary>
        /// Filters the content using the Judarythm
        /// </summary>
        JUDARYTHM = 12
    }

    /// <summary>
    /// The available sorting options 
    /// </summary>
    public enum SortContentBy
    {
        /// <summary>
        /// No direct purpose as of [6/27/2020]
        /// </summary>
        PLACEHOLDER = 0,

        /// <summary>
        /// Latest first
        /// </summary>
        DATE_DESC = 1,

        /// <summary>
        /// Longest ago
        /// </summary>
        DATE_INC = 2,

        /// <summary>
        /// Highest points first 
        /// </summary>
        POINTS_DESC = 3,

        /// <summary>
        /// Lowest points first
        /// </summary>
        POINTS_INC = 4,

        /// <summary>
        /// Highest VS Score first
        /// </summary>
        VS_SCORE_DESC = 5,

        /// <summary>
        /// Lowest VS Score first
        /// </summary>
        VS_SCORE_INC = 6,

        /// <summary>
        /// Highest number of votes first 
        /// </summary>
        VOTES_DESC = 7,

        /// <summary>
        /// Lowest number of votes first
        /// </summary>
        VOTES_INC = 8,

        /// <summary>
        /// Highest number of shares first 
        /// </summary>
        SHARES_DESC = 9,

        /// <summary>
        /// Lowest number of shares first
        /// </summary>
        SHARES_INC = 10
    }

    /// <summary>
    /// The available sorting options when viewing a list of dares
    /// </summary>
    public enum DareLoadFilter
    {
        LATEST_FIRST = 0,
        DARE_CREATED = 1,
        DARE_DENIED = 2,
        DARE_ACCEPTED = 3,
        DENIED_RESPONSE = 4,
        ACCEPTED_RESPONSE = 5,
        DARE_ATTEMPTED_UPLOAD = 6

    }

    /// <summary>
    /// All available challenge types
    /// </summary>
    public enum ChallengeType
    {
    }

    /// <summary>
    /// All available categories to post to.
    /// </summary>
    public enum CVCategories
    {
        Parties = 1,
        Sports = 2,
        Dorms = 3,
        Clubs = 4,
        Food = 5,
        Other = 6
    }

    /// <summary>
    /// All types of events that can occur
    /// </summary>
    public enum EventType
    {
        BaseEvent = 0,
        UploadVideo = 1,
        UpVoteContent = 2,
        ShareVideo = 3,
        CommentVideo = 4,
        VisitPage = 5,
        VisitSchoolPage = 6,
        VisitProfilePage = 7,
        Login = 8,
        Register = 9,
        ViewVideoSingleContent = 10,
        UploadImage = 11,
        ReachNexTier = 12,
        FollowUser = 13,
        CommentContent = 14,
        DeleteVideo = 15,
        FlagPost = 16,
        BlockUser = 17,
        DeleteUser = 18,
        ReachFinalTier = 19,
        AdminDeleteFlaggedPost = 20,
        LikeComment = 21,
        ToggleDisplayRealName = 22,
        MuteUser = 23,
        ToggleAlumniStatus = 24
    }

    /// <summary>
    /// The type of content being reference
    /// </summary>
    public enum ContentType
    {
        Video,
        Image
    }

    /// <summary>
    /// All the types of notifications that can happen
    /// /// WARNING: DO NOT EDIT THESE VALUES - DB depends on these values
    /// </summary>
    public enum NotificationType
    {
        /// <summary>
        /// Not expected to be used. (Default in db)
        /// </summary>
        DEFAULT = 0,

        /// <summary>
        /// Indicates a global message from the CV team
        /// </summary>
        CV_GLOBAL = 1,

        /// <summary>
        /// Indicates a direct messages to a user from the CV Team
        /// </summary>
        CV_DIRECT = 2,

        /// <summary>
        /// Indicates when a user has been followed
        /// </summary>
        FOLLOWED = 3,

        /// <summary>
        /// Someone you are following posted content
        /// </summary>
        FOLLOWING_POSTED = 4,

        SHARED_VIDEO = 5,
        SHARED_IMAGE = 6,
        UPVOTE_VIDEO = 7,
        UPVOTE_IMAGE = 8,
        COMMENT_VIDEO = 9,
        COMMENT_IMAGE = 10,
        CHLNG_COMPLETE = 11,
        CHLNG_UPDATE = 12,
        UPVOTE_CONTENT = 13,
        COMMENT_CONTENT = 14,
        SHARED_CONTENT = 15,

        CHLNG_NEW_TIER = 16,

        DARE_EVENT = 17,

        ACCOLADE_NEW_LVL = 18,

        /// <summary>
        /// Indicates when a post is flagged for inappropriate content
        /// </summary>
        FLAG_CONTENT = 19,

        /// <summary>
        /// Indicates a post has reached the max number of allowed flags
        /// </summary>
        FLAG_CONTENT_MAX = 20,

        /// <summary>
        /// Indicates when a post has been deleted by an admin for reaching the flag limit
        /// </summary>
        ADMIN_DELETED_FLAGGED_CONTENT = 21,

        /// <summary>
        /// Indicates when a comment has been liked
        /// </summary>
        LIKE_COMMENT = 22
    }

    /// <summary>
    /// Enumerated states that a <see cref="Dare"/> can be in
    /// WARNING: DO NOT EDIT THESE VALUES - DB depends on these values
    /// </summary>
    public enum DareState
    {
        /// <summary>
        /// Dares enter this state from creation - 
        /// Original user and is waiting for the challenged user to respond (Accept/Deny)
        /// </summary>
        PendingResponse = 0,

        /// <summary>
        /// Dares enter this state after being denied/timeout - 
        /// Dare has been denied by the challenged user or the PendingResposnse timer expired
        /// </summary>
        Cancelled = 1,

        /// <summary>
        /// Dares enter this state after being accepted - 
        /// Dare has been accepted by the challenged user and is awaiting a response
        /// </summary>
        InProgress = 2,

        /// <summary>
        /// Dares enter this state after a response from challenges has been posted - 
        /// Dare has been responded to and awaits the challengers validation
        /// </summary>
        PendingValidation = 3,

        /// <summary>
        /// Dares enter this state after being rejected by the challenging user
        /// </summary>
        FailedDare = 4,

        /// <summary>
        /// Dares enter this state after being accepted by the challenging user
        /// </summary>
        PassedDare = 5
    }

    /// <summary>
    /// Enumerated transitions a Dare can go through in refernce to it's state machine
    /// WARNING: DO NOT EDIT THESE VALUES - DB depends on these values
    /// </summary>
    public enum DareTransition
    {
        /// <summary>
        /// Dare is being created as a new entry
        /// </summary>
        DareCreated = 0,

        /// <summary>
        /// Time has expired for some state countdown
        /// </summary>
        TimeExpired = 1,

        /// <summary>
        /// Dare is being denied from the challenged user
        /// </summary>
        DareDenied = 2,

        /// <summary>
        /// Dare is being accepted by the challenged user
        /// </summary>
        DareAccepted = 3,

        /// <summary>
        /// Dare response has been denied by the challenging user
        /// </summary>
        DeniedResponse = 4,

        /// <summary>
        /// Dare response has been accepted by the challenging user
        /// </summary>
        AcceptedResponse = 5,

        /// <summary>
        /// The challenged user is responding to a dare.
        /// </summary>
        DareAttemptedUpload = 6,

        /// <summary>
        /// The challenged user is responding to a dare with a previously uploaded post
        /// </summary>
        DareAttemptedSelection = 7,

        /// <summary>
        /// The challenged user accepted the dare, but wants to wait to complete it at a later date
        /// </summary>
        DareBackout = 8
    }

    /// <summary>
    /// Enum to indicate what page is being requested
    /// Originally created to generate correct GetNextContent for a filtered page
    /// </summary>
    public enum CLGVSPageType
    {
        HomePage = 0,
        ProfilePage = 1,
        SchoolPage = 2
    }

    

    public class CVUtilities
    {

        public const ContentLoadFilter DEFAULT_HOME_PAGE_FILTER = ContentLoadFilter.ALL;

        public const ContentLoadFilter DEFAULT_PROFILE_PAGE_FILTER = ContentLoadFilter.SPECIFIC_USER_SHARES;

        public const ContentLoadFilter DEFAULT_SCHOOL_PAGE_FILTER = ContentLoadFilter.SPECIFIC_SCHOOL;


        public CVUtilities()
        {
        }
    }
}
