namespace Coloruzzle;

public class GameManager
{
    private static Block[] blocks = new Block[16];
    private static int _cursorLeft = 18;
    private static int _cursorTop = 10;
    private static int _choosenBlock = 0;
    
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
        
        blocks[_choosenBlock].DrawBlockBorder();
    }

    public static void PlayerMovement()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.W:
                    if (_choosenBlock - 1 >= 0)
                    {
                        blocks[_choosenBlock].ClearBlockBorder();
                        _choosenBlock -= 1;
                        blocks[_choosenBlock].DrawBlockBorder();
                    }
                    break;
                case ConsoleKey.A:
                    if (_choosenBlock - 4 >= 0)
                    {
                        blocks[_choosenBlock].ClearBlockBorder();
                        _choosenBlock -= 4;
                        blocks[_choosenBlock].DrawBlockBorder();
                    }
                    break;
                case ConsoleKey.S:
                    if (_choosenBlock + 1 <= 15)
                    {
                        blocks[_choosenBlock].ClearBlockBorder();
                        _choosenBlock += 1;
                        blocks[_choosenBlock].DrawBlockBorder();
                    }
                    break;
                case ConsoleKey.D:
                    if (_choosenBlock + 4 <= 15)
                    {
                        blocks[_choosenBlock].ClearBlockBorder();
                        _choosenBlock += 4;
                        blocks[_choosenBlock].DrawBlockBorder();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}