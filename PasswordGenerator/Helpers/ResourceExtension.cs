using Microsoft.Windows.ApplicationModel.Resources;

namespace PasswordGenerator.Helpers
{
	public static class ResourceExtension
	{
		private static readonly ResourceLoader _resourceLoader;
		public static string GetLocalized(this string resourceName) => _resourceLoader.GetString(resourceName);
	}
}
