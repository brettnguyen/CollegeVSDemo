using Android.Content;
using Android.Graphics;
using Android.Hardware.Camera2;
using Android.Hardware.Camera2.Params;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using CollegeVS.Droid.Pages;
using CollegeVS.Renderers;
using CollegeVS.Views;
using Java.IO;
using Java.Lang;
using Java.Util.Concurrent;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.CommunityToolkit.Core;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Size = Android.Util.Size;

namespace CollegeVS.Droid.Pages
{
	public class CameraPageCS: FrameLayout, TextureView.ISurfaceTextureListener
	{
		private static readonly SparseIntArray Orientations = new SparseIntArray();

		public event EventHandler<ImageSource> Photo;
		public event EventHandler<MediaSource> Video;
		public event EventHandler<int> Orient;

		public bool OpeningCamera { private get; set; }

		public CameraDevice CameraDevice;

		private readonly CameraStateListener _mStateListener;
		private CaptureRequest.Builder _previewBuilder;
		private CameraCaptureSession _previewSession;
		private SurfaceTexture _viewSurface;
		private readonly TextureView _cameraTexture;
		public MediaRecorder mediaRecorder;
		private Size _previewSize;
		private readonly Context _context;
		private CameraManager _manager;
		private CaptureRequest.Builder previewBuilder;
		public string file;
		int cameraOption;
		bool recording;
		System.Threading.Timer timer;

		public CameraPageCS(Context context) : base(context)
		{
			_context = context;

			cameraOption = 0;

			var inflater = LayoutInflater.FromContext(context);

			if (inflater == null) return;
			Post post = new Post();

			var clickable = post.FindByName("doCameraThings");

			Xamarin.Forms.ImageButton button = clickable as Xamarin.Forms.ImageButton;

			var view = inflater.Inflate(Resource.Layout.CameraLayout, this);

			LinearLayout _cameralinear = view.FindViewById<LinearLayout>(Resource.Id.clinear);

			_cameraTexture = view.FindViewById<TextureView>(Resource.Id.cameraTexture);

			var _switch = view.FindViewById<Android.Widget.ImageButton>(Resource.Id.switch_);

			Android.Widget.ImageButton _camerabutton = view.FindViewById<Android.Widget.ImageButton>(Resource.Id.cbutton);
			recording = false;

			_switch.Click += (sender, args) =>
			{
				if (cameraOption == 1)
				{
					cameraOption = 0;
					Matrix m = new Matrix();
					m.PreScale(1, 1, _cameraTexture.Width / 2, _cameraTexture.Height / 2);
					_cameraTexture.SetTransform(m);
				}
				else
				{
					cameraOption = 1;
					Matrix m = new Matrix();
					m.PreScale(-1, 1, _cameraTexture.Width / 2, _cameraTexture.Height/2);
					_cameraTexture.SetTransform(m);
				}
				CloseCamera();
				openCamera(_cameraTexture.Width, _cameraTexture.Height, cameraOption);
			};
			_cameralinear.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Up)
				{
					if (timer != null)
					{
						timer.Dispose();
					}
					if (!recording)
					{
						TakePhoto();
						mediaRecorder.Release();
						mediaRecorder = null;
						mediaRecorder = new MediaRecorder();
					}
					else
					{
						StopRecording();
						recording = false;

					}
				}
				else if (args.Event.Action == MotionEventActions.Down)
				{
					recording = false;
					StartRecording();
					timer = new System.Threading.Timer(changeTimerState, null, 500, 500);
				}
			};

			_camerabutton.Touch += (sender, args) =>
			{
				if (args.Event.Action == MotionEventActions.Up)
				{
					if (timer != null)
					{
						timer.Dispose();
					}
					if (!recording)
					{

						TakePhoto();
						mediaRecorder.Release();
						mediaRecorder = null;
						mediaRecorder = new MediaRecorder();
					}
					else
					{
						StopRecording();
						recording = false;

					}
				}
				else if (args.Event.Action == MotionEventActions.Down)
				{
					recording = false;
					StartRecording();
					timer = new System.Threading.Timer(changeTimerState, null, 500, 500);
				}
			};


