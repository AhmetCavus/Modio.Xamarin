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
                    HeadTitle = " 1 day ago   - FaceBook ",
                    ModuleDesc="Samsung SM-T385S with Android 7.0 gets Wifi certified - GSM Arena News " ,
                    ModuleImage = "Person_7.jpg",
                    ModuleMessage = "Facebook is a social networking service launched on February 4........small sample based on your scenario. Please review my project and let us know  ",
                }),
                new Module.ModioFormsModuleService(new BaseModuleMeta {
                    HeadTitle = " 9 hrs ago   - The Indipendendent",
                    ModuleDesc="Game of THrones season 7 : Fans think Catelyn's Stark's Ghost was" ,
                    ModuleMessage = "The Independent is a British online newspaper.[2]............small sample based on your scenario. Please review my project and let us know",
                    ModuleImage = "Person_2.png"
                }),
                new Module.ModioFormsModuleService(new BaseModuleMeta{
                    HeadTitle       = " 10 hrs ago  - Power BI Microsoft",
                    ModuleDesc         ="Announcing the Power BI Solution Tempelate for Azure Activity Log" ,
                    ModuleMessage     = "Microsoft Corporation (/ˈmaɪkrəˌsɒft/,[2][3] abbreviated.............small sample based on your scenario. Please review my project and let us know",
                    ModuleImage     = "Person_3.png"
                }),
                new Module.ModioFormsModuleService(new BaseModuleMeta{
                    HeadTitle = " 13 hrs ago  - MacRumors ",
                    ModuleDesc    = "MacRumors.com is a website that aggregates Mac and Apple",
                    ModuleMessage="Google Rolls Out Anti-Polishing Feature to Gmail on Ios",
                    ModuleImage = "Person_4.jpg"
                }),
                new Module.ModioFormsModuleService(new BaseModuleMeta {
                    HeadTitle = " 16 hrs ago - MacRumors",
                    ModuleMessage = "MacRumors.com is a website that aggregates Mac and Apple related news................small sample based on your scenario. Please review my project and let us know,",
                    ModuleDesc="Set it and forget it : 5 Things you should always automate on your phone" ,
                    ModuleImage = "Person_1.png"
                })
            };
        }
    }

}
