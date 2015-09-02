
using System;
using Xamarin.Forms;
using System.Globalization;


namespace listview_with_checkbox_XF
{
	public class StringToImageConverter : IValueConverter
	{
		public object Convert (object value, Type targetType, object parameter, CultureInfo culture)
		{
			var filename = (string)value;
			return ImageSource.FromFile (filename);
		}

		public object ConvertBack (object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException ();
		}
	}

}
