using System.Threading.Tasks;

namespace Modio.Xamarin.UI.Services.Authentication
{
    public interface IBrowserCookiesService
    {
        Task ClearCookiesAsync();
    }
}
