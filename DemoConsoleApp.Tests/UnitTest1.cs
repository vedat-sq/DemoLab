namespace DemoConsoleApp.Tests;

public class UnitTest1
{
    [Fact]
    public void Add_ReturnsCorrectValue()
    {
        Assert.Equal(5, Calculator.Add(2, 3));
    }
    [Fact]
    public void NewFeature_ShouldReturnTrue()
    {
        bool result = true;
        Assert.True(result);
    }
}
