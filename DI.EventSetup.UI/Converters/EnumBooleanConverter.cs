namespace DI.EventSetup.UI.Converters
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Windows.Data;

    public class EnumBooleanConverter : IValueConverter
    {
        #region IValueConverter Members
        public virtual object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null)
            {
                return false;
            }

            string checkValue = value.ToString();
            string targetValue = parameter.ToString();
            return checkValue.Equals(targetValue, StringComparison.InvariantCultureIgnoreCase);
        }

        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || parameter == null)
            {
                return null;
            }

            bool useValue = (bool)value;
            string targetValue = parameter.ToString();

            Type genericArgumentType = null;
            if (targetType.IsGenericType && targetType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                genericArgumentType = targetType.GetGenericArguments().First();
            }

            return useValue ? Enum.Parse(genericArgumentType ?? targetType, targetValue) : null;
        }

        #endregion
    }
}
