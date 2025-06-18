namespace Demo.MyCustomLib;

public class GreetingHelper
{
    public static string GetGreetingMessage(string name)
    {
        return $"Hello, {name}!";
    }

    public static string GetGoodByeMessage()
    {
        return $"Goodbye!";
    }
}
