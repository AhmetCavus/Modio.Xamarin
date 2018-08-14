using Modio.Core.Model;
using System.Threading.Tasks;

namespace Modio.Xamarin.UI.Services.Location
{
    public class FakeLocationService : ILocationService
    {
        public async Task<GeoLocation> GetPositionAsync()
        {
            await Task.Delay(500);

            return GeoLocation.Parse("");
        }
    }
}