using Modio.Core.Board;
using Modio.Core.Container;
using Modio.Core.Module;
using Modio.Xamarin.Views;
using Prism.Ioc;
using System;
using System.Linq;
using System.Reflection;

namespace Modio.Xamarin.Controller
{
    public class ModioFormsService : Core.App.UIAppService
    {

        IContainerRegistry _containerRegistry;
        Prism.Navigation.INavigationService _navigationService;
        public Prism.Navigation.INavigationService NavigationService { set => _navigationService = value; }

        public ModioFormsService(IServiceContainer<UIBoardService> container, IContainerRegistry containerRegistry) : base(container)
        {
            Init(containerRegistry);
        }

        void Init(IContainerRegistry containerRegistry)
        {
            _containerRegistry = containerRegistry;
        }

        Type ResolvePageType(Type uiService, Type superPageType)
        {
            var toFind = uiService.Name.Replace("Service", "Page");
            Assembly assembly = Assembly.GetAssembly(uiService);
            Type[] types = assembly.GetTypes();
            Type pageType = types.FirstOrDefault(type => type.Name == toFind && type.IsSubclassOf(superPageType));
            return pageType;
        }

        protected override void OnActivateModule<SubModuleService>(UIModuleService module)
        {
        }

        protected override void OnAddBoard<TSubBoardService>(UIBoardService board)
        {
            var boardPageType = ResolvePageType(board.GetType(), typeof(BoardPage));
            if (boardPageType == null) throw new Exception($"No page found for the service {board.Id}");
            _containerRegistry.RegisterSingleton<TSubBoardService>();
            _containerRegistry.RegisterForNavigation(boardPageType, board.Id);
        }

        protected override void OnAddModule<TSubModuleService>(UIModuleService module)
        {
            var modulePageType = ResolvePageType(module.GetType(), typeof(ModulePage));
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
