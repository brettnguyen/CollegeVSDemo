using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CollegeVS.Models;
using CollegeVS.ViewModels;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollegeVS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewVideoControl : ContentView
    {
        private MediaElement _mediaElement;
       
        public ViewVideoControl()
        {
            InitializeComponent();

           
        }

        public static readonly BindableProperty IsPlayingProperty =
             BindableProperty.Create(nameof(IsPlaying), typeof(bool),
                 typeof(ViewVideoControl), false, propertyChanged: OnIsPlayingChanged);

        private static void OnIsPlayingChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            if (!(bindable is ViewVideoControl home))
            {
                return;
            }

      
         
           if (home.IsPlaying == true)
            {


               if (home._mediaElement == null)
                  {
                      home._mediaElement = new MediaElement
                      {
                          Source = home.PostVideo,
                          Aspect = Aspect.AspectFill,
                          ShowsPlaybackControls = false
                      };
                          home.Container.Children.Add(home._mediaElement);                  

                  }
               
                home._mediaElement.Play();
                

                if (home.Stopped == true)
                {
                    home._mediaElement.Pause();
                }

                else
                {
                    home._mediaElement.Play();
                }

                
            }
            else
            {
               
                    
                    home._mediaElement.Pause();
               
                home._mediaElement.Position = TimeSpan.FromSeconds(0);
                
                
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

        public static readonly BindableProperty ResetProperty =
        BindableProperty.Create(nameof(Reset), typeof(bool),
            typeof(TestView), false, propertyChanged: OnIsPlayingChanged);

        public bool Reset
        {
            get => (bool)GetValue(ResetProperty);
            set => SetValue(ResetProperty, value);
        }

      

        public static readonly BindableProperty PostVideoProperty =
          BindableProperty.Create(nameof(PostVideo), typeof(string),
                 typeof(ViewVideoControl));

        public string PostVideo
        {
            get => (string)GetValue(PostVideoProperty);
            set => SetValue(PostVideoProperty, value);
        }

        


    }
}
