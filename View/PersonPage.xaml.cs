using Stallapp.ViewModel;

namespace Stallapp.View;

public partial class PersonPage : ContentPage
{
	public PersonPage(PersonViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}