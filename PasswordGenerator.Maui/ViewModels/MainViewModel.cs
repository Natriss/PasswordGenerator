using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PasswordGenerator.Maui.Views;
using System.Windows.Input;

namespace PasswordGenerator.Maui.ViewModels
{
	public class MainViewModel : ObservableObject
	{
		private readonly char[] _sumbols = ['@', '(', ')', '+', '-', '=', '!', '$', '&', '*', '<', '>', '?', '#'];

		private string _password;
		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}

		public ICommand GeneratePasswordCommand { get; }

		public ICommand OpenSettingsCommand { get; }

		public ICommand CopyToClipboardCommand { get; }

		public MainViewModel()
		{
			CopyToClipboardCommand = new RelayCommand(CopyToClipbaord);
			GeneratePasswordCommand = new RelayCommand(GeneratePassword);
			OpenSettingsCommand = new RelayCommand(OpenSettings);
		}

		private void CopyToClipbaord()
		{
			Clipboard.SetTextAsync(_password).Wait();
		}

		private void GeneratePassword()
		{
			_password = string.Empty;
			Random random = new();
			for (int i = 0; i < Preferences.Default.Get("passwordLength", 16); i++)
			{
				_password += GetCharacter(random);
			}
			OnPropertyChanged(nameof(Password));
		}

		private void OpenSettings()
		{
			Shell.Current.GoToAsync(nameof(SettingsPage));
		}

		private char GetCharacter(Random random)
		{
			string holder = string.Empty;
			char smallLetter = (char)random.Next(97, 123);
			holder += smallLetter;

			if (Preferences.Default.Get("capitalLetters", false))
			{
				char capitalLetter = (char)random.Next(65, 91);
				holder += capitalLetter;
			}

			if (Preferences.Default.Get("numbers", false))
			{
				char number = (char)random.Next(48, 58);
				holder += number;
			}

			if (Preferences.Default.Get("symbols", false))
			{
				char symbol = _sumbols[random.Next(_sumbols.Length)];
				holder += symbol;
			}

			return holder[random.Next(holder.Length)];
		}
	}
}
