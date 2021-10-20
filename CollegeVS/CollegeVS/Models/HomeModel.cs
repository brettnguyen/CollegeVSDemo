using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Lottie.Forms;
namespace CollegeVS.Models
{
    public class HomeModel : INotifyPropertyChanged
	{

		

		private bool seen;

		public bool Seen
		{
			get { return seen; }
			set
			{
				seen = value;
				OnPropertyChanged();
			}
		}

		private bool back;

		public bool Back
		{
			get { return back; }
			set
			{
				back = value;
				OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public string ProfilePicture { get; set; }

		public string Username { get; set; }
		public string College { get; set; }

		public string PostImage { get; set; }

		public string PostDetail { get; set; }

		public int PostUpvoteCount { get; set; }

		public string CurrentItem { get; set; }

		public string PostCommentCount { get; set; }

		public int PostShareCount { get; set; }

		public string PostTime { get; set; }

		public string Category { get; set; }


		public string Title { get; set; }


	}
}
