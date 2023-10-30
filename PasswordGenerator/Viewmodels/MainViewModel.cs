using CommunityToolkit.Mvvm.ComponentModel;
using PasswordGenerator.Helpers;

namespace PasswordGenerator.Viewmodels
{
	public class MainViewModel : ObservableObject
	{
		public string AppTitle { get; } = "AppTitle".GetLocalized();
	}
}
