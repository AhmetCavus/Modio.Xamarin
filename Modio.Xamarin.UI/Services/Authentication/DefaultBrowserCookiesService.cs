using System.Threading.Tasks;

namespace Modio.Xamarin.UI.Services.Authentication
{
    public class DefaultBrowserCookiesService : IBrowserCookiesService
    {
        public Task ClearCookiesAsync()
        {
            return Task.FromResult(true);
        }
    }
}
