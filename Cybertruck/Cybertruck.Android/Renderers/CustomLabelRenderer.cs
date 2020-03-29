using Android.Content;
using Cybertruck.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

//[assembly: ExportRenderer(typeof(Label), typeof(CustomLabelRenderer))]
namespace Cybertruck.Droid.Renderers
{
    public class CustomLabelRenderer : LabelRenderer
    {
        public CustomLabelRenderer(Context context) : base(context)
        {
            AutoPackage = false;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement == null) return;
            Control.SetTextSize(Android.Util.ComplexUnitType.Dip, (float)e.NewElement.FontSize);
        }
    }
}