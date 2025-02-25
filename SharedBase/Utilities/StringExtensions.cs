namespace SharedBase.Utilities;

public static class StringExtensions
{
    // TODO: change this to the utf-8 truncate character
    public const string TruncateText = "...";

    public static string Truncate(this string? str, int length = 30)
    {
        if (str == null)
            return string.Empty;

        if (str.Length <= length)
        {
            return str;
        }

        return str.Substring(0, length - TruncateText.Length) + TruncateText;
    }

    public static string TruncateWithoutEllipsis(this string? str, int length)
    {
        if (str == null)
            return string.Empty;

        if (str.Length <= length)
        {
            return str;
        }

        return str.Substring(0, length);
    }
}
