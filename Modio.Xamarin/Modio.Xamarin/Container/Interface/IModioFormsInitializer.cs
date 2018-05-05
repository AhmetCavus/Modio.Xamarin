using Modio.Xamarin.Views;

namespace Modio.Xamarin.Container
{
    public interface IModioFormsInitializer
    {
        void RegisterBoard<TBoardPage>() where TBoardPage : BoardPage;
        void RegisterModule<TBoardPage, TModulePage>() where TBoardPage : BoardPage where TModulePage : ModulePage;
    }
}
