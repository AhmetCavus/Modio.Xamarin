using Modio.Core.Model;
using System.Threading.Tasks;

namespace Modio.Xamarin.UI.Services.Location
{
    public interface ILocationService
    {
        Task<GeoLocation> GetPositionAsync();
    }
}