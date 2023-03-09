using Stallapp.Model;
using System.Collections.ObjectModel;

namespace Stallapp.ViewModel
{
    public partial class ContactViewModel : BaseViewModel
    {
        public ContactViewModel()
        {
            Contacts = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> contacts;

        [ObservableProperty]
        public string text;

        [RelayCommand]
        void Add()
        {
            if(string.IsNullOrWhiteSpace(Text))
            {
                return;
            }
            Contacts.Add(Text);
            Text = string.Empty;
        }
    }
}
