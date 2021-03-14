using System;

public class Example
{
    public static void Main()
    {
        String[] values = { null, "123123", "da", "sdfsd",
        };
        foreach (var value in values)
        {
            int number;

            bool success = Int32.TryParse(value, out number);
            if (success)
            {
                Console.WriteLine("Converted '{0}' to {1}.", value, number);
            }
            else
            {
                Console.WriteLine("Attempted conversion of '{0}' failed.",
                    value ?? "<null>");
            }
        }
    }
}