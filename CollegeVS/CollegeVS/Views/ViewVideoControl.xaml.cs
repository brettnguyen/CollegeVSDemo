using System;
using System.Collections.Generic;
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

            if (home.IsPlaying)
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
            }
            else
            {
                home._mediaElement.Stop();
                if (home.Container.Children.Contains(home._mediaElement))
                {
                    home.Container.Children.Remove(home._mediaElement);
                }

                home._mediaElement = null;
            }
        }

        public bool IsPlaying
        {
            get => (bool)GetValue(IsPlayingProperty);
            set => SetValue(IsPlayingProperty, value);
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
