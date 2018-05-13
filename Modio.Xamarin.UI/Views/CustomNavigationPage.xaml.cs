using Modio.Xamarin.UI.Utils;
using Xamarin.Forms;

namespace Modio.Xamarin.UI.Views
{
    public partial class CustomNavigationPage : NavigationPage
    {
        public CustomNavigationPage() : base()
        {
            InitializeComponent();
        }

        public CustomNavigationPage(Page root) : base(root)
        {
            InitializeComponent();
        }

        internal void ApplyNavigationTextColor(Page targetPage)
        {
            var color = NavigationBarAttachedProperty.GetTextColor(targetPage);
            BarTextColor = color == Color.Default
                ? Color.White
                : color;
        }
    }
}