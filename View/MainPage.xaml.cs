using Stallapp.ViewModel;

namespace Stallapp.View;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}