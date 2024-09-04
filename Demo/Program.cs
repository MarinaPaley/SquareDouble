using System;
using Domain;
internal class Program
{
    private static void Main(string[] args)
    {
        var square = new Square(1);
        Console.WriteLine($"Hello, World! {square}");
    }
}