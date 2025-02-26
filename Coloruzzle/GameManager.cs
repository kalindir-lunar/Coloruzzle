namespace Coloruzzle;

public class GameManager
{
    private static Block[] blocks = new Block[16];
    private static int _cursorLeft = 18;
    private static int _cursorTop = 10;
    
    public static void DrawGameField()
    {
        for (int i = 1; i < 17; i++)
        {
            blocks[i-1] = new Block(_cursorLeft, _cursorTop);
            _cursorTop += 4;

            if (i % 4 == 0)
            {
                _cursorTop = 10;
                _cursorLeft += 8;
            }
        }
    }
}