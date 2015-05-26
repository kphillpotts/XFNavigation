using System;
using System.Globalization;
using Xamarin.Forms;
using XFNavigation.Data;

namespace XFNavigation.Converters
{
    //
	public class CategoryToIndexConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
            BucketCategory category = (BucketCategory)value;
			if (targetType != typeof(int))
				throw new Exception("CategoryConverter.Convert expected integer targetType.");
			return (int)category;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			int index = (int)value;
            if (targetType != typeof(BucketCategory))
				throw new Exception("CategoryConverter.ConvertBack expected Category targetType");
            return (BucketCategory)index;
		}
	}
}

