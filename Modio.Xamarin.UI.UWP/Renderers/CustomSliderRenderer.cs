using Modio.Xamarin.UI.UWP.Renderers;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Slider), typeof(CustomSliderRenderer))]
namespace Modio.Xamarin.UI.UWP.Renderers
{
    public class CustomSliderRenderer : SliderRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<global::Xamarin.Forms.Slider> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.IsThumbToolTipEnabled = false;
            }
        }
    }
}