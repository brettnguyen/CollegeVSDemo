using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;

using Android.OS;

using FFImageLoading.Forms.Platform;
using SlideOverKit;
using FFImageLoading;
using Plugin.CurrentActivity;
using Android;
using Google.Android.Material.Snackbar;
using Xamarin.Forms;
using Plugin.Permissions.Abstractions;
using Plugin.Permissions;
using AndroidX.Core.Content;
using AndroidX.Core.App;
using ContextMenu.Droid;
using PanCardView.Droid;
using MediaManager;

namespace CollegeVS.Droid
{
    [Activity(Label = "CollegeVS", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public const int CameraPermissionsCode = 1;

        public static readonly string[] CameraPermissions =
        {
            Manifest.Permission.Camera,
            Manifest.Permission.RecordAudio,
            Manifest.Permission.ReadExternalStorage,
            Manifest.Permission.WriteExternalStorage
        };

		public static event EventHandler CameraPermissionGranted;

        private bool cameraPermissions()
        {
            const string permission = Manifest.Permission.Camera;

            if ((int)Build.VERSION.SdkInt < 23 || ContextCompat.CheckSelfPermission(Android.App.Application.Context, permission) == Android.Content.PM.Permission.Granted)
            {
                return true;
            }

            ActivityCompat.RequestPermissions(this, CameraPermissions, CameraPermissionsCode);
            return false;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#10466C"));
            var permissions = cameraPermissions();

            CrossCurrentActivity.Current.Init(this, savedInstanceState);

            CrossMediaManager.Current.Init(this);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            Device.SetFlags(new string[] { "MediaElement_Experimental" });
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init(true);
            //Startup.Init();
            CardsViewRenderer.Preserve();
            LoadApplication(new App());

       
        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {


            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            Plugin.Permissions.PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}