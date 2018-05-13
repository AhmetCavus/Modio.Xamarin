using Rg.Plugins.Popup.Pages;

namespace Modio.Xamarin.UI.Views
{
    public partial class OpenDoorView : PopupPage
    {
		public OpenDoorView ()
		{
			InitializeComponent ();
        }

        protected override bool OnBackgroundClicked()
        {
            return false;
        }
    }
}