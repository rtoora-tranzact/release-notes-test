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
    // add FX 1
    // add FX 2
    // add FX 3
    // add FX 4

    // Chore
    // add CH 1
    // add CH 2
}

