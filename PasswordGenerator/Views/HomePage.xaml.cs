using Microsoft.UI.Xaml.Controls;
using PasswordGenerator.Viewmodels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PasswordGenerator.Views
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class HomePage : Page
	{
		public HomeViewModel ViewModel { get { return (HomeViewModel)this.DataContext; } }
		public HomePage()
		{
			this.InitializeComponent();
			DataContext = new HomeViewModel();
		}
	}
}