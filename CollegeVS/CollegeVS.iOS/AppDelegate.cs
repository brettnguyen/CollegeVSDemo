﻿using System;
using System.Collections.Generic;
using System.Linq;

using FFImageLoading.Forms.Platform;

using Foundation;
using UIKit;
using FFImageLoading;
using SlideOverKit.iOS;
using ContextMenu.iOS;
using PanCardView.iOS;
using Xamarin.Forms;

using MediaManager;

namespace CollegeVS.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.SetFlags("CollectionView_Experimental");
            
            CrossMediaManager.Current.Init();
            global::Xamarin.Forms.Forms.Init();
            Device.SetFlags(new string[] { "MediaElement_Experimental" });
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init();
            //ImageCircleRenderer.Init();
            ContextMenuViewRenderer.Preserve();
            CardsViewRenderer.Preserve();
            Startup.Init();
            LoadApplication(new App());
            
            return base.FinishedLaunching(app, options);
        }
    }
}
