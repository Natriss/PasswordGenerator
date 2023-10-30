using Microsoft.UI.Xaml;
using PasswordGenerator.Viewmodels;
using PasswordGenerator.Views;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PasswordGenerator
{
	/// <summary>
	/// An empty window that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainWindow : Window
	{
		public MainViewModel ViewModel { get { return rootContent.DataContext as MainViewModel; } }
		public MainWindow()
		{
			this.InitializeComponent();
			SetTitleBar(appTitleBar);
			rootFrame.Navigate(typeof(HomePage));
		}
	}
}
