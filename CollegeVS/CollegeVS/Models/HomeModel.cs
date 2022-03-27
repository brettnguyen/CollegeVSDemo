using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Lottie.Forms;
using Xamarin.CommunityToolkit.UI.Views;

namespace CollegeVS.Models
{
    public class HomeModel : INotifyPropertyChanged
	{
		MediaElement mediaElement = new MediaElement();
		private string  currentItem;
		public string CurrentItem
		{
			get { return currentItem; }
			set { OnPropertyChanged();
}
		}

		private bool isPlaying;
		public bool IsPlaying
		{
			get { return isPlaying; }
			set
			{
				isPlaying = value;
				OnPropertyChanged();
			}
		}

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

		private bool stopped;

		public bool Stopped
		{
			get { return stopped; }
			set
			{
				stopped = value;
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

		

		public string PostCommentCount { get; set; }

		public int PostShareCount { get; set; }

		public string PostTime { get; set; }

		public string Category { get; set; }

		public string PostVideo { get; set; }
		public string Title { get; set; }
		public int commentid { get; set; }


	}
}
