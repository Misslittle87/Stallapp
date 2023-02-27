using Stallapp.ViewModel;

namespace Stallapp.View;

public partial class PersonDetailPage : ContentPage
{
	public PersonDetailPage(PersonDetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}