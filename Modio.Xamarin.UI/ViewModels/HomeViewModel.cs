using Modio.Xamarin.UI.Models;
using Modio.Xamarin.UI.Services.Authentication;
using Modio.Xamarin.UI.Services.Booking;
using Modio.Xamarin.UI.Services.Chart;
using Modio.Xamarin.UI.Services.Notification;
using Modio.Xamarin.UI.ViewModels.Base;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Modio.Xamarin.UI.ViewModels
{
    public class HomeViewModel : ViewModelBase, IHandleViewAppearing, IHandleViewDisappearing
    {
        private bool _hasBooking;
        private Microcharts.Chart _temperatureChart;
        private Microcharts.Chart _greenChart;
        private ObservableCollection<Notification> _notifications;

        private readonly INotificationService _notificationService;
        private readonly IChartService _chartService;
        private readonly IBookingService _bookingService;
        private readonly IAuthenticationService _authenticationService;

        public HomeViewModel(
            INotificationService notificationService,
            IChartService chartService,
            IBookingService bookingService,
            IAuthenticationService authenticationService)
        {
            _notificationService = notificationService;
            _chartService = chartService;
            _bookingService = bookingService;
            _authenticationService = authenticationService;
        }

        public bool HasBooking
        {
            get { return _hasBooking; }
            set
            {
                _hasBooking = value;
                OnPropertyChanged();
            }
        }

        public Microcharts.Chart TemperatureChart
        {
            get { return _temperatureChart; }

            set
            {
                _temperatureChart = value;
                OnPropertyChanged();
            }
        }

        public Microcharts.Chart GreenChart
        {
            get { return _greenChart; }

            set
            {
                _greenChart = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Notification> Notifications
        {
            get { return _notifications; }

            set
            {
                _notifications = value;
                OnPropertyChanged();
            }
        }

        public ICommand NotificationsCommand => new AsyncCommand(OnNotificationsAsync);

        public ICommand SuggestionsCommand => new AsyncCommand(SuggestionsAsync);

        public override async Task InitializeAsync(object navigationData)
        {
            try
            {
                IsBusy = true;

                HasBooking = AppSettings.HasBooking;

                TemperatureChart = await _chartService.GetTemperatureChartAsync();
                GreenChart = await _chartService.GetGreenChartAsync();

                var authenticatedUser = _authenticationService.AuthenticatedUser;
                var notifications = await _notificationService.GetNotificationsAsync(3, authenticatedUser.Token);
                Notifications = new ObservableCollection<Models.Notification>(notifications);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"[Home] Error: {ex}");
                //await DialogService.ShowAlertAsync(Resources.ExceptionMessage, Resources.ExceptionTitle, Resources.DialogOk);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public Task OnViewAppearingAsync(VisualElement view)
        {
            MessagingCenter.Subscribe<Booking>(this, MessengerKeys.BookingRequested, OnBookingRequested);
            //MessagingCenter.Subscribe<CheckoutViewModel>(this, MessengerKeys.CheckoutRequested, OnCheckoutRequested);

            return Task.FromResult(true);
        }

        public Task OnViewDisappearingAsync(VisualElement view)
        {
            return Task.FromResult(true);
        }

        private Task OnNotificationsAsync()
        {
            return NavigationService.NavigateToAsync(typeof(NotificationsViewModel), Notifications);
        }

        private Task SuggestionsAsync()
        {
            return NavigationService.NavigateToAsync<SuggestionsViewModel>();
        }

        private void OnBookingRequested(Booking booking)
        {
            if (booking == null)
            {
                return;
            }

            HasBooking = true;
        }

        private void OnCheckoutRequested(object args)
        {
            HasBooking = false;
        }
    }
}