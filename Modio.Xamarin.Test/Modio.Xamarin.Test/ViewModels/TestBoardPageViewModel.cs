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
                    HeadLines="Samsung SM-T385S with Android 7.0 gets Wifi certified - GSM Arena News " ,
                    ProfileImage = "Person_7.jpg",
                    HeadLinesDesc = "Facebook is a social networking service launched on February 4........small sample based on your scenario. Please review my project and let us know  ",
                }),
                new Module.ModioFormsModuleService(new BaseModuleMeta {
                    HeadTitle = " 9 hrs ago   - The Indipendendent",
                    HeadLines="Game of THrones season 7 : Fans think Catelyn's Stark's Ghost was" ,
                    HeadLinesDesc = "The Independent is a British online newspaper.[2]............small sample based on your scenario. Please review my project and let us know",
                    ProfileImage = "Person_2.png"
                }),
                new Module.ModioFormsModuleService(new BaseModuleMeta{
                    HeadTitle       = " 10 hrs ago  - Power BI Microsoft",
                    HeadLines         ="Announcing the Power BI Solution Tempelate for Azure Activity Log" ,
                    HeadLinesDesc     = "Microsoft Corporation (/ˈmaɪkrəˌsɒft/,[2][3] abbreviated.............small sample based on your scenario. Please review my project and let us know",
                    ProfileImage     = "Person_3.png"
                }),
                new Module.ModioFormsModuleService(new BaseModuleMeta{
                    HeadTitle = " 13 hrs ago  - MacRumors ",
                    HeadLines    = "MacRumors.com is a website that aggregates Mac and Apple",
                    HeadLinesDesc="Google Rolls Out Anti-Polishing Feature to Gmail on Ios",
                    ProfileImage = "Person_4.jpg"
                }),
                new Module.ModioFormsModuleService(new BaseModuleMeta {
                    HeadTitle = " 16 hrs ago - MacRumors",
                    HeadLinesDesc = "MacRumors.com is a website that aggregates Mac and Apple related news................small sample based on your scenario. Please review my project and let us know,",
                    HeadLines="Set it and forget it : 5 Things you should always automate on your phone" ,
                    ProfileImage = "Person_1.png"
                })
            };
        }
    }

}
