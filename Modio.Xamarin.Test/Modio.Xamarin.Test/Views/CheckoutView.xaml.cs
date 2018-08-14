using Rg.Plugins.Popup.Pages;

namespace Modio.Xamarin.UI.Views
{
	public partial class CheckoutView : PopupPage
	{
		public CheckoutView ()
		{
			InitializeComponent ();
		}

		protected override bool OnBackgroundClicked()
		{
			return false;
		}
	}
}