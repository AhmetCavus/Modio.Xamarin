using Modio.Core.Board;
using Modio.Core.Module;

namespace Modio.Xamarin.Board
{
    public class ModioFormsBoardService : UIBoardService
    {
        public Prism.Navigation.INavigationService NavigationService { get; set; }

        public ModioFormsBoardService(){}

        protected override void OnActivateModule(UIModuleService module)
        {
            NavigationService?.NavigateAsync(module.Id);
        }

        protected override void OnAddModule(UIModuleService module)
        {
            throw new System.NotImplementedException();
        }

        protected override void OnRemoveModule(UIModuleService module)
        {
            throw new System.NotImplementedException();
        }
    }
}
