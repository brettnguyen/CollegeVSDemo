using System;
using Android.Hardware.Camera2;
using Android.Widget;

namespace CollegeVS.Droid.Pages
{
	public class PreviewCaptureStateCallback : CameraCaptureSession.StateCallback
	{
		CameraPageCS fragment;
		public PreviewCaptureStateCallback(CameraPageCS frag)
		{
			fragment = frag;
		}
		public override void OnConfigured(CameraCaptureSession session)
		{
			fragment.UpdatePreview();

		}

		public override void OnConfigureFailed(CameraCaptureSession session)
		{
		}
	}
}