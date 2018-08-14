using Modio.Xamarin.UI.Extensions;
using Modio.Xamarin.UI.Services.Request;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

namespace Modio.Xamarin.UI.Services.Notification
{
    public class NotificationService : INotificationService
    {
        private readonly IRequestService _requestService;

        public NotificationService(IRequestService requestService)
        {
            _requestService = requestService;
        }

        public Task<IEnumerable<Models.Notification>> GetNotificationsAsync(int seq, string token)
        {
            UriBuilder builder = new UriBuilder("");
            builder.AppendToPath("notifications");
            builder.Query = $"seq={seq.ToString(CultureInfo.InvariantCulture)}";

            string uri = builder.ToString();

            return _requestService.GetAsync<IEnumerable<Models.Notification>>(uri, token);
        }

        public Task DeleteNotificationAsync(Models.Notification notification)
        {
            return Task.FromResult(false);
        }
    }
}