			_cameraTexture.SurfaceTextureListener = this;

			_mStateListener = new CameraStateListener { Camera = this };

			Orientations.Append((int)SurfaceOrientation.Rotation0, 0);
			Orientations.Append((int)SurfaceOrientation.Rotation90, 90);
			Orientations.Append((int)SurfaceOrientation.Rotation180, 180);
			Orientations.Append((int)SurfaceOrientation.Rotation270, 270);
		}

		public void changeTimerState(object state)
		{
			recording = true;
		}

		public void OnSurfaceTextureAvailable(SurfaceTexture surface, int width, int height)
		{
			_viewSurface = surface;
			ConfigureTransform(width, height);
			StartPreview();
		}

		public bool OnSurfaceTextureDestroyed(SurfaceTexture surface)
		{
			return true;
		}

		public void OnSurfaceTextureSizeChanged(SurfaceTexture surface, int width, int height)
		{
		}

		public void OnSurfaceTextureUpdated(SurfaceTexture surface)
		{
		}

		public void OpenCamera(CameraOptions options)
		{
			if (_context == null || OpeningCamera)
			{
				return;
			}

			OpeningCamera = true;

			_manager = (CameraManager)_context.GetSystemService(Context.CameraService);

			var cameraId = _manager.GetCameraIdList()[cameraOption];

			var characteristics = _manager.GetCameraCharacteristics(cameraId);
			var map = (StreamConfigurationMap)characteristics.Get(CameraCharacteristics.ScalerStreamConfigurationMap);

			_previewSize = map.GetOutputSizes(Class.FromType(typeof(SurfaceTexture)))[0];
			_manager.OpenCamera(cameraId, _mStateListener, null);
			mediaRecorder = new MediaRecorder();

		}


		public void TakePhoto()
		{
			if (_context == null || CameraDevice == null) return;

			var characteristics = _manager.GetCameraCharacteristics(CameraDevice.Id);
			Size[] jpegSizes = null;
			if (characteristics != null)
			{
				jpegSizes = ((StreamConfigurationMap)characteristics.Get(CameraCharacteristics.ScalerStreamConfigurationMap)).GetOutputSizes((int)ImageFormatType.Jpeg);
			}
			var width = 480;
			var height = 640;

			if (jpegSizes != null && jpegSizes.Length > 0)
			{
				width = jpegSizes[0].Width;
				height = jpegSizes[0].Height;
			}

			var reader = ImageReader.NewInstance(height, width, ImageFormatType.Jpeg, 1);
			var outputSurfaces = new List<Surface>(2) { reader.Surface, new Surface(_viewSurface) };
			var captureBuilder = CameraDevice.CreateCaptureRequest(CameraTemplate.StillCapture);
			captureBuilder.AddTarget(reader.Surface);
			captureBuilder.Set(CaptureRequest.ControlMode, new Integer((int)ControlMode.Auto));
			var windowManager = _context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();
			var rotation = windowManager.DefaultDisplay.Rotation;
			captureBuilder.Set(CaptureRequest.JpegOrientation, new Integer(Orientations.Get((int)rotation)));

			var readerListener = new ImageAvailableListener();

			readerListener.Photo += (sender, buffer) =>
			{
				// "this" is the screen 
				Photo?.Invoke(this, ImageSource.FromStream(() => new MemoryStream(buffer)));
			};


			
			var thread = new HandlerThread("CameraPicture");
			thread.Start();
			var backgroundHandler = new Handler(thread.Looper);
			reader.SetOnImageAvailableListener(readerListener, backgroundHandler);

			var captureListener = new CameraCaptureListener();

			captureListener.PhotoComplete += (sender, e) =>
			{
				StartPreview();
			};
			CameraDevice.CreateCaptureSession(outputSurfaces, new CameraCaptureStateListener
			{
				OnConfiguredAction = session =>
				{
					try
					{
						_previewSession = session;
						session.Capture(captureBuilder.Build(), captureListener, backgroundHandler);
					}
					catch (CameraAccessException ex)
					{
						Log.WriteLine(LogPriority.Info, "Capture Session error: ", ex.ToString());
					}
				}
			}, backgroundHandler);
		}


		public void StartRecording()
		{
			if (_context == null || CameraDevice == null) return;
			var characteristics = _manager.GetCameraCharacteristics(CameraDevice.Id);
			Size[] jpegSizes = null;
			if (characteristics != null)
			{
				jpegSizes = ((StreamConfigurationMap)characteristics.Get(CameraCharacteristics.ScalerStreamConfigurationMap)).GetOutputSizes((int)ImageFormatType.Jpeg);
			}
			var width = 480;
			var height = 640;

			if (jpegSizes != null && jpegSizes.Length > 0)
			{
				width = jpegSizes[0].Width;
				height = jpegSizes[0].Height;
			}
			SurfaceTexture texture = _cameraTexture.SurfaceTexture;
			file = GetVideoFile(_context).AbsolutePath;
			System.Diagnostics.Debug.WriteLine(file);
			//Assert.IsNotNull(texture);
			texture.SetDefaultBufferSize(width, height);
			mediaRecorder.SetAudioSource(AudioSource.Mic);
			mediaRecorder.SetVideoSource(VideoSource.Surface);
			mediaRecorder.SetOutputFormat(OutputFormat.Mpeg4);
			mediaRecorder.SetOutputFile(file);
			//mediaRecorder.SetVideoEncodingBitRate(10000000);
			//mediaRecorder.SetVideoFrameRate(30);
			mediaRecorder.SetVideoSize(width, height);
			mediaRecorder.SetVideoEncoder(VideoEncoder.H264);
			mediaRecorder.SetAudioEncoder(AudioEncoder.Aac);
			var windowManager = _context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();
			var rotation = windowManager.DefaultDisplay.Rotation;
			int orientation = Orientations.Get((int)rotation);
			mediaRecorder.SetOrientationHint(90);
			mediaRecorder.SetMaxDuration(100000);
			mediaRecorder.Prepare();
			previewBuilder = CameraDevice.CreateCaptureRequest(CameraTemplate.Record);
			//var surfaces = new List<Surface>();
			//var previewSurface = new Surface(texture);
			//surfaces.Add(previewSurface);
			//previewBuilder.AddTarget(previewSurface);

			//var recorderSurface = mediaRecorder.Surface;
			//surfaces.Add(recorderSurface);
			//previewBuilder.AddTarget(recorderSurface);
			var surfaces = new List<Surface>();
			var previewSurface = new Surface(texture);
			surfaces.Add(previewSurface);
			previewBuilder.AddTarget(previewSurface);
			var recorderSurface = mediaRecorder.Surface;
			surfaces.Add(recorderSurface);
			previewBuilder.AddTarget(recorderSurface);
			var thread = new HandlerThread("CameraVideo");
			thread.Start();
			var backgroundHandler = new Handler(thread.Looper);

			CameraDevice.CreateCaptureSession(surfaces, new CameraCaptureStateListener
			{
				OnConfiguredAction = session =>
				{
					try
					{
						_previewSession = session;
						UpdatePreview();
						session.SetRepeatingRequest(previewBuilder.Build(), null, backgroundHandler);
					}
					catch (CameraAccessException ex)
					{
						Log.WriteLine(LogPriority.Info, "Capture Session error: ", ex.ToString());
					}
				}
			}, backgroundHandler);

			mediaRecorder.Start();
			System.Diagnostics.Debug.WriteLine("Start");
		}

		public void StopRecording()
		{
			//MediaRecorder recorder = new MediaRecorder();
			//mediaRecorder.Stop();
			CloseCamera();

			openCamera(_cameraTexture.Width, _cameraTexture.Height, cameraOption);
			//System.IO.File.Copy(file, targetPath, true);
			// The file is being written to and the file does exist, for some reason the file cannot be opened ant the media recorder cannot be stopped traditionally
			System.Diagnostics.Debug.WriteLine(file);
			Video?.Invoke(this, MediaSource.FromFile(file));
			Orient?.Invoke(this, cameraOption);

		}

		private void CloseCamera()
		{
			try
			{
				if (null != CameraDevice)
				{
					CameraDevice.Close();
					CameraDevice = null;
				}
				if (null != mediaRecorder)
				{
					mediaRecorder.Release();
					mediaRecorder = null;
				}
			}



			catch (InterruptedException e)
			{
				throw new RuntimeException("Interrupted while trying to lock camera closing.");
			}
		}


		public void openCamera(int width, int height,int camera)
		{

			CameraManager manager = (CameraManager)_context.GetSystemService(Context.CameraService);
			string cameraId = manager.GetCameraIdList()[camera];
			// If you put 1 it is the front camera if you put 0 it is the rear camera
			CameraCharacteristics characteristics = manager.GetCameraCharacteristics(cameraId);
			StreamConfigurationMap map = (StreamConfigurationMap)characteristics.Get(CameraCharacteristics.ScalerStreamConfigurationMap);
			//videoSize = ChooseVideoSize(map.GetOutputSizes(Class.FromType(typeof(MediaRecorder))));
			//previewSize = ChooseOptimalSize(map.GetOutputSizes(Class.FromType(typeof(MediaRecorder))), width, height, videoSize);
			int orientation = (int)Resources.Configuration.Orientation;
			if (orientation == (int)Android.Content.Res.Orientation.Landscape)
			ConfigureTransform(width, height);
			mediaRecorder = new MediaRecorder();
			manager.OpenCamera(cameraId, _mStateListener, null);

		}

		private Java.IO.File GetVideoFile(Context context)
		{
			string fileName = "video-" + DateTime.Now.ToString("yymmdd-hhmmss") + ".mp4"; //new filenamed based on date time
			Java.IO.File file = new Java.IO.File(context.GetExternalFilesDir(null), fileName);
			return file;
		}


		public void StartPreview()
		{
			if (CameraDevice == null || !_cameraTexture.IsAvailable || _previewSize == null) return;

			var texture = _cameraTexture.SurfaceTexture;



			texture.SetDefaultBufferSize(_previewSize.Width, _previewSize.Height);
			var surfaces = new List<Surface>();
			surfaces.Add(new Surface(texture));

			_previewBuilder = CameraDevice.CreateCaptureRequest(CameraTemplate.Preview);
			_previewBuilder.AddTarget(new Surface(texture));

			CameraDevice.CreateCaptureSession(surfaces,
				new CameraCaptureStateListener
				{
					OnConfigureFailedAction = session =>
					{
					},
					OnConfiguredAction = session =>
					{
						_previewSession = session;
						UpdatePreview();
					}
				},
				null);


		}

		private void ConfigureTransform(int viewWidth, int viewHeight)
		{
			if (_viewSurface == null || _previewSize == null || _context == null) return;

			var windowManager = _context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

			var rotation = windowManager.DefaultDisplay.Rotation;
			var matrix = new Matrix();
			var viewRect = new RectF(0, 0, viewWidth, viewHeight);
			var bufferRect = new RectF(0, 0, _previewSize.Width, _previewSize.Height);
			var centerX = viewRect.CenterX();
			var centerY = viewRect.CenterY();

			if (rotation == SurfaceOrientation.Rotation90 || rotation == SurfaceOrientation.Rotation270)
			{
				bufferRect.Offset(centerX - bufferRect.CenterX(), centerY - bufferRect.CenterY());
				matrix.SetRectToRect(viewRect, bufferRect, Matrix.ScaleToFit.Fill);

				matrix.PostRotate(90 * ((int)rotation - 2), centerX, centerY);
			}
			_cameraTexture.SetTransform(matrix);
		}

		public void UpdatePreview()
		{
			if (CameraDevice == null || _previewSession == null) return;

			_previewBuilder.Set(CaptureRequest.ControlMode, new Integer((int)ControlMode.Auto));
			var thread = new HandlerThread("CameraPreview");
			thread.Start();
			var backgroundHandler = new Handler(thread.Looper);

			_previewSession.SetRepeatingRequest(_previewBuilder.Build(), null, backgroundHandler);
		}
	}
}