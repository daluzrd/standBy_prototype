using System;
using System.Globalization;

namespace standBY_prototype.Common
{
  public static class CommonMethods
  {
    public static DateTime TryConvertToDateTime(string value)
    {
      if (DateTime.TryParseExact(value, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTime))
      {
        return dateTime;
      }
      return new DateTime();
    }
    public static int GetValueOrDefault(int? value)
    {
      return value != null
        ? value.GetValueOrDefault()
        : new Int32();
    }
    public static DateTime GetValueOrDefault(DateTime? value)
    {
      return value != null
        ? value.GetValueOrDefault()
        : new DateTime();
    }
    public static Decimal GetValueOrDefault(Decimal? value)
    {
      return value != null
        ? value.GetValueOrDefault()
        : new Decimal();
    }
    public static Boolean GetValueOrDefault(Boolean? value)
    {
      return value != null
        ? value.GetValueOrDefault()
        : new Boolean();
    }
    public static Char GetValueOrDefault(Char? value)
    {
      return value != null
        ? value.GetValueOrDefault()
        : new Char();
    }
  }
}