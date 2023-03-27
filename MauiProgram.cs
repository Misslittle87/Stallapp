using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Stallapp.View;

// I denna filen registrerar jag sidorna. Sigleton skapar sidan endast en gång, transient skapar ny sidan varje gång jag går till sidan.
namespace Stallapp;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        });

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<CalendarPage>();
        builder.Services.AddSingleton<PersonPage>();
        builder.Services.AddSingleton<PersonDetailPage>();
        builder.Services.AddSingleton<DetailPage>();
        builder.Services.AddSingleton<HorsePage>();
        builder.Services.AddSingleton<RegistrationPage>();
        builder.Services.AddSingleton<HorseDetailPage>();
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<RegistrationPage>();
 ;

        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<CalendarViewModel>();
        builder.Services.AddSingleton<PersonViewModel>();
        builder.Services.AddSingleton<PersonDetailViewModel>();
        builder.Services.AddSingleton<HorseViewModel>();
        builder.Services.AddSingleton<HorseDetailViewModel>();
        builder.Services.AddSingleton<LoginViewModel>();
        builder.Services.AddSingleton<RegistrationViewModel>();




        return builder.Build();
    }
}