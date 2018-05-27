using Modio.Xamarin.UI.Clients.UWP.Services.DismissKeyboard;
using Modio.Xamarin.UI.Services.DismissKeyboard;
using Windows.UI.ViewManagement;

[assembly: Xamarin.Forms.Dependency(typeof(DismissKeyboardService))]
namespace Modio.Xamarin.UI.Clients.UWP.Services.DismissKeyboard
{
    class DismissKeyboardService : IDismissKeyboardService
    {
        public void DismissKeyboard()
        {
            InputPane.GetForCurrentView().TryHide();
        }
    }
}