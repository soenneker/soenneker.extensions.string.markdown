[![](https://img.shields.io/nuget/v/soenneker.extensions.string.markdown.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.string.markdown/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.string.markdown/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.string.markdown/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.string.markdown.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.string.markdown/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.String.Markdown
### A collection of helpful markdown string extension methods

## Installation

```
dotnet add package Soenneker.Extensions.String.Markdown
```

## Examples

### `ToHtml()`

```csharp
string markdown = "# Hello, World!";
string html = markdown.ToHtml();
Console.WriteLine(html); // Output: <h1>Hello, World!</h1>
```

*Converts a Markdown string to an HTML string.*

### `ToHtmlMarkup()`

```csharp
string markdown = "# Hello, World!";
MarkupString htmlMarkup = markdown.ToHtmlMarkup();
Console.WriteLine(htmlMarkup); // Output: <h1>Hello, World!</h1>
```

*Converts a Markdown string to an HTML `MarkupString`.*