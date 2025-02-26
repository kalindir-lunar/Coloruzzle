using System.Drawing;
using System.Net.Mime;

namespace Coloruzzle;

class Program
{
    public static bool _GameIsRunning = true;
    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        GameUI.DisplayAppLogo();
        GameUI.DisplayHowToPlay();
        GameManager.DrawGameField(0);
        
        while (_GameIsRunning)
        {
            GameManager.PlayerMovement();
        }

        Console.Beep();
        Thread.Sleep(3000);
        Console.Clear();
        Thread.Sleep(3000);
        Environment.Exit(0);
        
    }
}