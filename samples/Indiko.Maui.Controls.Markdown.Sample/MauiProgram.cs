using Indiko.Maui.Controls.Markdown.Sample.ViewModels;

namespace Indiko.Maui.Controls.Markdown.Sample;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>()
            .UseMarkdownView()
            .ConfigureFonts(fonts =>
        {
            fonts.AddFont("neueSerie57®-Regular.otf", "OpenSansRegular");
            fonts.AddFont("neueSerie57®-Book.otf", "OpenSansSemiBold");
            fonts.AddFont("neueSerie57®-RegularItalic.otf", "OpenSansItalic");
        });

        builder.Services.AddSingleton<MainPage>();
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

        return builder.Build();
    }
}