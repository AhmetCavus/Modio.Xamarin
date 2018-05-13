using System.Threading.Tasks;

namespace Modio.Xamarin.UI.Services.Chart
{
    public interface IChartService
    {
        Task<Microcharts.Chart> GetTemperatureChartAsync();
        Task<Microcharts.Chart> GetGreenChartAsync();
    }
}