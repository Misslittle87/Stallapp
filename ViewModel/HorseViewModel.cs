using Stallapp.Model;
using Stallapp.View;
using System.Collections.ObjectModel;

namespace Stallapp.ViewModel
{
    public partial class HorseViewModel : BaseViewModel
    {
        public ObservableCollection<HorseModel> Horse { get; } = new ObservableCollection<HorseModel>();
        public HorseViewModel()
        {
            Title = "Häst";
        }
        [RelayCommand]
        async Task GoToDetailAsync(HorseModel horseModel)
        {
            if (horseModel == null)
            {
                return;
            }
            await Shell.Current.GoToAsync($"{nameof(HorseDetailPage)}", true,
                new Dictionary<string, object> 
                {
                    {"HorseModel", horseModel} 
                });
        }
    }
}
