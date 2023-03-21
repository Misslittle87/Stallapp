using Stallapp.Model;
using System.Collections.ObjectModel;

namespace Stallapp.ViewModel
{
    public partial class ContactViewModel : BaseViewModel
    {
        
        public ObservableCollection<string> Contacts { get; set; }
        public ContactViewModel()
        {
            Contacts = new ObservableCollection<string>();
        }
        [ObservableProperty]
        public string text;

        [RelayCommand]
        void Add()
        {
            if(string.IsNullOrWhiteSpace(text))
            {
                return;
            }
            Contacts.Add(text);
            text = string.Empty;
        }
    }
}
