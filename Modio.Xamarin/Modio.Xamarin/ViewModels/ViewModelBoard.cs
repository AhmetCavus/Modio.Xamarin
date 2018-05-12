using Modio.Core.Service;
using Prism.Mvvm;
using Prism.Navigation;

namespace Modio.Xamarin.ViewModels
{
    public class ViewModelBoard : ViewModelBase
    {
        Board.ModioFormsBoardService _service;
        public Board.ModioFormsBoardService Service
        {
            get { return _service; }
            set { SetProperty(ref _service, value); }
        }

        public ViewModelBoard(INavigationService navigationService, Board.ModioFormsBoardService service) : base(navigationService)
        {
            _service = service;
        }
    }
}
