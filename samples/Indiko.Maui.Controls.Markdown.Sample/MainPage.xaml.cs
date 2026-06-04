using Indiko.Maui.Controls.Markdown.Sample.ViewModels;

namespace Indiko.Maui.Controls.Markdown.Sample;

public partial class MainPage : ContentPage
{
	MainPageViewModel mainPageViewModel;
	
	public static readonly double NormalLineHeight = DeviceInfo.Platform == DevicePlatform.Android ? 1.3 : 1.1;

	public MainPage()
	{
		InitializeComponent();
	}
	
	protected override void OnBindingContextChanged()
	{
		base.OnBindingContextChanged();
		
		if (BindingContext is MainPageViewModel viewModel)
		{
			mainPageViewModel = viewModel;
			mainPageViewModel.OnAppearing(null);
		}
	}

	private void MarkdownView_HyperLinkClicked(object sender, LinkEventArgs e)
    {
		DisplayAlert(Title, e.Url, "OK");
    }

    private void MarkdownView_OnEmailClicked(object sender, EmailEventArgs e)
    {
        DisplayAlert(Title, e.Email, "OK");
    }
}
