using System.Collections.Generic;

namespace Modio.Xamarin.UI.Services.Analytic
{
    public class DummyAnalyticService : IAnalyticService
    {
        public void TrackEvent(string name, Dictionary<string, string> properties = null)
        {
            // Do nothing
        }
    }
}
