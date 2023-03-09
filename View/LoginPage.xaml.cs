

namespace Stallapp.View;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();		
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(RegistrationPage)}");
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }
}