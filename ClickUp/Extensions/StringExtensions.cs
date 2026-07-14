namespace Apps.ClickUp.Extensions;

public static class StringExtensions
{
    public static bool ContainsIgnoreCase(this string source, string? value)
    {
        return string.IsNullOrEmpty(value) || source.Contains(value, StringComparison.OrdinalIgnoreCase);
    }
    
    public static bool EqualsIgnoreCase(this string source, string? value)
    {
        return string.IsNullOrEmpty(value) || source.Equals(value, StringComparison.OrdinalIgnoreCase);
    }
}