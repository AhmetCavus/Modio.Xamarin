using Modio.Core.Container;
using Modio.Core.Service;
using System;
using System.Collections.Generic;
using Unity;
using Xamarin.Forms.Internals;

namespace Modio.Xamarin.Container
{
    public class ModioFormsContainer<TService> : BaseServiceContainer<TService> where TService : class, IService
    {
        UnityContainer _container;
        Dictionary<string, TService> _resolvedServices = new Dictionary<string, TService>();

        public ModioFormsContainer(Prism.Navigation.INavigationService navigationServiceInstance)
        {
            _container = new UnityContainer();
            //_container.RegisterInstance(navigationServiceInstance);
        }

        public override void Add<TSubService>()
        {
            _container.RegisterSingleton<TSubService>();
        }

        public override bool Contains<TSubService>()
        {
            return _resolvedServices.ContainsKey(typeof(TSubService).FullName);
        }

        public override void Dispose()
        {
            _container.Dispose();
            _container = null;
            _resolvedServices.Clear();
            _resolvedServices = null;
        }

        public override TService Get(Type serviceType)
        {
            if (!_resolvedServices.ContainsKey(serviceType.FullName))
            {
                var service = _container.Resolve(serviceType) as TService;
                _resolvedServices[service.GetType().FullName] = service;
            }
            return _resolvedServices[serviceType.FullName];
        }

        public override TSubService Get<TSubService>()
        {
            if (!_resolvedServices.ContainsKey(typeof(TSubService).FullName))
            {
                var service = _container.Resolve<TSubService>();
                _resolvedServices[service.GetType().FullName] = service;
            }
            return _resolvedServices[typeof(TSubService).FullName] as TSubService;
        }

        public override TSubService Remove<TSubService>()
        {
            string serviceName = typeof(TSubService).FullName;
            TSubService service = default(TSubService);
            if (_resolvedServices.ContainsKey(serviceName))
            {
                service = _resolvedServices[serviceName] as TSubService;
                _resolvedServices.Remove(serviceName);
            }
            return service;
        }

        public override IReadOnlyList<TService> ToList()
        {
            List<TService> services = new List<TService>();
            _resolvedServices.Values.ForEach(entry => services.Add(entry));
            return services;
        }
    }
}
