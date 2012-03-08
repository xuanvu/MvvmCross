using System;
using System.Collections.Generic;
using System.Text;
using Cirrious.MvvmCross.Converters;

namespace SimpleBindingDialog
{
    public class StringLengthValueConverter
        : MvxBaseValueConverter
    {
        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var stringValue = value as string;
            if (string.IsNullOrEmpty(stringValue))
                return 0;
            return stringValue.Length;
        }
    }
}