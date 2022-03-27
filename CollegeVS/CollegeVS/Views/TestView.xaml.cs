using System;
using System.Collections.Generic;
using Xamarin.CommunityToolkit;
using CollegeVS.ViewModels;
using Xamarin.Forms;
using Xamarin.CommunityToolkit.UI.Views;
using System.Threading.Tasks;

namespace CollegeVS.Views
{
    public partial class TestView : ContentView
    {
        private MediaElement _mediaElement;
        public TestView()
        {
            InitializeComponent();



        }
        public static readonly BindableProperty IsPlayingProperty =
            BindableProperty.Create(nameof(IsPlaying), typeof(bool),
                typeof(TestView), false, propertyChanged: OnIsPlayingChanged);

        private static void OnIsPlayingChanged(BindableObject bindable, object oldvalue, object newvalue)
        {

            if (!(bindable is TestView home))
            {
                return;
            }
            if (home.Stopped == true)
            {

                //home.previewVideo.Stop();



                home.previewVideo.Pause();



            }

            if (home.Stopped == false)
            {

                //home.previewVideo.Stop();



                home.previewVideo.Play();



            }


            if (home.IsPlaying == true)
            {

                //home.previewVideo.Stop();

                
              
                home.previewVideo.Play();
                


            }
            if (home.IsPlaying == false)
            {

                //home.previewVideo.Stop();

                home.previewVideo.Position = TimeSpan.FromSeconds(0);
        
                home.previewVideo.Pause();




            }

        }

        public bool IsPlaying
        {
            get => (bool)GetValue(IsPlayingProperty);
            set => SetValue(IsPlayingProperty, value);
        }

        public static readonly BindableProperty StoppedProperty =
           BindableProperty.Create(nameof(Stopped), typeof(bool),
               typeof(TestView), false, propertyChanged: OnIsPlayingChanged);

        public bool Stopped
        {
            get => (bool)GetValue(StoppedProperty);
            set => SetValue(StoppedProperty, value);
        }




        public static readonly BindableProperty PostVideoProperty =
          BindableProperty.Create(nameof(PostVideo), typeof(string),
                 typeof(TestView));

        public string PostVideo
        {
            get => (string)GetValue(PostVideoProperty);
            set => SetValue(PostVideoProperty, value);
        }

        void previewVideo_PropertyChanged(System.Object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            
            
            if (Stopped == true)
            {
               previewVideo.Pause();
           }
            


            if (IsPlaying == false)
            {
                //previewVideo.Position = TimeSpan.FromSeconds(0);
                previewVideo.Pause();

                //previewVideo.Stop();

            }
          

        }

        void previewVideo_PropertyChanging(System.Object sender, Xamarin.Forms.PropertyChangingEventArgs e)
        {
            

        }
    }
}
