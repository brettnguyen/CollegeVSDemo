using Android.Content;
using Xamarin.Forms.Platform.Android;
using CollegeVS;
using CollegeVS.Droid;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRender))]
namespace CollegeVS.Droid
{
    public class CustomPickerRender : PickerRenderer
    {
        public CustomPickerRender(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Picker> e)
        {
            base.OnElementChanged(e);

            if (Control == null)

                return;

            Control.Background = null;
            //Or Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);

        }
    }
}