﻿using Android;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.Media;
using Android.OS;
using AndroidX.Core.App;
using AndroidX.Core.Content;
using CollegeVS.Droid.Pages;
using CollegeVS.Renderers;
using CollegeVS.Views;
using System.IO;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Core;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CameraView), typeof(CameraViewServiceRenderer))]
namespace CollegeVS.Droid.Pages
{
	public class CameraViewServiceRenderer : ViewRenderer<CameraView, CameraPageCS>
	{
		private CameraPageCS _camera;
		private readonly Context _context;

		public CameraViewServiceRenderer(Context context) : base(context)
		{
			_context = context;
		}



		protected override void OnElementChanged(ElementChangedEventArgs<CameraView> e)
		{
			base.OnElementChanged(e);

			var permissions = CameraPermissions();
			_camera = new CameraPageCS(Context);
			
			//CameraOptions CameraOption = e.NewElement?.Camera ?? CameraOptions.Rear;
			CameraOptions CameraOption = CameraOptions.Rear;
			if (Control == null)
			{
				if (permissions)
				{
					_camera.OpenCamera(CameraOption);

					SetNativeControl(_camera);
				}
				else
				{
				}
			}

			if (e.NewElement != null && _camera != null)
			{
				var check = e.NewElement;
				_camera.Photo += OnPhoto;
				_camera.Video += OnVideo;
				_camera.Orient += OnOrient;
			}
		}

		public async void OnPhoto(object sender, ImageSource imgSource)
		{
			var imageData = await RotateImageToPortrait(imgSource);

			Device.BeginInvokeOnMainThread(() =>
			{
				Views.Post.OnPhotoCaptured(imageData);
			});
		}

		public void OnVideo(object sender, MediaSource vidSource)
		{
			Device.BeginInvokeOnMainThread(() =>
			{
				Views.Post.OnVideoCaptured(vidSource);
			});
		}

		public void OnOrient(object sender, int cameraOrientation)
		{
			Device.BeginInvokeOnMainThread(() =>
			{
				Views.Post.OnOrientation(cameraOrientation);
			});
		}
		protected override void Dispose(bool disposing)
		{
			_camera.Photo -= OnPhoto;
			_camera.Video -= OnVideo;
			_camera.Orient -= OnOrient;
			base.Dispose(disposing);
		}

		private bool CameraPermissions()
		{
			const string permission = Manifest.Permission.Camera;

			if ((int)Build.VERSION.SdkInt < 23 || ContextCompat.CheckSelfPermission(Android.App.Application.Context, permission) == Permission.Granted)
			{
				return true;
			}
			
			ActivityCompat.RequestPermissions((MainActivity)_context, MainActivity.CameraPermissions, MainActivity.CameraPermissionsCode);
			return false;
		}

		// ReSharper disable once UnusedMember.Local
		private async Task<ImageSource> RotateImageToPortrait(ImageSource imgSource)
		{
			var imagesourceHandler = new StreamImagesourceHandler();
			var photoTask = imagesourceHandler.LoadImageAsync(imgSource, _context);

			var photo = await photoTask;

			var matrix = new Matrix();

			matrix.PreRotate(90);
			photo = Bitmap.CreateBitmap(photo, 0, 0, photo.Width, photo.Height, matrix, false);
			matrix.Dispose();

			var stream = new MemoryStream();
			photo.Compress(Bitmap.CompressFormat.Jpeg, 50, stream);
			stream.Seek(0L, SeekOrigin.Begin);

			return ImageSource.FromStream(() => stream);
		}
	}
}