using Microsoft.Extensions.DependencyInjection;
using Microsoft.UI.Xaml.Controls;
using Natsurainko.FluentLauncher.ViewModels.Settings;

namespace Natsurainko.FluentLauncher.Views.Settings;

public sealed partial class AccountPage : Page
{
    public AccountPage()
    {
        InitializeComponent();
        DataContext = App.Services.GetService<AccountViewModel>();
    }
}
