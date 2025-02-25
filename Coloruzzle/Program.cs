using System.Drawing;

namespace Coloruzzle;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(Block.blockVisual);
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(Block.blockVisual);
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(Block.blockVisual);
        
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(Block.blockVisual);
    }
}