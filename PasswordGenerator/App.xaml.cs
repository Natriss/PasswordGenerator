using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;
using Windows.Storage;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PasswordGenerator
{
	/// <summary>
	/// Provides application-specific behavior to supplement the default Application class.
	/// </summary>
	public partial class App : Application
	{
		public static FrameworkElement AppRoot { get; private set; }
		public static ApplicationDataContainer LocalSettings { get; private set; } = ApplicationData.Current.LocalSettings;
		/// <summary>
		/// Initializes the singleton application object.  This is the first line of authored code
		/// executed, and as such is the logical equivalent of main() or WinMain().
		/// </summary>
		public App()
		{
			this.InitializeComponent();
		}

		/// <summary>
		/// Invoked when the application is launched.
		/// </summary>
		/// <param name="args">Details about the launch request and process.</param>
		protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
		{
			_window = new MainWindow() 
			{ 
				ExtendsContentIntoTitleBar = true,
				SystemBackdrop = new MicaBackdrop(),
			};

			AppRoot = _window.Content as FrameworkElement;

			if (LocalSettings.Values.Count == 0)
			{
				LocalSettings.Values["capitalLetters"] = false;
				LocalSettings.Values["numbers"] = false;
				LocalSettings.Values["symbols"] = false;
				LocalSettings.Values["passwordLength"] = 16;
			}

			_window.Activate();
		}

		private Window _window;
	}
}
