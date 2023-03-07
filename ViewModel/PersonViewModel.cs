using Stallapp.Model;
using Stallapp.View;
using System.Collections.ObjectModel;

namespace Stallapp.ViewModel
{
    public partial class PersonViewModel : BaseViewModel
    {
        public ObservableCollection<PersonModel> Persons { get; } = new ObservableCollection<PersonModel>();
        public PersonViewModel()
        {
            Title = "Person";
        }
        [RelayCommand]
        async Task GoToDetailAsync(PersonModel personModel)
        {
            if (personModel == null) 
            {
                return;
            }
            await Shell.Current.GoToAsync($"{nameof(PersonDetailPage)}", true,
                new Dictionary<string, object>
                {
                    {"PersonModel", personModel}
                });
        }
        
    }
}
