using System;
using Modio.Xamarin.UI.Services.Analytic;
using Modio.Xamarin.UI.Services.Authentication;
using Modio.Xamarin.UI.Services.Chart;
using Modio.Xamarin.UI.Services.Dialog;
using Modio.Xamarin.UI.Services.Location;
using Modio.Xamarin.UI.Services.Notification;
using Modio.Xamarin.UI.Services.OpenUri;
using Modio.Xamarin.UI.Services.Request;
using Modio.Xamarin.UI.Services.Settings;
using Modio.Xamarin.UI.Services.Suggestion;
using Modio.Xamarin.UI.Models;

namespace Modio.Xamarin.UI.ViewModels.Base
{
    public class Locator
    {
        //private IContainer _container;
        //private ContainerBuilder _containerBuilder;

        private static readonly Locator _instance = new Locator();

        public static Locator Instance
        {
            get
            {
                return _instance;
            }
        }

        public Locator()
        {
            //_containerBuilder = new ContainerBuilder();

            //_containerBuilder.RegisterType<AnalyticService>().As<IAnalyticService>();
            //_containerBuilder.RegisterType<DialogService>().As<IDialogService>();
            //_containerBuilder.RegisterType<NavigationService>().As<INavigationService>();
            //_containerBuilder.RegisterType<FakeChartService>().As<IChartService>();
            //_containerBuilder.RegisterType<AuthenticationService>().As<IAuthenticationService>();
            //_containerBuilder.RegisterType<LocationService>().As<ILocationService>();
            //_containerBuilder.RegisterType<OpenUriService>().As<IOpenUriService>();
            //_containerBuilder.RegisterType<RequestService>().As<IRequestService>();
            //_containerBuilder.RegisterType<DefaultBrowserCookiesService>().As<IBrowserCookiesService>();
            //_containerBuilder.RegisterType<GravatarUrlProvider>().As<IAvatarUrlProvider>();
            //_containerBuilder.RegisterType(typeof(SettingsService)).As(typeof(ISettingsService<RemoteSettings>));

            //if (AppSettings.UseFakes)
            //{
            //    _containerBuilder.RegisterType<FakeBookingService>().As<IBookingService>();
            //    _containerBuilder.RegisterType<FakeHotelService>().As<IHotelService>();
            //    _containerBuilder.RegisterType<FakeNotificationService>().As<INotificationService>();
            //    _containerBuilder.RegisterType<FakeSuggestionService>().As<ISuggestionService>();
            //}
            //else
            //{
            //    _containerBuilder.RegisterType<BookingService>().As<IBookingService>();
            //    _containerBuilder.RegisterType<HotelService>().As<IHotelService>();
            //    _containerBuilder.RegisterType<NotificationService>().As<INotificationService>();
            //    _containerBuilder.RegisterType<SuggestionService>().As<ISuggestionService>();
            //}

            //_containerBuilder.RegisterType<BookingCalendarViewModel>();
            //_containerBuilder.RegisterType<BookingHotelViewModel>();
            //_containerBuilder.RegisterType<BookingHotelsViewModel>();
            //_containerBuilder.RegisterType<BookingViewModel>();
            //_containerBuilder.RegisterType<CheckoutViewModel>();
            //_containerBuilder.RegisterType<HomeViewModel>();
            //_containerBuilder.RegisterType<LoginViewModel>();
            //_containerBuilder.RegisterType<MainViewModel>();
            //_containerBuilder.RegisterType<MenuViewModel>();
            //_containerBuilder.RegisterType<MyRoomViewModel>();
            //_containerBuilder.RegisterType<NotificationsViewModel>();
            //_containerBuilder.RegisterType<OpenDoorViewModel>();
            //_containerBuilder.RegisterType<SuggestionsViewModel>();

            //_containerBuilder.RegisterType(typeof(SettingsViewModel<RemoteSettings>));
            //_containerBuilder.RegisterType<ExtendedSplashViewModel>();
        }

        public T Resolve<T>()
        {
            //return _container.Resolve<T>();
            return default(T);
        }

        public object Resolve(Type type)
        {
            //return _container.Resolve(type);
            return null;
        }

        public void Register<TInterface, TImplementation>() where TImplementation : TInterface
        {
            //_containerBuilder.RegisterType<TImplementation>().As<TInterface>();
        }

        public void Register<T>() where T : class
        {
            //_containerBuilder.RegisterType<T>();
        }

        public void Build()
        {
            //_container = _containerBuilder.Build();
        }
    }
}