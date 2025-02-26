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
}