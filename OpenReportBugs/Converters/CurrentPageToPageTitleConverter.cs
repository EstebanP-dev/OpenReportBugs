using System.Globalization;

namespace OpenReportBugs.Converters;

public class CurrentPageToPageTitleConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is Page page)
        {
            return page.Title;
        }

        return "Null converter value.";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
