using Modio.Xamarin.UI.Helpers;
using Xamarin.Forms;

namespace Modio.Xamarin.UI.Views
{
    public partial class BookingHotelsView : ContentPage
	{
		public BookingHotelsView ()
        {
            if (Device.RuntimePlatform != Device.iOS)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }

            NavigationPage.SetBackButtonTitle(this, string.Empty);

            InitializeComponent ();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            StatusBarHelper.Instance.MakeTranslucentStatusBar(false);
        }
    }
}