using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using PasswordGenerator.Dialogs;
using PasswordGenerator.Helpers;
using System;
using System.Threading.Tasks;

namespace PasswordGenerator.Services
{
	public static class DialogService
	{
		public static async Task ShowSettingsDialogAsync(this FrameworkElement frameworkElement)
		{
			ContentDialog contentDialog = new()
			{
				Title = "SettingsTitle".GetLocalized(),
				Content = new SettingsDialog(),
				PrimaryButtonText = "SaveText".GetLocalized(),
				XamlRoot = frameworkElement.XamlRoot,
			};
			await contentDialog.ShowAsync();
		}
	}
}
