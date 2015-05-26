using System;
using Xamarin.Forms;

namespace XFNavigation.Converters
{
	public class ImageResourceConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
            var image =  ImageSource.FromResource("XFNavigation.Images." + (value ?? ""));
		    return image;
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotSupportedException();
		}
	}
}

