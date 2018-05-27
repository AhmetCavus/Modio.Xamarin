using Modio.Xamarin.UI.Services.Navigation;
using Modio.Xamarin.UI.ViewModels;
using Modio.Xamarin.UI.ViewModels.Base;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Modio.Xamarin.UI.Clients
{
    public partial class App : Application
    {
        static App()
        {
            BuildDependencies();
        }
        public App()
        {
            InitializeComponent();
    
            InitNavigation();
        }

        public static void BuildDependencies()
        {
            // Do you want to use fake services that DO NOT require real backend or internet connection?
            // Set to true the value to use fake services, false if you want to use Azure Services.
            AppSettings.UseFakes = true;

            Locator.Instance.Build();
        }

        private Task InitNavigation()
        {
            var navigationService = Locator.Instance.Resolve<INavigationService>();
            return navigationService.NavigateToAsync<ExtendedSplashViewModel>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
