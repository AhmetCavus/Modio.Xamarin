using Modio.Core.Board;
using Modio.Core.Container;
using Modio.Core.Module;
using Prism.Ioc;
using System;
using System.Linq;
using System.Reflection;

namespace Modio.Xamarin.Controller
{
    public class ModioFormsService : Core.App.UIAppService
    {

        Type[] _assemblyTypes;
        IContainerRegistry _containerRegistry;
        Prism.Navigation.INavigationService _navigationService;

        public ModioFormsService(IServiceContainer<UIBoardService> container, IContainerRegistry containerRegistry, Prism.Navigation.INavigationService navigationService) : base(container)
        {
            Init(containerRegistry, navigationService);
        }

        void Init(IContainerRegistry containerRegistry, Prism.Navigation.INavigationService navigationService)
        {
            _assemblyTypes = Assembly.GetExecutingAssembly().GetTypes();
            _containerRegistry = containerRegistry;
            _navigationService = navigationService;
        }

        Type ResolvePageType(Type uiService)
        {
            var toFind = uiService.Name.Replace("Service", "Page");
            Type pageType = _assemblyTypes.FirstOrDefault(type => type.Name == toFind && type.IsClass);
            return pageType;
        }

        protected override void OnActivateModule<SubModuleService>(UIModuleService module)
        {
        }

        protected override void OnAddBoard<TSubBoardService>(UIBoardService board)
        {
            var boardPageType = ResolvePageType(board.GetType());
            _containerRegistry.RegisterSingleton<TSubBoardService>();
            _containerRegistry.RegisterForNavigation(boardPageType, board.Id);
        }

        protected override void OnAddModule<TSubModuleService>(UIModuleService module)
        {
            var modulePageType = ResolvePageType(module.GetType());
            _containerRegistry.RegisterForNavigation(modulePageType, module.Id);
        }

        protected override void OnAddWorker<TSubWorkerModuleService>(WorkerModuleService worker)
        {
        }

        protected override void OnRemoveBoard<TSubBoardService>(UIBoardService board)
        {
        }

        protected override void OnRemoveModule<TSubModuleService>(UIModuleService module)
        {
        }

        protected override void OnRemoveWorker<TSubWorkerService>(WorkerModuleService worker)
        {
        }

        protected override void OnSelectBoard<TSubBoardService>(UIBoardService board)
        {
            _navigationService.NavigateAsync(board.Id);
        }
    }
}
