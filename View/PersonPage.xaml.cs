using Stallapp.ViewModel;

// H�r kopplar man sin viewmodel till sin page.

namespace Stallapp.View;

public partial class PersonPage : ContentPage
{
	public PersonPage(PersonViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}