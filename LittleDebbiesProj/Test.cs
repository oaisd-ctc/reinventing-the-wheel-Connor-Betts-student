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
    [Fact]
    public void touppertest()
    {
        string toUpperTest = "bob";
        string expected = "BOB";
        Assert.Equal(expected, StringUtils.ToUpper(toUpperTest));
    }
    [Fact]
    public void tolowertest()
    {
        Assert.Equal("swaws", StringUtils.ToLower("SWAWS"));
    }
    [Fact]
    public void Lengthtest()
    {
        Assert.Equal(4, StringUtils.Length("yeet"));
    }
    [Fact]
    public void reversetest()
    {
        Assert.Equal("teey", StringUtils.Reverse("yeet"));
    }
    [Fact]
    public void countvowelstest()
    {
        Assert.Equal(2, StringUtils.CountVowels("hello"));
    }
    [Fact]
    public void CountConstantsTest()
    {
        Assert.Equal(3, StringUtils.CountConstants("hello"));
    }
    [Fact]
    public void haslettertest()
    {
        Assert.Equal(true, StringUtils.HasLetter("yay", "a"));
    }
    [Fact]
    public void modetest()
    {
        Assert.Equal('e', StringUtils.Mode("yeet"));
    }
    [Fact]
    public void indexoflettertest()
    {
        Assert.Equal(0, StringUtils.IndexOfLetter("yeet"));
    }
    [Fact]
    public void SortInAlphabeticalOrder()
    {
        Assert.Equal("eety", StringUtils.SortInAlphabeticalOrder("yeet"));
    }
    //Arrays
    [Fact]
    public void averagetest()
    {
        int[] testarray = {1, 2, 3, 4, 5};
        int outcome = 3;
        Assert.Equal(outcome, ArrayUtils.Average(testarray));
    }
    [Fact]
    public void arraymaxtest()
    {
        int[] testarray = {1, 2, 3, 4, 5};
        int outcome = 5;
        Assert.Equal(outcome, ArrayUtils.Max(testarray));
    }
    [Fact]
    public void arraymintest()
    {
        int[] testarray = {1, 2, 3, 4, 5};
        int outcome = 1;
        Assert.Equal(outcome, ArrayUtils.Min(testarray));
    }
    [Fact]
    public void SortAscendingtest()
    {
        int[] testarray = {5, 4, 3, 2, 1};
        int[] outcomearray = {1, 2, 3, 4, 5};
        Assert.Equal(outcomearray, ArrayUtils.SortAscending(testarray));
    }
    [Fact]
    public void SortDescendingtest()
    {
        int[] testarray = {1, 2, 3, 4, 5};
        int[] outcomearray = {5, 4, 3, 2, 1};
        Assert.Equal(outcomearray, ArrayUtils.SortDescending(outcomearray));
    }
    [Fact]
    public void sumtest()
    {
        int[] testarray = {1, 2, 3, 4, 5};
        int outcome = 15;
        Assert.Equal(outcome, ArrayUtils.Sum(testarray));
    }
    [Fact]
    public void producttest()
    {
        int[] testarray = {1, 2, 3, 4, 5};
        int outcome = 120;
        Assert.Equal(outcome, ArrayUtils.Product(testarray));
    }
    [Fact]
    public void HasNumbertest()
    {
        int[] testarray = {1, 2, 3, 4, 5};
        bool outcome = true;
        Assert.Equal(outcome, ArrayUtils.HasNumber(testarray, 1));
    }
    [Fact]
    public void rangetest()
    {
        int[] testarray = {1, 2, 3, 4, 5};
        int outcome = 4;
        Assert.Equal(outcome, ArrayUtils.Range(testarray));
    }
    [Fact]
    public void arraymodetest()
    {
        int[] testarray = {1, 1, 1, 2, 3, 4, 5};
        int outcome = 1;
        Assert.Equal(outcome, ArrayUtils.Mode(testarray));
    }
    [Fact]
    public void meantest()
    {
        int[] testarray = {1, 2, 3, 4, 5};
        int outcome = 3;
        Assert.Equal(outcome, ArrayUtils.Mean(testarray));
    }
}