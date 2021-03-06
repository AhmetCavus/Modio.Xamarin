﻿using Prism;
using Xamarin.Forms.Xaml;
using Modio.Core.App;
using Modio.Core.Board;
using Modio.Core.Module;
using Modio.Xamarin.Test.Boards;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Modio.Xamarin.Test
{
    public partial class App : Controller.ModioFormsApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override void OnInitializedApp()
        {
            InitializeComponent();
            AppService.SelectBoard<TestBoardService>();
        }

        protected override void OnInitializeBoards(IAppService<UIBoardService, UIModuleService> service)
        {
            service.AddBoard<TestBoardService>();
        }
    }
}
