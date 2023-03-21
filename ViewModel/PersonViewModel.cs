using Stallapp.Model;
using Stallapp.View;

// Här är viewmodelen för att lägga till en person. Det är meningen att enbart admin/stallägaren ska se detta,
// medans uder/inhyrd enbart ska kunna se vem som är med utan att redigera.

namespace Stallapp.ViewModel;

public partial class PersonViewModel : BaseViewModel
{
    [ObservableProperty]
    public ObservableRangeCollection<PersonModel> persons;

    public PersonViewModel()
    {    
        persons = new ObservableRangeCollection<PersonModel>();
    }
    [RelayCommand]
    async Task Add()
    {
        var firstName = await App.Current.MainPage.DisplayPromptAsync("Förnamn inhyrd", "Förnamn");
        var lastName = await App.Current.MainPage.DisplayPromptAsync("Efternamn inhyrd", "Efternamn");
        var email = await App.Current.MainPage.DisplayPromptAsync("Email inhyrd", "Email");
        var person = new PersonModel
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email
        };
        persons.Add(person);
        
    }
    [RelayCommand]
    void Remove(PersonModel pm)
    {
        if (persons.Contains(pm))
        {
            persons.Remove(pm);
        }
    }
    //async Task Add()
    //{

    //    var firstName = await App.Current.MainPage.DisplayPromptAsync("Förnamn inhyrd", "Förnamn");
    //    var lastName = await App.Current.MainPage.DisplayPromptAsync("Efternamn inhyrd", "Efternamn");
    //    var email = await App.Current.MainPage.DisplayPromptAsync("Email inhyrd", "Email");
    //    //await PersonService.AddPerson(firstName, lastName, email);
    //    //await Refresh();
    //}
    ////[RelayCommand]
    //async Task Remove(PersonModel person)
    //{
    //    await PersonService.RemovePerson(person.Id);
    //    await Refresh();
    //}
    //[RelayCommand]
    //async Task Refresh()
    //{  
    //    IsBusy = true;
    //    await Task.Delay(2000);
    //    Persons.Clear();
    //    var persons = await PersonService.GetPerson();
    //    Persons.AddRange(persons);
    //    IsBusy = false;
    //}
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
