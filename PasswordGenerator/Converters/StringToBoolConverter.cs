using Microsoft.UI.Xaml.Data;
using System;

namespace PasswordGenerator.Converters
{
	public class StringToBoolConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			return !string.IsNullOrEmpty((string)value);
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			return !string.IsNullOrEmpty((string)value);
		}
	}
}
