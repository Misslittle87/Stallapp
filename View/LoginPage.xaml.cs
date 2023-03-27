// Detta �r routen som appen tar n�r man klickar p� logga in och logga ut.


namespace Stallapp.View;
public partial class LoginPage : ContentPage
{
    public LoginPage(LoginViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;       
    }
    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(RegistrationPage)}");
    }
}