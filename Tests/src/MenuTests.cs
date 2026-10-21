namespace Tests;

using NGRadio;

public class MenuTests
{
    [Theory]
    [InlineData("\r\n1", null, 1)]
    [InlineData("\r\n1\r\n2", null, 2)]
    [InlineData("Header\r\n1", "Header", 1)]
    [InlineData("Lorem ipsum\r\n1\r\n2", "Lorem ipsum", 2)]
    public void Render_HeaderAndOptions_ReturnsFormattedMenu(string exp, string? header, int arrLength)
    {
        // Given
        string[] options = Enumerable
        .Range(1, arrLength)
        .Select(v => v.ToString())
        .ToArray();

        Menu menu = new Menu(header, options);
        // When
        string display = menu.Render();
        // Then
        Assert.Equal(exp, display);
    }

    [Fact]
    public async Task Constructor_NoOptions_ThrowsArgumentException()
    {
        // Given
        string header = "Lorem ipsum";
        // When
        async Task Empty() => new Menu(header, []);
        async Task Null() => new Menu(header, null!);
        // Then
        await Assert.ThrowsAsync<ArgumentException>(Empty);
        await Assert.ThrowsAsync<ArgumentNullException>(Null);
    }
}