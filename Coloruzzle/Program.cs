using System.Drawing;

namespace Coloruzzle;

class Program
{
    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        GameUI.DisplayAppLogo();
        GameManager.DrawGameField();
        Console.ReadLine();
    }
}