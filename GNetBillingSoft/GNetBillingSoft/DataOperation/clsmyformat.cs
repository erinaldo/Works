using System;
using System.Globalization;

namespace GNetBillingSoft.DataOperation
{
    class clsmyformat : IFormatProvider, ICustomFormatter
    {
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
            {
                return this;
            }
            return null;
        }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            if (arg == null) throw new ArgumentNullException("arg");
            if (arg.GetType() != typeof(DateTime)) return arg.ToString();
            DateTime date = (DateTime)arg;
            switch (format)
            {
                case "mycustomformat":
                    switch (CultureInfo.CurrentCulture.Name)
                    {
                        case "en-GB":
                            return date.ToString("ddd dd MMM");
                        default:
                            return date.ToString("ddd MMM dd");
                    }
                default:
                    throw new FormatException();
            }
        }
    }
  
}
