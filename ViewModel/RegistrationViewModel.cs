namespace Stallapp.ViewModel
{
    public partial class RegistrationViewModel : BaseViewModel
    {       
        public ObservableRangeCollection<UserInfoModel> UserInfo { get; set; } = new ObservableRangeCollection<UserInfoModel>();
        public RegistrationViewModel()
        {
            //UserInfo = new ObservableRangeCollection<UserInfoModel>();
        }

        [ObservableProperty]
        public string userName;
        [ObservableProperty]
        string password;

        [RelayCommand]
        async Task Add()
        {
            if(string.IsNullOrWhiteSpace(userName) && string.IsNullOrWhiteSpace(password))
            {
                await Shell.Current.DisplayAlert("Något gick fel!", "Du måste fylla i användarnamn och lösenord", "OK");
                return;
            }
            else
            {                 
                await LoginService.AddUser(userName, password);                
            }
        }
    }
}
