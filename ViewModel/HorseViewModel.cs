using Stallapp.Model;
using Stallapp.View;
using System.Collections.ObjectModel;

// Här kan user/inhyrd lägga till sin häst.

namespace Stallapp.ViewModel
{
    public partial class HorseViewModel : BaseViewModel
    {
        [ObservableProperty]
        public ObservableRangeCollection<HorseModel> horses;
        public HorseViewModel()
        {
            horses = new ObservableRangeCollection<HorseModel>();
        }
        [RelayCommand]
        async Task Add()
        {
            var name = await App.Current.MainPage.DisplayPromptAsync("Hästens namn", "namn");
            var age = await App.Current.MainPage.DisplayPromptAsync("Hästens ålder", "ålder");
            var breed = await App.Current.MainPage.DisplayPromptAsync("Hästens ras", "Ras");
            var horse = new HorseModel 
            {
                Name = name,
                Age = age,
                Breed = breed
            };
            horses.Add(horse);
        }
        [RelayCommand]
        void Remove(HorseModel hm) 
        {
            if (horses.Contains(hm))
            {
                horses.Remove(hm);
            }
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
