using Modio.Xamarin.UI.Helpers;
using Xamarin.Forms;

namespace Modio.Xamarin.UI.Views
{
    public partial class SuggestionsView : ContentPage
    {
        public SuggestionsView()
        {
            if (Device.RuntimePlatform != Device.iOS)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }

            NavigationPage.SetBackButtonTitle(this, string.Empty);

            InitializeComponent();

            MapHelper.CenterMapInDefaultLocation(this.Map);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            StatusBarHelper.Instance.MakeTranslucentStatusBar(false);
        }
    }
}