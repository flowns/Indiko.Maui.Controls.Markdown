using Indiko.Maui.Controls.Markdown.Sample.ViewModels;

namespace Indiko.Maui.Controls.Markdown.Sample;
public static class MauiProgram
{
    public static class FontAlias
    {
        public const string BrandonBold = "BrandonBold";
        public const string BrandonRegular = "BrandonRegular";
        public const string OpenSansBold = "OpenSansBold";
        public const string OpenSansItalic = "OpenSansItalic";
        public const string OpenSansRegular = "OpenSansRegular";
        public const string OpenSansSemiBold = "OpenSansSemiBold";
    }
    
    public static readonly Dictionary<string, string> FontFiles = new()
    {
        { FontAlias.BrandonBold, "neueSerie57®-Medium.otf" },
        { FontAlias.BrandonRegular, "neueSerie57®-Regular.otf" },
        { FontAlias.OpenSansBold, "neueSerie57®-Medium.otf" },
        { FontAlias.OpenSansItalic, "neueSerie57®-RegularItalic.otf" },
        { FontAlias.OpenSansRegular, "neueSerie57®-Regular.otf" },
        { FontAlias.OpenSansSemiBold, "neueSerie57®-Book.otf" }
    };
    
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>()
            .UseMarkdownView()
            .ConfigureFonts(fonts =>
        {
            fonts.AddFont(FontFiles[FontAlias.BrandonBold], FontAlias.BrandonBold);
            fonts.AddFont(FontFiles[FontAlias.BrandonRegular], FontAlias.BrandonRegular);
            fonts.AddFont(FontFiles[FontAlias.OpenSansBold], FontAlias.OpenSansBold);
            fonts.AddFont(FontFiles[FontAlias.OpenSansItalic], FontAlias.OpenSansItalic);
            fonts.AddFont(FontFiles[FontAlias.OpenSansRegular], FontAlias.OpenSansRegular);
            fonts.AddFont(FontFiles[FontAlias.OpenSansSemiBold], FontAlias.OpenSansSemiBold);
        });

        builder.Services.AddSingleton<MainPage>();
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

        return builder.Build();
    }
}