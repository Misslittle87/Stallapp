//Denna sidan är till för att varje user/inhyrd ska kunna lägga till kontakter som tex hovslagare, veterinär och andra anhöriga,
// och att man ska kunna kompiera/ringa från appen.

namespace Stallapp.ViewModel
{
    [QueryProperty(nameof(PersonModel), nameof(PersonModel))]
    public partial class PersonDetailViewModel : BaseViewModel
    {
        public PersonDetailViewModel() 
        {

        }

        [ObservableProperty]
        PersonModel person;

        [RelayCommand]
        async Task GoBackAsync()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
