namespace TriangleApp.Tests;

public class TriangleCheckerTests
{
    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(2, 2, 3)]
    [InlineData(3, 4, 5)]
    [InlineData(5, 100, 101)]
    public void IsTriangle_ValidSides_ReturnsTrue(int a, int b, int c)
    {
        // Arrange
        var checker = new TriangleChecker();

        // Act
        var actual = checker.IsTriangle(a, b, c);

        // Assert
        Assert.True(actual);
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(1, 2, 4)]
    [InlineData(4, 2, 1)]
    [InlineData(100, 200, 500)]
    public void IsTriangle_InvalidSides_ReturnsFalse(int a, int b, int c)
    {
        // Arrange
        var checker = new TriangleChecker();

        // Act
        var actual = checker.IsTriangle(a, b, c);

        // Assert
        Assert.False(actual);
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(0, 1, 2)]
    [InlineData(-1, -2, -3)]
    [InlineData(1, 5, -6)]
    [InlineData(0, 4, -10)]
    public void IsTriangle_NegativeOrZeroSides_ThrowsArgumentException(int a, int b, int c)
    {
        // Arrange
        var checker = new TriangleChecker();

        // Act
        Action actual = () => checker.IsTriangle(a, b, c);

        // Assert
        Assert.Throws<ArgumentException>(actual); 
    }
}
