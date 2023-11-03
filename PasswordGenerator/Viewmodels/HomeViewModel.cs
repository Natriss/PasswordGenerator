using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PasswordGenerator.Helpers;
using PasswordGenerator.Services;
using System;
using System.Windows.Input;
using Windows.ApplicationModel.DataTransfer;

namespace PasswordGenerator.Viewmodels
{
	public class HomeViewModel : ObservableObject
	{
		private readonly char[] _sumbols = { '@', '(', ')', '+', '-', '=', '!', '$', '&', '*', '<', '>', '?', '#' };

		private string _password;
		public string Password
		{
			get { return _password; }
			set { _password = value; }
		}

		public ICommand GeneratePasswordCommand { get; }

		public ICommand OpenSettingsCommand { get; }

		public ICommand CopyToClipboardCommand { get; }

		public HomeViewModel() 
		{
			CopyToClipboardCommand = new RelayCommand(CopyToClipbaord);
			GeneratePasswordCommand = new RelayCommand(GeneratePassword);
			OpenSettingsCommand = new RelayCommand(OpenSettings);
		}

		private void CopyToClipbaord()
		{
			DataPackage dataPackage = new();
			dataPackage.SetText(_password);
			Clipboard.SetContent(dataPackage);
		}

		private void GeneratePassword()
		{
			_password = string.Empty;
			Random random = new();
			for (int i = 0; i < (int)App.LocalSettings.Values["passwordLength"]; i++)
			{
				_password += GetCharacter(random);
			}
			OnPropertyChanged(nameof(Password));
		}

		private void OpenSettings()
		{
			_ = App.AppRoot.ShowSettingsDialogAsync();
		}

		private char GetCharacter(Random random)
		{
			string holder = string.Empty;
			char smallLetter = (char)random.Next(97, 123);
			holder += smallLetter;

			if ((bool)App.LocalSettings.Values["capitalLetters"])
			{
				char capitalLetter = (char)random.Next(65, 91);
				holder += capitalLetter;
			}

			if ((bool)App.LocalSettings.Values["numbers"])
			{
				char number = (char)random.Next(48, 58);
				holder += number;
			}

			if ((bool)App.LocalSettings.Values["symbols"])
			{
				char symbol = _sumbols[random.Next(_sumbols.Length)];
				holder += symbol;
			}

			return holder[random.Next(holder.Length)];
		}
	}
}
