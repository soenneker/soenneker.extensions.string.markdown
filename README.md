[![](https://img.shields.io/nuget/v/soenneker.extensions.string.markdown.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.string.markdown/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.string.markdown/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.string.markdown/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.string.markdown.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.string.markdown/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.string.markdown/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.string.markdown/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.String.Markdown
Convert Markdown to HTML with Markdig's advanced extensions, with an optional Blazor `MarkupString` result.

## Installation

```bash
dotnet add package Soenneker.Extensions.String.Markdown
```

## Convert to HTML

```csharp
using Soenneker.Extensions.String.Markdown;

string markdown = "# Hello, World!";
string html = markdown.ToHtml();
// <h1 id="hello-world">Hello, World!</h1>
```

The shared Markdig pipeline enables advanced extensions such as tables, task lists, auto-identifiers, footnotes, and emphasis extras. `ToHtml()` returns `null` for `null`, `""` for an empty string, and preserves whitespace-only input unchanged.

## Render in Blazor

```razor
@using Soenneker.Extensions.String.Markdown

@code {
    private readonly MarkupString _html = "# Hello, World!".ToHtmlMarkup();
}

@_html
```

`ToHtmlMarkup()` returns the generated HTML wrapped in `Microsoft.AspNetCore.Components.MarkupString`. Null, empty, and whitespace-only input produce the default `MarkupString`.

## Security

Markdown conversion is not sanitization. Markdig can preserve raw HTML and generate links from input, while Blazor treats `MarkupString` as trusted markup and does not HTML-encode it. Do not pass untrusted Markdown directly to `ToHtmlMarkup()`. Sanitize the generated HTML with an allowlist-based HTML sanitizer before rendering it in a browser.
