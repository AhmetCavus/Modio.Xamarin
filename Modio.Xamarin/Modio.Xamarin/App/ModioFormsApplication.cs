using Modio.Core.App;
using Modio.Core.Board;
using Modio.Core.Module;
using Modio.Xamarin.Container;
using Prism;
using Prism.Ioc;
using Xamarin.Forms;

namespace Modio.Xamarin.Controller
{
    public abstract class ModioFormsApplication : Prism.Unity.PrismApplication
    {

        #region Attributes

        #endregion

        #region Properties

        IAppService<UIBoardService, UIModuleService> _appService;
        public IAppService<UIBoardService, UIModuleService> AppService => _appService;


        #endregion

        #region Constructor

        public ModioFormsApplication(IPlatformInitializer initializer = null) : base(initializer) { }

        #endregion

        #region Public Methods

        #endregion

        #region Protected / Private Methods

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            _appService = new ModioFormsService(new ModioFormsContainer<UIBoardService>(NavigationService), containerRegistry);
            OnInitializeBoards(_appService);
            if (!_appService.IsInitialized) throw new System.Exception();
        }

        #endregion

        #region Event Methods

        protected override void OnInitialized()
        {
            (_appService as ModioFormsService).NavigationService = NavigationService;
            OnInitializedApp();
        }

        #endregion

        #region Abstract Methods

        protected abstract void OnInitializeBoards(IAppService<UIBoardService, UIModuleService> service);

        protected abstract void OnInitializedApp();

        #endregion

    }
}
