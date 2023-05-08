public static class StringFunctions
{
    public static string CleanString(string input)
    {
        var output = input.Replace(" ", "");
        output = output.Replace("\n", "");

        return output;
    }
}