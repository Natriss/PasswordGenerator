using CommunityToolkit.Mvvm.ComponentModel;

namespace PasswordGenerator.Maui.ViewModels
{
	public class SettingsViewModel : ObservableObject
	{
		public int Value
		{
			get { return Preferences.Default.Get("passwordLength", 16); }
			set { Preferences.Default.Set("passwordLength", value); OnPropertyChanged(nameof(Value)); }
		}

		public bool CapitalLettersBool
		{
			get { return Preferences.Default.Get("capitalLetters", false); }
			set { Preferences.Default.Set("capitalLetters", value); OnPropertyChanged(nameof(CapitalLettersBool)); }
		}

		public bool NumbersBool
		{
			get { return Preferences.Default.Get("numbers", false); }
			set { Preferences.Default.Set("numbers", value); OnPropertyChanged(nameof(NumbersBool)); }
		}

		public bool SymbolsBool
		{
			get { return Preferences.Default.Get("symbols", false); }
			set { Preferences.Default.Set("symbols", value); OnPropertyChanged(nameof(SymbolsBool)); }
		}
	}
}
