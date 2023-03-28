namespace Stallapp.ViewModel
{
    public partial class LoginViewModel : BaseViewModel
    {
        public ObservableRangeCollection<UserInfoModel> UserInfo { get; set; }
        public LoginViewModel()
        {
            UserInfo = new ObservableRangeCollection<UserInfoModel>();
        }
        [ObservableProperty]
        string userName;
        [ObservableProperty]
        string password;

        [RelayCommand]
        async Task Login()
        {
            if (!string.IsNullOrEmpty(userName) || (!string.IsNullOrEmpty(password)))
            {
                var user = await LoginService.GetUser(userName, password);
            }
            else
            {
                await Shell.Current.DisplayAlert("Fel", "Användarnamnet eller lösenordet är fel", "OK");
            }            
        }
    }

}
