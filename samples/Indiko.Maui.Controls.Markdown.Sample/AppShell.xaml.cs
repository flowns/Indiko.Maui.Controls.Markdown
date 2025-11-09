using Indiko.Maui.Controls.Markdown.Sample.ViewModels;

namespace Indiko.Maui.Controls.Markdown.Sample;

public partial class AppShell : Shell
{
	private TabBar tabBar = new();
	
	public AppShell()
	{
		InitializeComponent();
		Items.Add(tabBar);
	}
	
	protected override async void OnAppearing()
	{
		try
		{
			base.OnAppearing();
		
			await AddMarkdown("Overview", "Overview.md");
			await AddMarkdown("Assessment 1", "Assessment1.md");
			await AddMarkdown("Assessment 2", "Assessment2.md");
			await AddMarkdown("NBA", "NBA.md");
			await AddMarkdown("Sections", "SectionsTest.md");
			await AddMarkdown("AutoSections", "AutoSectionsTest.md");
		}
		catch (Exception e)
		{
			Console.WriteLine(e);
		}
	}

	private async Task AddMarkdown(string title, string filename)
	{
		tabBar.Items.Add(new ShellContent
		{
			Title = title,
			Content = new MainPage(),
			BindingContext = new MainPageViewModel()
			{
				MarkdownText = await LoadAssetString(filename)
			}
		});
	}
	
	private async Task<string> LoadAssetString(string filename)
	{
		await using var stream = await FileSystem.OpenAppPackageFileAsync(filename);
		using var reader = new StreamReader(stream);
		return await reader.ReadToEndAsync();
	}
}