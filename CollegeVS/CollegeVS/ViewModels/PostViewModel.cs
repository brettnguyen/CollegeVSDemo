using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using CollegeVS.Views;

using Xamarin.Forms;


namespace CollegeVS.ViewModels
{
    public class PostViewModel : BaseViewModel
    {

        public Command GoBackCommand { get; set; }
        public Command PostCommand { get; set; }

        public Command DareCommand { get; set; }

        public PostViewModel()
        {
            Title = "Post Page";

            GoBackCommand = new Command(GoBack);
            PostCommand = new Command(Post);
            DareCommand = new Command(GoToDareList);

        }

        public async void GoBack()
        {
            // Perform click feedback
            //HapticFeedback.Perform(HapticFeedbackType.Click);

            // Or use long press    
            //HapticFeedback.Perform(HapticFeedbackType.LongPress);
            await Shell.Current.GoToAsync($"//{nameof(CLGVSHome)}");
        }
        public async void Post()
        {
            // Perform click feedback
            //HapticFeedback.Perform(HapticFeedbackType.Click);

            // Or use long press    
            //HapticFeedback.Perform(HapticFeedbackType.LongPress);


            await Shell.Current.GoToAsync($"//{nameof(CLGVSHome)}");
        }

        public async void GoToDareList()
        {

            await Shell.Current.GoToAsync($"//{nameof(CLGVSDaresList)}");
        }
    }
}
