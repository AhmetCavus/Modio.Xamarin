using System.Threading.Tasks;
using Modio.Xamarin.UI.ViewModels.Base;

namespace Modio.Xamarin.UI.ViewModels
{
    public class ExtendedSplashViewModel : ViewModelBase
    {
        public override async Task InitializeAsync(object navigationData)
        {
            IsBusy = true;

            await NavigationService.InitializeAsync();

            IsBusy = false;
        }
    }
}
