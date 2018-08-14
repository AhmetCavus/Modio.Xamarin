using Modio.Xamarin.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Modio.Xamarin.Test.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TestBoardPage : BoardPage
	{
		public TestBoardPage()
		{
			InitializeComponent ();
		}

        protected override TemplatedView OnCreateModuleView()
        {
            return new ModuleButton();
        }
    }
}