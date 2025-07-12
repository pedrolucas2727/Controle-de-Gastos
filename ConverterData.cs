using System;
using System.Globalization;

public class ConverterData
{
    public string DataInicial;
    public static string @Convert(string data)
    {
        DateTime date;

        if (DateTime.TryParseExact(data, "ddmmyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
        {
            return date.ToString("yyyymmdd", CultureInfo.InvariantCulture);
        }
        return "data invalida";
    }
}