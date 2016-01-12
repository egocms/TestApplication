using System;
using Cirrious.CrossCore.Converters;

namespace TestApplication
{
	public class LikeValueConverter: MvxValueConverter<int, string>
	{
		protected override string Convert (int value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			switch (value) {
			case 0:
				return "Nobody like you picture";
			case 1:
				return "Somebody likes your picture";
			default:
				return String.Format ("{0} people like your picture", value);
			}
		}
	}
}

