using CollegeVS.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CollegeVS.ViewModels
{
  public class CommentViewModel : BindableObject
    {

     

        private ObservableCollection<OtherUserCommentsModel> others;
        public ObservableCollection<OtherUserCommentsModel> Others
        {
            get { return others; }
            set
            {

                others = value;
                OnPropertyChanged();
            }

        }
        private ObservableCollection<CommentsModel> items;
        public ObservableCollection<CommentsModel> Items
        {
            get { return items; }
            set
            {

                items = value;
                OnPropertyChanged();
            }

        }
        public ICommand AddCommentCommand { get; }

        public ICommand DeleteCommentCommand { get; set; }

        public ICommand ForceCloseCommand { get; set; }

        private string yourComment;
        public string YourComment { get { return yourComment; }
            set { yourComment = value; OnPropertyChanged(yourComment); }
        }
        
        

        public CommentViewModel()
        {

          

            YourComment = "";
            Others = new ObservableCollection<OtherUserCommentsModel>
            {
                new OtherUserCommentsModel()
                {
                    OtherProfilePicture = "UserIcon.png",
                    OtherUsername = "OtherUser",
                    OtherComment = "Marine biologist from the University of Florida amp avid Scottish kindrochit participant Looking for the next greatest algal bloom to tackle",
                    OtherEnable ="True"
                },
                   new OtherUserCommentsModel()
                {
                    OtherProfilePicture = "UserIcon.png",
                    OtherUsername = "OtherUser",
                    OtherComment = "Marine biologist from the University of Florida amp avid Scottish kindrochit participant Looking for the next greatest algal bloom to tackle",
                    OtherEnable ="True"
                },
                      new OtherUserCommentsModel()
                {
                    OtherProfilePicture = "UserIcon.png",
                    OtherUsername = "OtherUser",
                    OtherComment = "Marine biologist from the University of Florida amp avid Scottish kindrochit participant Looking for the next greatest algal bloom to tackle",
                    OtherEnable ="True"
                },
                         new OtherUserCommentsModel()
                {
                    OtherProfilePicture = "UserIcon.png",
                    OtherUsername = "OtherUser",
                    OtherComment = "This is a comment",
                    OtherEnable ="True"
                },
                            new OtherUserCommentsModel()
                {
                    OtherProfilePicture = "UserIcon.png",
                    OtherUsername = "OtherUser",
                    OtherComment = "This is a comment",
                    OtherEnable ="True"
                },
                               new OtherUserCommentsModel()
                {
                    OtherProfilePicture = "UserIcon.png",
                    OtherUsername = "OtherUser",
                    OtherComment = "This is a comment",
                    OtherEnable ="True"
                },
                                  new OtherUserCommentsModel()
                {
                    OtherProfilePicture = "UserIcon.png",
                    OtherUsername = "OtherUser",
                    OtherComment = "This is a comment",
                    OtherEnable ="True"
                },


            };

            Items = new ObservableCollection<CommentsModel>
            {
                new CommentsModel()
                {
                    ProfilePicture = "",
                Username = "",
               Comment = "",
               Enable = "False"
           
               
                }
            };

            AddCommentCommand = new Command(AddItems);

            DeleteCommentCommand = new Command(DeleteItems);
        }

        void AddItems(Object obj)
        {
            CommentsModel commentsModel = new CommentsModel();
            commentsModel.ProfilePicture = "UserIcon.png";
            commentsModel.Username = "Username";
            commentsModel.Enable = "True";
            commentsModel.Comment = YourComment;
            Items.Insert(0,commentsModel);
       

        }

        void DeleteItems (object obj)
        {
            var content = obj as CommentsModel;
            Items.Remove(content);
        }
    }
}
