using Soenneker.Tests.FixturedUnit;
using Xunit;
using Xunit.Abstractions;

namespace Soenneker.Extensions.String.Markdown.Tests;

[Collection("Collection")]
public class MarkdownStringExtensionTests : FixturedUnitTest
{
    public MarkdownStringExtensionTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }
}
