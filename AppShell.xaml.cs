using Stallapp.View;

// Här registreras routes som inte har en tab eller en meny, så skriver jag routen sidan ska ta.

namespace Stallapp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        //nameof(PersonDetailPage) == "PersonDetailPage"
        Routing.RegisterRoute(nameof(PersonDetailPage), typeof(PersonDetailPage));
		Routing.RegisterRoute(nameof(HorseDetailPage), typeof(HorseDetailPage));
		Routing.RegisterRoute(nameof(RegistrationPage), typeof(RegistrationPage));
	}
}
