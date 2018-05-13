using System.Threading.Tasks;
using Modio.Xamarin.UI.Models;

namespace Modio.Xamarin.UI.Services.Location
{
    public class FakeLocationService : ILocationService
    {
        public async Task<GeoLocation> GetPositionAsync()
        {
            await Task.Delay(500);

            return GeoLocation.Parse(AppSettings.DefaultFallbackMapsLocation);
        }
    }
}