using Android.Content;
using Xamarin.Forms.Platform.Android;
using CollegeVS;
using CollegeVS.Droid;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(CustomEdit), typeof(CustomEditorRenderer))]
namespace CollegeVS.Droid
{
    public class CustomEditorRenderer : EditorRenderer
    {
        public CustomEditorRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Editor> e)
        {
            base.OnElementChanged(e);

            if (Control == null)

                return;

            Control.Background = null;
            //Or Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);

        }
    }
}