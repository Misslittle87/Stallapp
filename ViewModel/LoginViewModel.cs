using Stallapp.View;

namespace Stallapp.ViewModel
{
    public partial class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        {
        }
        [ObservableProperty]
        private string userNameEmail;
        [ObservableProperty]
        private string password;

        [RelayCommand]
        public async void Login()
        {

        }
    }
}
