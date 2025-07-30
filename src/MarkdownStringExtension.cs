using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using Markdig;
using Microsoft.AspNetCore.Components;

namespace Soenneker.Extensions.String.Markdown;

/// <summary>
/// A collection of helpful markdown string extension methods
/// </summary>
public static class MarkdownStringExtension
{
    private static readonly MarkdownPipeline _pipeline = new MarkdownPipelineBuilder()
                                                         .UseAdvancedExtensions()
                                                         .Build();

    /// <summary>
    /// Converts a markdown string to HTML.
    /// </summary>
    /// <param name="markdown">The markdown string to convert.</param>
    /// <returns>The HTML representation of the markdown string.</returns>
    /// <remarks>
    /// This method uses the Markdig library to perform the conversion.
    /// </remarks>
    [Pure]
    [return: NotNullIfNotNull(nameof(markdown))]
    public static string? ToHtml(this string? markdown)
    {
        if (markdown.IsNullOrWhiteSpace())
            return markdown;

        return Markdig.Markdown.ToHtml(markdown, _pipeline);
    }

    /// <summary>
    /// Converts a Markdown string to an HTML markup string.
    /// </summary>
    /// <param name="markdown">The Markdown string to be converted.</param>
    /// <returns>A <see cref="MarkupString"/> containing the HTML representation of the Markdown input.</returns>
    /// <remarks>
    /// This method uses the Markdig library to perform the conversion.
    /// </remarks>
    [Pure]
    public static MarkupString ToHtmlMarkup(this string? markdown)
    {
        if (markdown.IsNullOrWhiteSpace())
            return new MarkupString();

        string html = Markdig.Markdown.ToHtml(markdown, _pipeline);

        return new MarkupString(html);
    }
}