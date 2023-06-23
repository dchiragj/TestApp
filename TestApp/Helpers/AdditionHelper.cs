namespace TestApp.Helpers;

public interface IAdditionHelper
{
    int Add(int param1, int param2);
}

public class AdditionHelper : IAdditionHelper
{
    public int Add(int param1, int param2)
    {
        return param1 + param2;
    }
}