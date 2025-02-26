namespace Coloruzzle;

public class GameManager
{
    private static Block[] blocks = new Block[16];
    private static int[,] blocksCoordinates = new int[16, 2];
    private static int _cursorLeft;
    private static int _cursorTop;
    private static int _choosenBlock = 0;
    private static int _gameMode; //0 = 3x3  1 = 4x4
    private static int _blocksCount;
    private static int _divider;
    private static int _colorForWin;

    private static void StartGame()
    {
        Random rnd = new Random();
        _colorForWin = rnd.Next(0, 3);
        Console.ForegroundColor = _winColor(_colorForWin);
        Console.SetCursorPosition(14, 22);
        Console.WriteLine("I am the color of victory, collect me!");
        
        if (_gameMode == 0)
        {
            _cursorLeft = 22;
            _cursorTop = 10;
            _blocksCount = 9;
            _divider = 3;
        }
        else
        {
            _cursorLeft = 18;
            _cursorTop = 10;
            _blocksCount = 16;
            _divider = 4;
        }
    }
    public static void DrawGameField(int gameMode)
    {
        StartGame();
        
        for (int i = 1; i < _blocksCount+1; i++)
        {
            blocks[i-1] = new Block(_cursorLeft, _cursorTop);
            blocksCoordinates[i-1, 0] = _cursorLeft; //первая координата это отступ слева
            blocksCoordinates[i-1, 1] = _cursorTop;  //вторая координата это отступ сверху
            _cursorTop += 4;

            if (i % _divider == 0)
            {
                _cursorTop = 10;
                _cursorLeft += 8;
            }
        }
        
        blocks[_choosenBlock].DrawBlockBorder();
    }

    public static void Echo()
    {
        Console.Beep(550, 100);
        
        blocks[_choosenBlock].ChangeBlockColorAndRedraw();
        
        for (int i = 0; i < _blocksCount; i++)
        {
            if (blocks[_choosenBlock]._startTopPosition - 4 == blocks[i]._startTopPosition
                && blocks[_choosenBlock]._startLeftPosition == blocks[i]._startLeftPosition)
            {
                blocks[i].ChangeBlockColorAndRedraw();
            }
            
            if (blocks[_choosenBlock]._startTopPosition + 4 == blocks[i]._startTopPosition
                && blocks[_choosenBlock]._startLeftPosition == blocks[i]._startLeftPosition)
            {
                blocks[i].ChangeBlockColorAndRedraw();
            }
            
            if (blocks[_choosenBlock]._startTopPosition == blocks[i]._startTopPosition
                && blocks[_choosenBlock]._startLeftPosition - 8 == blocks[i]._startLeftPosition)
            {
                blocks[i].ChangeBlockColorAndRedraw();
            }
            
            if (blocks[_choosenBlock]._startTopPosition == blocks[i]._startTopPosition
                && blocks[_choosenBlock]._startLeftPosition + 8 == blocks[i]._startLeftPosition)
            {
                blocks[i].ChangeBlockColorAndRedraw();
            }
        }

        Program._GameIsRunning = isGameContinue();
    }

    private static bool isNotEmptyField(int side, int step, bool plusOrMinus)
    {
        Console.SetCursorPosition(0, 50);
        
        for (int i = 0; i < 16; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (plusOrMinus == false)
                {
                    if (blocksCoordinates[_choosenBlock, side] - step == blocksCoordinates[i, side]
                        && (blocksCoordinates[_choosenBlock, 0] == blocksCoordinates[i, 0]
                        ||blocksCoordinates[_choosenBlock, 1] == blocksCoordinates[i, 1]))
                    {
                        blocks[_choosenBlock].ClearBlockBorder();
                        _choosenBlock = i;
                        return true;
                    }
                }
                else
                {
                    if (blocksCoordinates[_choosenBlock, side] + step == blocksCoordinates[i, side]
                        && (blocksCoordinates[_choosenBlock, 0] == blocksCoordinates[i, 0]
                            ||blocksCoordinates[_choosenBlock, 1] == blocksCoordinates[i, 1]))
                    {
                        blocks[_choosenBlock].ClearBlockBorder();
                        _choosenBlock = i;
                        return true;
                    }
                }
            }
        }
        
        return false;
    }

    public static void PlayerMovement()
    {
        if (Console.KeyAvailable)
        {
            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.Spacebar:
                    Echo();
                    break;
                case ConsoleKey.W:
                    if (isNotEmptyField(1, 4, false))
                    {
                        blocks[_choosenBlock].DrawBlockBorder();
                    }
                    break;
                case ConsoleKey.A:
                    if (isNotEmptyField(0, 8, false))
                    {
                        blocks[_choosenBlock].DrawBlockBorder();
                    }
                    break;
                case ConsoleKey.S:
                    if (isNotEmptyField(1, 4, true))
                    {
                        blocks[_choosenBlock].DrawBlockBorder();
                    }
                    break;
                case ConsoleKey.D:
                    if (isNotEmptyField(0, 8, true))
                    {
                        blocks[_choosenBlock].DrawBlockBorder();
                    }
                    break;
                default:
                    break;
            }
        }
    }

    public static bool isGameContinue()
    {
        for (int i = 0; i < _blocksCount; i++)
        {
            if (blocks[i]._colorNumber != _colorForWin)
            {
                return true;
            }
        }
        Console.SetCursorPosition(22, 30);
        Console.WriteLine("GREAT MATCH! YOU WIN!!");
        Thread.Sleep(2000);
        return false;
    }
    
    private static ConsoleColor _winColor(int colorNumber)
    {
        switch (colorNumber)
        {
            case 0:
                return ConsoleColor.Blue;
                break;
            case 1:
                return ConsoleColor.DarkYellow;
                break;
            case 2:
                return ConsoleColor.DarkRed;
                break;
            case 3:
                return ConsoleColor.Magenta;
                break;
            default:
                return ConsoleColor.White;
        }
    }
}