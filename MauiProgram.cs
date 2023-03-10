using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Stallapp.View;
using Stallapp.ViewModel;

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
        builder.Services.AddTransient<PersonDetailPage>();
        builder.Services.AddSingleton<DetailPage>();
        builder.Services.AddSingleton<HorsePage>();
        builder.Services.AddSingleton<RegistrationPage>();
        builder.Services.AddTransient<HorseDetailPage>();
 ;

        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<CalendarViewModel>();
        builder.Services.AddSingleton<PersonViewModel>();
        builder.Services.AddTransient<PersonDetailViewModel>();
        builder.Services.AddSingleton<HorseViewModel>();
        builder.Services.AddTransient<HorseDetailViewModel>();





#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }
}