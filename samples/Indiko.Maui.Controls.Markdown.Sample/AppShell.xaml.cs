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
		
			await AddMarkdown("Example", "Example1.md");
			await AddMarkdown("Assessment", "Assessment.md");
			await AddMarkdown("NBA", "NBA.md");
			await AddMarkdown("More", "OriginalExample.md");
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