using TestApp.Helpers;

namespace UnitTest;

public class AdditionHelperTest
{
    private readonly IAdditionHelper additionHelper;

    public AdditionHelperTest()
    {
        this.additionHelper = new AdditionHelper();
    }

    /// <summary>
    /// This is just positive test cases. We can do negative as well.
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <param name="expected"></param>
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(10, 15, 25)]
    [InlineData(5, -7, -2)]
    public void Test1(int num1,int num2, int expected)
    {
        //Arrange
        //int num1 = 5, num2 = 10;
        //int expectedResult = 15;

        //act
        var result = additionHelper.Add(num1, num2);

        //assert
        Assert.Equal(expected, result);
    }
}