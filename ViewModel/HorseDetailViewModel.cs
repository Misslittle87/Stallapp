using Stallapp.Model;

namespace Stallapp.ViewModel
{
    [QueryProperty(nameof(HorseModel), nameof(HorseModel))]
    public partial class HorseDetailViewModel : BaseViewModel
    {
        public HorseDetailViewModel()
        {
        }

        [ObservableProperty]
        HorseModel horse;

        [RelayCommand]
        async Task GoBackAsync()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
