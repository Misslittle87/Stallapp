using Stallapp.Model;
using Stallapp.Services;
using Stallapp.View;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Stallapp.ViewModel;

public partial class PersonViewModel : BaseViewModel
{
    public ObservableRangeCollection<PersonModel> Persons { get; set; }
    public PersonViewModel()
    {    
        Persons = new ObservableRangeCollection<PersonModel>();
    }
    [RelayCommand]
    async Task Add()
    {
        var firstName = await App.Current.MainPage.DisplayPromptAsync("Förnamn", "Förnamn1");
        var lastName = await App.Current.MainPage.DisplayPromptAsync("Efternamn", "Efternamn1");
        var email = await App.Current.MainPage.DisplayPromptAsync("Email", "Email1");
        await PersonService.AddPerson(firstName, lastName, email);
        await Refresh();
    }
    [RelayCommand]
    async Task Remove(PersonModel person)
    {
        await PersonService.RemovePerson(person.Id);
        await Refresh();
    }
    [RelayCommand]
    async Task Refresh()
    {  
        await Task.Delay(2000);
        Persons.Clear();
        var persons = await PersonService.GetPerson();
        Persons.AddRange(persons);
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
