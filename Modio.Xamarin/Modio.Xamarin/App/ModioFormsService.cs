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
            var toFind = uiService.Name.Replace("Service", "");
            Type pageType = _assemblyTypes.FirstOrDefault(type => type.Name == toFind && type.IsClass);
            return pageType;
        }

        protected override void OnActivateModule(UIModuleService module)
        {
        }

        protected override void OnAddBoard(UIBoardService board)
        {
            var boardPageType = ResolvePageType(board.GetType());
            _containerRegistry.RegisterForNavigation(boardPageType, board.Id);
        }

        protected override void OnAddModule(UIModuleService module)
        {
            var modulePageType = ResolvePageType(module.GetType());
            _containerRegistry.RegisterForNavigation(modulePageType, module.Id);
        }

        protected override void OnAddWorker(WorkerModuleService worker)
        {
        }

        protected override void OnRemoveBoard(UIBoardService board)
        {
        }

        protected override void OnRemoveModule(UIModuleService module)
        {
        }

        protected override void OnRemoveWorker(WorkerModuleService worker)
        {
        }

        protected override void OnSelectBoard(UIBoardService board)
        {
            _navigationService.NavigateAsync(board.Id);
        }
    }
}
