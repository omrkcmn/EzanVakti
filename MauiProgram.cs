using Microsoft.Extensions.Logging;
using MauiIcons.Material;
using CommunityToolkit.Maui;

namespace EzanVakti;
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
#if DEBUG
        builder.Logging.AddDebug();
#endif
        builder.UseMauiApp<App>().UseMaterialMauiIcons();
        return builder.Build();
    }
}