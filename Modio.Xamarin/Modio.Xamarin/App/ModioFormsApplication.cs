using Modio.Core.App;
using Modio.Core.Board;
using Modio.Core.Container;
using Modio.Core.Module;
using Prism;
using Prism.Ioc;

namespace Modio.Xamarin.Controller
{
    public abstract class ModioFormsApplication : Prism.Unity.PrismApplication
    {

        #region Attributes

        #endregion

        #region Properties

        IAppService<UIBoardService, UIModuleService> _appService;


        #endregion

        #region Constructor

        public ModioFormsApplication(IPlatformInitializer initializer = null) : base(initializer) { }

        #endregion

        #region Public Methods

        #endregion

        #region Protected / Private Methods

        #endregion

        #region Abstract Methods

        protected abstract void OnInitializeBoards(IAppService<UIBoardService, UIModuleService> service);

        protected abstract override void OnInitialized();

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            _appService = new ModioFormsService(new ServiceDictionaryContainer<UIBoardService>(), containerRegistry, NavigationService);
            OnInitializeBoards(_appService);
            if (!_appService.IsInitialized) throw new System.Exception();
        }

        #endregion

    }
}
