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
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        }).UseMauiCommunityToolkit();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<CalendarPage>();
        builder.Services.AddSingleton<PersonPage>();
        builder.Services.AddSingleton<DetailPage>();

        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<CalendarViewModel>();




#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }
}