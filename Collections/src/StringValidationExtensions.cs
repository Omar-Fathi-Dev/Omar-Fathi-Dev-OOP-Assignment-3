using System.Text.RegularExpressions;

namespace StringValidationExtensions;

public static class StringValidationExtensions
{
    public static bool  IsValidEgyptianPhone(this string value)
    {
        if(string.IsNullOrWhiteSpace(value))
            return false;
        string pattern = "^(?:\\+20|0)1[0125][0-9]{8}$";
        return Regex.IsMatch(value , pattern);
    }

    public static bool  IsValidEgyptianNationalId(this string value)
    {
        if(string.IsNullOrWhiteSpace(value))
            return false;
        string pattern = "^[23][0-9]{13}$";
        return Regex.IsMatch(value , pattern);
    }
}