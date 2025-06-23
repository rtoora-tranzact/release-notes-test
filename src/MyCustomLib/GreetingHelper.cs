namespace Demo.MyCustomLib;

public class GreetingHelper
{
    public static string GetGreetingMessage(string name)
    {
        return $"Hello, {name}!";
    }

    public static string GetGoodByeMessage()
    {
        return $"Goodbye!!";
    }

    public static string GetGoodByeMessageV2()
    {
        return $"Goodbye!";
    }

    // adding new feature A
}
