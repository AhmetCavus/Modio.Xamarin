using Modio.Xamarin.UI.Helpers;
using Xamarin.Forms;

namespace Modio.Xamarin.UI.Views
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            StatusBarHelper.Instance.MakeTranslucentStatusBar(true);
        }
    }
}