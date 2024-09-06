using System;
using Domain;
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            var square = new Square(-11);
            Console.WriteLine($"{square}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
    }
}