//Denna sidan är till för att varje user/inhyrd ska kunna lägga till kontakter som tex hovslagare, veterinär och andra anhöriga,
// och att man ska kunna kompiera/ringa från appen. Denna ska även kopplas till en person, så vet du inte vem som är ägare till häste så
// ska du kunna se det genom appen och kunna ringa.

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
