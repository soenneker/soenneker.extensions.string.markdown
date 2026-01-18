using Markdig;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

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
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? ToHtml(this string? markdown)
    {
        // Cheap fast paths first
        if (markdown is null)
            return null;

        if (markdown.Length == 0)
            return markdown;

        if (markdown.IsNullOrWhiteSpace())
            return markdown;

        return Markdig.Markdown.ToHtml(markdown, _pipeline);
    }

    /// <summary>
    /// Converts a Markdown string to an HTML markup string.
    /// </summary>
    [Pure]
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static MarkupString ToHtmlMarkup(this string? markdown)
    {
        if (markdown is null || markdown.Length == 0 || markdown.IsNullOrWhiteSpace())
            return default;

        // MarkupString is a readonly struct; returning default avoids an explicit ctor call.
        return new MarkupString(Markdig.Markdown.ToHtml(markdown, _pipeline));
    }
}