using System.Diagnostics.Contracts;

namespace Soenneker.Extensions.String.Markdown;

/// <summary>
/// A collection of helpful markdown string extension methods
/// </summary>
public static class MarkdownStringExtension
{
    /// <summary>
    /// Converts a markdown string to HTML.
    /// </summary>
    /// <param name="value">The markdown string to convert.</param>
    /// <returns>The HTML representation of the markdown string.</returns>
    /// <remarks>
    /// This method uses the Markdig library to perform the conversion.
    /// </remarks>
    [Pure]
    public static string ToHtml(this string value)
    {
        if (value.IsNullOrWhiteSpace())
            return value;

        string result = Markdig.Markdown.ToHtml(value);
        return result;
    }
}
