using Xunit;
using MyUtilities;

public class Tests
{
    //math tests
    [Fact]
    public void powertest()
    {
        Assert.Equal(4, MathUtils.Power(2, 2));
    }
    [Fact]
    public void squareroottest()
    {
        Assert.Equal(4, MathUtils.SquareRoot(16));
    }
    [Fact]
    public void AbsoluteValuetest()
    {
        Assert.Equal(5, MathUtils.AbsoluteValue(-5));
    }
    [Fact]
    public void mintest()
    {
        Assert.Equal(5, MathUtils.Min(5, 20));
    }
    [Fact]
    public void maxtest()
    {
        Assert.Equal(20, MathUtils.Max(5, 20));
    }
    [Fact]
    public void addtest()
    {
        Assert.Equal(4, MathUtils.Add(2, 2));
    }
    [Fact]
    public void subtracttest()
    {
        Assert.Equal(4, MathUtils.Subtract(8, 4));
    }
    [Fact]
    public void dividetest()
    {
        Assert.Equal(4, MathUtils.Divide(8, 2));
    }
    [Fact]
    public void multiply()
    {
        Assert.Equal(4, MathUtils.Multiply(2, 2));
    }
    [Fact]
    public void differencetest()
    {
        Assert.Equal(10, MathUtils.Difference(10, 20));
    }
    [Fact]
    public void percenttest()
    {
        Assert.Equal(50, MathUtils.Percent(.5));
    }
    [Fact]
    public void cubedtest()
    {
        Assert.Equal(64, MathUtils.Cubed(4));
    }
    [Fact]
    public void squaredtest()
    {
        Assert.Equal(4, MathUtils.Squared(2));
    }
    //strings
    
}