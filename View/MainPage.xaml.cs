using Stallapp.ViewModel;

// H�r �r viewmodel kopplat till en page

namespace Stallapp.View;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}