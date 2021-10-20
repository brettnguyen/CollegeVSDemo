using Android.Content;
using Xamarin.Forms.Platform.Android;
using CollegeVS;
using CollegeVS.Droid;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(CustomSearchBar), typeof(CustomSearchBarRender))]
namespace CollegeVS.Droid
{
    public class CustomSearchBarRender : SearchBarRenderer
    {
        public CustomSearchBarRender(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var plateId = Resources.GetIdentifier("android:id/search_plate", null, null);
                var plate = Control.FindViewById(plateId);
                plate.SetBackgroundColor(Android.Graphics.Color.Transparent);
            }
        }
    }
}