namespace Stallapp.View;

public partial class CalendarPage : ContentPage
{
	public CalendarPage(CalendarViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}