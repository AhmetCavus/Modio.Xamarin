using Modio.Core.App;
using Modio.Core.Board;
using Modio.Core.Module;
using Modio.Xamarin.Views;
using Prism.Ioc;
using System;

namespace Modio.Xamarin.Container
{
    public class ModioFormsInitializer : IModioFormsInitializer
    {

        IAppService<UIBoardService, UIModuleService> _appService;
        IContainerRegistry _containerRegistry;

        public ModioFormsInitializer(IAppService<UIBoardService, UIModuleService> appService, IContainerRegistry containerRegistry)
        {
            _appService = appService;
            _containerRegistry = containerRegistry;
        }

        public void RegisterBoard<TBoardPage>() where TBoardPage : BoardPage
        {

        }

        public void RegisterModule<TBoardPage, TModulePage>()
            where TBoardPage : BoardPage
            where TModulePage : ModulePage
        {
            _containerRegistry.RegisterForNavigation<TBoardPage>();
            _containerRegistry.RegisterForNavigation<TModulePage>();
        }
    }
}
