using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Modio.Xamarin.UI.Services.Suggestion
{
    public interface ISuggestionService
    {
        Task<ObservableCollection<Models.Suggestion>> GetSuggestionsAsync(double latitude, double longitude);
    }
}