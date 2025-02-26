using System.Drawing;

namespace Coloruzzle;

class Program
{
    private static bool _GameIsRunning = true;
    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        GameUI.DisplayAppLogo();
        GameManager.DrawGameField();
        
        while (_GameIsRunning)
        {
            GameManager.PlayerMovement();
        }

        Console.ReadLine();
    }
}