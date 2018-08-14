using System.Collections.Generic;

namespace Modio.Xamarin.UI.Services.Analytic
{
    public interface IAnalyticService
    {
        void TrackEvent(string name, Dictionary<string, string> properties = null);
    }
}