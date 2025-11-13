using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Indiko.Maui.Controls.Markdown.Sample.ViewModels;
public partial class MainPageViewModel : BaseViewModel
{
    [RelayCommand]
    private void OnLinkReceived(object link)
    {
        Console.WriteLine(string.Concat("LINK RECEIVED = '",link, "'"));
    }

    [RelayCommand]
    private void OnEMailReceived(object email)
    {
        Console.WriteLine(string.Concat("E-MAIL RECEIVED = '", email, "'"));
    }

    [ObservableProperty]
    string markdownText;
}
