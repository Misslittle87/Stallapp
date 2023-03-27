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
            if (userName == UserName)
            {
                
            }
            //if (string.IsNullOrEmpty(userName) && string.IsNullOrWhiteSpace(Password))
            //{
            //    foreach (UserInfoModel user in UserInfo)
            //    {
            //        if (user.UserName == userName && user.Password == password)
            //        {
            //            await Shell.Current.DisplayAlert("Lycka", "Du är inloggad", "OK");
            //        }
            //        else
            //        {
            //            await Shell.Current.DisplayAlert("Något gick fel!", "Användarnamnet eller lösenordet är fel", "ok");
            //        }
            //    }
            //}
            //else
            //{
            //    await Shell.Current.DisplayAlert("Något gick fel!", "Du måste fylla i användarnamn och lösenord", "OK");
            //}
            //if (!string.IsNullOrWhiteSpace(userName) && !string.IsNullOrWhiteSpace(Password))
            //{
            //    foreach (var users in UserInfo)
            //    {
            //        await Shell.Current.DisplayAlert("Hej", "foreach", "ok");
            //        if (userName == users.UserName && password == users.Password)
            //        {
            //            await Shell.Current.DisplayAlert("Hej", "if", "ok");
            //            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            //        }
            //    }
            //    //var user = await LoginService.GetUser();
            //    //UserInfo.AddRange(user);
            //    //if (Preferences.ContainsKey(nameof(LoginService)))
            //    //{
            //    //    Preferences.Remove(nameof(LoginService));                    
            //    //}
            //    //await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            //}
            //else
            //{
            //    await Shell.Current.DisplayAlert("Något gick fel!", "Du måste fylla i användarnamn och lösenord", "OK");
            //}
            //foreach (var users in UserInfo)a
            //{
            //    await Shell.Current.DisplayAlert("Hej","foreach","ok");
            //    if (userName == users.UserName && password == users.Password)
            //    {
            //        await Shell.Current.DisplayAlert("Hej", "if", "ok");
            //        //await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            //    }
            //}
            //var user = await LoginService.GetUser();
            //UserInfo.AddRange(user);
            //if (userName == UserName && password == Password)
            //{
            //    await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            //}
            //else if (userName == null || password == null)
            //{
            //    await Shell.Current.DisplayAlert("Något gick fel!", "Du måste fylla i användarnamn och lösenord", "OK");
            //}
            //await Shell.Current.DisplayAlert("Något blev fel!", "Användarnamnet eller lösenordet är fel", "OK");
        }
                
        
            //await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }

}
