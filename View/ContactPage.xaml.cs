namespace Stallapp.View;

public partial class ContactPage : ContentPage
{
	public ContactPage(ContactViewModel vm)
	{
		InitializeComponent();
	    BindingContext = vm;
	}
}