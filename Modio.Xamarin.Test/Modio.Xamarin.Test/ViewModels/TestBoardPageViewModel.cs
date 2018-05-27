using Modio.Core.Module;
using Modio.Xamarin.Test.Boards;
using Modio.Xamarin.ViewModels;
using Prism.Navigation;
using System.Collections.Generic;

namespace Modio.Xamarin.Test.ViewModels
{
    public class TestBoardPageViewModel : ViewModelBoard
    {
        public TestBoardPageViewModel(INavigationService navigationService, TestBoardService service)
            : base(navigationService, service)
        {
            Title = "TestBoard Service";
            Service.Modules = new List<UIModuleService>
            {
                new Module.ModioFormsModuleService(new BaseModuleMeta {
                    HeadTitle = "Transactions",
                    ModuleDesc="Display the transactions and read the qif file if no entry is stored" ,
                    ModuleImage = "Person_7.jpg",
                    ModuleMessage = ""
                })
            };
        }
    }

}
