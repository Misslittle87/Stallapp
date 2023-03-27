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
                foreach (UserInfoModel user in UserInfo)
                {
                    if (user.UserName == userName)
                    {
                        await LoginService.AddUser(userName, password);
                        UserInfo.Clear();
                        var userPassword = await LoginService.GetUser();
                        UserInfo.AddRange(userPassword);
                        await Shell.Current.DisplayAlert("Lycka", "Du är registrerad", "OK");
                    }
                    else
                    {
                        await Shell.Current.DisplayAlert("Fel", "Finns redan", "ok");
                    }
                }               

            }
        }
    }
}
