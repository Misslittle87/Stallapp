// Backend f�r koppla viewmodel till page s� man kan f� en navigering

namespace Stallapp.View;
public partial class PersonDetailPage : ContentPage
{
	public PersonDetailPage(PersonDetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}