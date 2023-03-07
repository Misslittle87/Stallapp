using Stallapp.Model;

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
