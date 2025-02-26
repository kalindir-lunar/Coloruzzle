namespace Coloruzzle;

public class GameUI
{
    public static void DisplayAppLogo()
    {
        /*
             ,-----.       ,--.                                    ,--.        
            '  .--./ ,---. |  | ,---. ,--.--.,--.,--.,-----.,-----.|  | ,---.  
            |  |    | .-. ||  || .-. ||  .--'|  ||  |`-.  / `-.  / |  || .-. : 
            '  '--'\' '-' '|  |' '-' '|  |   '  ''  ' /  `-. /  `-.|  |\   --. 
             `-----' `---' `--' `---' `--'    `----' `-----'`-----'`--' `----' 
         */
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine(" ,-----.       ,--.                                    ,--.        ");
        Console.WriteLine("'  .--./ ,---. |  | ,---. ,--.--.,--.,--.,-----.,-----.|  | ,---.  ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("|  |    | .-. ||  || .-. ||  .--'|  ||  |`-.  / `-.  / |  || .-. : ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("'  '--'\\' '-' '|  |' '-' '|  |   '  ''  ' /  `-. /  `-.|  |\\   --. ");
        Console.WriteLine(" `-----' `---' `--' `---' `--'    `----' `-----'`-----'`--' `----' ");
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("");
    }

    public static void DisplayHowToPlay()
    {
        Console.SetCursorPosition(10, 24);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("WASD to move and Space to change fields color.");
    }
}