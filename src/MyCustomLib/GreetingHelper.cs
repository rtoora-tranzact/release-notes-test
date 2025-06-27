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

    // BREAKING CHANGE
    // add BC 1

    // Features
    // add FT 1

    // Fixes

    // Chore
}

