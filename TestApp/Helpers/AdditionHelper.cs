namespace TestApp.Helpers;

public interface IAdditionHelper
{
    int Add(int num1, int num2);
}

public class AdditionHelper : IAdditionHelper
{
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}