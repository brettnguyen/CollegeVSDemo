using System;
using System.Collections.Generic;
using CollegeVS.Models.API.EntityModels;

namespace CollegeVS.Models.API.HelperClasses
{
    public class CommentWrapper
    {
        /// <summary>
        /// The comment this class is wrapping
        /// </summary>
		public Comment Comment { get; set; }

        /// <summary>
        /// The user who made this comment 
        /// </summary>
        public User CommentingUser { get; set; }

        /// <summary>
        /// The id of the user who made this comment 
        /// </summary>
        public int CommentingUserID { get; set; }

        /// <summary>
        /// The list of <see cref="CommentLike"/> for all the likes on this comment
        /// </summary>
        public IEnumerable<CommentLike> CommentLikes { get; set; }

        /// <summary>
        /// The count of likes that the comment has
        /// </summary>
        public int CommentLikeCount { get; set; }

        /// <summary>
        /// The text to display on the Like Comment button
        /// </summary>
        public string LikeCommentDisplayText { get; set; }

        /// <summary>
        /// The string id of the comment of this wrapper
        /// </summary>
		public string Comment_ID { get { return this.Comment.Comment_ID.ToString(); } }

        /// <summary>
        /// The id for the Like button on a comment
        /// </summary>
        public string Like_ID => "Like" + Comment_ID;

        /// <summary>
        /// The id for the Reply button on a comment
        /// </summary>
        public string Reply_ID => "Reply" + Comment_ID;

        /// <summary>
        /// The id for the Like Comment Form for a comment
        /// </summary>
        public string LikeCommentForm_ID => "LikeCommentForm" + Comment_ID;

        /// <summary>
        /// The id for the LikeCommentButton on a comment
        /// </summary>
        public string LikeCommentButton_ID => "LikeCommentButton" + Comment_ID;

        /// <summary>
        /// THe name for the LikeCommentForm of a comment
        /// </summary>
        public string LikeCommentFormName_ID => "LikeCommentFormName_ID" + Comment_ID;

        /// <summary>
        /// The id for the comment like count display
        /// </summary>
        public string CommentLikeCount_ID => "CommentLikeCountID" + Comment_ID;

        /// <summary>
        /// The id for the comment likes user modal display. Used for a place to put the ajax returned content
        /// </summary>
        public string CommentLikesModalPlaceholder => "CommentLikeModalPlaceholder_ID" + Comment_ID;
    }
}
