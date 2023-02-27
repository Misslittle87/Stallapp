using Stallapp.ViewModel;

namespace Stallapp.View;

public partial class HorsePage : ContentPage
{
	public HorsePage(HorseViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}