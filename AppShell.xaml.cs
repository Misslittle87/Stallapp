using Stallapp.View;

namespace Stallapp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        //nameof(PersonDetailPage) == "PersonDetailPage"
        Routing.RegisterRoute(nameof(PersonDetailPage), typeof(PersonDetailPage));
		Routing.RegisterRoute(nameof(HorseDetailPage), typeof(HorseDetailPage));
	}
}
