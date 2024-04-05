using PasswordGenerator.Maui.Views;

namespace PasswordGenerator.Maui
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
		}
	}
}
