using CommunityToolkit.Mvvm.ComponentModel;
using PasswordGenerator.Helpers;

namespace PasswordGenerator.Viewmodels
{
	public class SettingsDialogViewModel : ObservableObject
	{
		public int Value
		{
			get { return (int)App.LocalSettings.Values["passwordLength"]; }
			set { App.LocalSettings.Values["passwordLength"] = value; OnPropertyChanged(nameof(Value)); }
		}

		public bool CapitalLettersBool
		{
			get { return (bool)App.LocalSettings.Values["capitalLetters"]; }
			set { App.LocalSettings.Values["capitalLetters"] = value; OnPropertyChanged(nameof(CapitalLettersBool)); }
		}

		public bool NumbersBool
		{
			get { return (bool)App.LocalSettings.Values["numbers"]; }
			set { App.LocalSettings.Values["numbers"] = value; OnPropertyChanged(nameof(NumbersBool)); }
		}

		public bool SymbolsBool
		{
			get { return (bool)App.LocalSettings.Values["symbols"]; }
			set { App.LocalSettings.Values["symbols"] = value; OnPropertyChanged(nameof(SymbolsBool)); }
		}
	}
}
