namespace Tests;

using NGRadio;

public class MenuTests
{
    [Theory]
    [InlineData("Header\r\n1", "Header", 1)]
    [InlineData("Header\r\n1\r\n2", "Header", 2)]
    public void Render_HeaderAndOptions_ReturnsFormattedMenu(string exp, string header, int arrLength)
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
}

/*



TDD

Display:
- Header X
- Option X
- Options joined by newline X
- Repeat of \n X
- Extract Render method X
- Repeated newline char const X
- Use range instead of hard-coded strings X
- Theory the range X
- Repeat of tests X
- Extract to Menu class X
- Remove static modifier X
- Handle shared state X
- Clean up Given set X
- Move \n const X
- Add options array to Menu state X
- Remove newline const X
- Refactor \n const to \r\n X
- Encapsulate header field X
- Encapsulate options field X
*/
