using Stallapp.ViewModel;

namespace Stallapp.View;

public partial class CalendarPage : ContentPage
{
	public CalendarPage()
	{
		InitializeComponent();
		BindingContext = new CalendarViewModel();
	}
}