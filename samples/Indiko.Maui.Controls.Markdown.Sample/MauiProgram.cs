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
            fonts.AddFont("neueSerie57®-Regular.otf", "Regular");
            fonts.AddFont("neueSerie57®-Book.otf", "SemiBold");
            fonts.AddFont("neueSerie57®-RegularItalic.otf", "Italic");
        });

        builder.Services.AddSingleton<MainPage>();
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

        return builder.Build();
    }
}