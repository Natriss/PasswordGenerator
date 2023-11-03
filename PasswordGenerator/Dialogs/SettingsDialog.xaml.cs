using Microsoft.UI.Xaml.Controls;
using PasswordGenerator.Viewmodels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PasswordGenerator.Dialogs
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class SettingsDialog : Page
	{
		public SettingsDialogViewModel ViewModel { get { return this.DataContext as SettingsDialogViewModel; } }
		public SettingsDialog()
		{
			this.InitializeComponent();
			DataContext = new SettingsDialogViewModel();
		}
	}
}
