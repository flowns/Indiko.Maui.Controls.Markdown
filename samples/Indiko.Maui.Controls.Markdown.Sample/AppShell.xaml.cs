using Indiko.Maui.Controls.Markdown.Sample.ViewModels;

namespace Indiko.Maui.Controls.Markdown.Sample;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}
	
	protected override async void OnAppearing()
	{
		try
		{
			base.OnAppearing();
		
			await AddMarkdown("Overview", "Overview.md");
			await AddMarkdown("Assessment 1", "Assessment1.md");
			await AddMarkdown("Assessment 2", "Assessment2.md");
			await AddMarkdown("Original", "OriginalExample.md");
			
			// Remove the default empty tab. Have to do it after adding all the tabs to avoid an Android crash.
			TabBar.Items.RemoveAt(0);	
		}
		catch (Exception e)
		{
			Console.WriteLine(e);
		}
	}

	private async Task AddMarkdown(string title, string filename)
	{
		TabBar.Items.Add(new ShellContent
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