using System;
using System.Collections.Generic;
using CollegeVS.Models.API.EntityModels;

namespace CollegeVS.Models.API.HelperClasses
{
    public class VideoWrapper
    {
        /// <summary>
        /// The video being wrapped : Required
        /// </summary>
        public Video Video { get; set; }

        /// <summary>
        /// The votes from the db : Required
        /// </summary>
        public IEnumerable<Vote> Votes { get; set; }

        /// <summary>
        /// List of the users that have currently voted on the video
        /// </summary>
        public IEnumerable<User> VotedUsers { get; set; }

        /// <summary>
        /// List of the users that have currently shared the video
        /// </summary>
        public IEnumerable<User> SharingUsers { get; set; }

        /// <summary>
        /// List of video shares (Can be empty)
        /// </summary>
        public IEnumerable<SharedVideo> Shares { get; set; }

        /// <summary>
        /// List of <see cref="CommentWrapper"/> : Required
        /// </summary>
        public IEnumerable<CommentWrapper> CommentWrappers { get; set; }


        // HELPER PROPERTIES

        /// <summary>
        /// True if the current user has shared this video
        /// </summary>
        public bool CurrentUserShared { get; }

        /// <summary>
        /// True if the video has been shared by ANY user
        /// </summary>
        public bool SharedByDesiredUser { get; set; }

        /// <summary>
        /// The absolute path to the catgory image of the video
        /// </summary>
        public string CategoryImgAbsPath { get; set; }

        /// <summary>
        /// True if the user has upvoted this video
        /// </summary>
        public bool CurrentUserUpvoted { get; set; }

        /// <summary>
        /// The absolute path to the users 
        /// </summary>
        public string ContentAbsPath { get; set; }

        /// <summary>
        /// The type of this content
        /// </summary>
        public ContentType ContentType { get; set; }

        /// <summary>
        /// True if the user is the user that uploaded the content
        /// </summary>
        public bool CurrentUserIsUploader { get; set; }

        /// <summary>
        /// This video's uploader's absolute path to avatar
        /// </summary>
        public string UploaderAvatarAbsPath { get; set; }

        public string Video_Id
        {
            get { return this.Video.Video_Id.ToString(); }
        }

        /// <summary>
        /// The Play/Pause Button associated with this video
        /// </summary>
        public string PlayPause
        {
            get { return "PlayPause" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The CountUp associated with this video
        /// </summary>
        public string CountUp
        {
            get { return "CountUp" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The VolumeBar associated with this video
        /// </summary>
        public string VolumeBar
        {
            get { return "VolumeBar" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The FullScreen associated with this video
        /// </summary>
        public string FullScreen
        {
            get { return "FullScreen" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The Mute associated with this video
        /// </summary>
        public string Mute
        {
            get { return "Mute" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The SeekBar associated with this video
        /// </summary>
        public string SeekBar
        {
            get { return "SeekBar" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The UpVoteButton associated with this video
        /// </summary>
        public string UpVoteButton
        {
            get { return "UpVoteButton" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The UpVoteForm associated with this video
        /// </summary>
        public string UpVoteForm
        {
            get { return "UpVoteForm" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The UpvoteDisplayImag associated with this content
        /// </summary>
		public string UpvoteDisplayImg
        {
            get { return "UpvoteDisplayImg" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The DownVoteButton associated with this video
        /// </summary>
        public string DownVoteButton
        {
            get { return "DownVoteButton" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The ToggleUpVoteButton associated with this video
        /// </summary>
        public string ToggleUpVoteButton
        {
            get { return "ToggleUpVoteButton" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The ToggleDownVoteButton associated with this video
        /// </summary>
        public string ToggleDownVoteButton
        {
            get { return "ToggleDownVoteButton" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The ScoreValue associated with this video
        /// </summary>
        public string ScoreValue
        {
            get { return "ScoreValue" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The HTML id for the comment submit button
        /// </summary>
        public string CommentSubmit
        {
            get { return "CommentSubmit" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The HTML id for the area holding the comment count
        /// </summary>
        public string CommentCountID
        {
            get { return "CommentCount" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The HTML id for the area holding the comment text
        /// </summary>
		public string CommentText
        {
            get { return "SubmitOnEnter" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The HTML id for the area holding the comment section/container
        /// </summary>
		public string CommentContainer
        {
            get { return "CommentContainer" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The HTML id for the area holding the share button
        /// </summary>
		public string ShareButtonID
        {
            get { return "ShareButtonID" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The HTML id for the area holding the repost count information
        /// </summary>
		public string ShareCountID
        {
            get { return "ShareCountID" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The HTML id for the area holding the repost icon
        /// </summary>
		public string RepostIconID
        {
            get { return "RepostIconID" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The HTML id for the area holding the votes section/container
        /// </summary>
		public string VoteContainer
        {
            get { return "VoteContainer" + this.Video.Video_Id; }
        }

        /// <summary>
        /// The HTML id for the area holding list of votes on the content
        /// </summary>
		public string VoteList
        {
            get { return "VoteList" + this.Video.Video_Id; }
        }

        public string ShareList
        {
            get { return "ShareList" + this.Video.Video_Id; }
        }


        public string DateValue
        {
            get { return "DateValue" + this.Video.Video_Id; }
        }

        public string CaretLocation
        {
            get { return "caretLocation" + this.Video.Video_Id; }
        }
        public string CurrentComment
        {
            get { return "CurrentComment" + this.Video.Video_Id; }
        }
        public string CommentInfo
        {
            get { return "CommentInfo" + this.Video.Video_Id; }
        }
        public string ChooseUser
        {
            get { return "ChooseUser" + this.Video.Video_Id; }
        }

        public string UserInfo
        {
            get { return "UserInfo" + this.Video.Video_Id; }
        }

        public string Breakdown
        {
            get { return "Breakdown" + this.Video.Video_Id; }
        }

        /// <summary>
        /// Returns a string of the time since the content was uploaded
        /// </summary>
        public string TimeSinceUpload { get; }

        public Dare Dare { get; set; }

        public User TxDareUser { get; set; }

        public User RxDareUser { get; set; }
    }
}
