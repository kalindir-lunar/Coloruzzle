namespace Coloruzzle;

public class Block
{
    private string _blockVisual = "\u2588\u2588";
    
    private string _borderVisual = "\u2588";
    private string _borderDownVisual = "\u2580";
    private string _borderUpperVisual = "\u2584";
    
    public int _colorNumber; //0 blue, 1 yellow, 2 red, 3 pink
    public int _startLeftPosition;
    public int _startTopPosition;

    public Block(int cursorLeft, int cursorTop)
    {
        _startTopPosition = cursorTop;
        _startLeftPosition = cursorLeft;
        
        _colorNumber = BlockChooseRandomColor(_colorNumber);
        Console.ForegroundColor = _blockColor(_colorNumber);
        BlockSpawn(cursorLeft, cursorTop);
    }

    public void DEBUG_GetPosition()
    {
        Console.WriteLine($"Start position: {_startLeftPosition}, {_startTopPosition}");
    }

    public void ChangeBlockColorAndRedraw()
    {
        _colorNumber++;
        if (_colorNumber == 4)
        {
            _colorNumber = 0;
        }
        
        Console.ForegroundColor = _blockColor(_colorNumber);
        BlockSpawn(_startLeftPosition, _startTopPosition);
    }
        
    public void ClearBlockBorder()
    {
        int startLeftPosition = _startLeftPosition - 1;
        int startTopPosition = _startTopPosition - 1;
        
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(startLeftPosition, startTopPosition);
        
        for (int i = 1; i < 23; i++) //нужно 22 раз пройтись по ячейкам рядом
        {
            if (i < 9)
            {
                Console.Write(" ");
                startLeftPosition += 2;
            }

            if (i > 14)
            {
                Console.Write(" ");
                startLeftPosition += 2;
            }

            switch (i)
            {
                case 9:
                    Console.SetCursorPosition(_startLeftPosition-1, _startTopPosition);
                    Console.Write(" ");
                    break;
                case 10:
                    Console.SetCursorPosition(_startLeftPosition+6, _startTopPosition);
                    Console.Write(" ");
                    break;
                case 11:
                    Console.SetCursorPosition(_startLeftPosition-1, _startTopPosition+1);
                    Console.Write(" ");
                    break;
                case 12:
                    Console.SetCursorPosition(_startLeftPosition+6, _startTopPosition+1);
                    Console.Write(" ");
                    break;
                case 13:
                    Console.SetCursorPosition(_startLeftPosition-1, _startTopPosition+2);
                    Console.Write(" ");
                    break;
                case 14:
                    Console.SetCursorPosition(_startLeftPosition+6, _startTopPosition+2);
                    Console.Write(" ");
                    Console.SetCursorPosition(_startLeftPosition-1, _startTopPosition+3);
                    startLeftPosition = _startLeftPosition - 2;
                    break;
                default:
                    break;
            }
        }
    }
    
    public void DrawBlockBorder()
    {
        int startLeftPosition = _startLeftPosition - 1;
        int startTopPosition = _startTopPosition - 1;
        
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(startLeftPosition, startTopPosition);
        
        for (int i = 1; i < 23; i++) //нужно 22 раз пройтись по ячейкам рядом
        {
            if (i < 9)
            {
                Console.Write(_borderUpperVisual);
                startLeftPosition += 2;
            }

            if (i > 14)
            {
                Console.Write(_borderDownVisual);
                startLeftPosition += 2;
            }

            switch (i)
            {
                case 9:
                    Console.SetCursorPosition(_startLeftPosition-1, _startTopPosition);
                    Console.Write(_borderVisual);
                    break;
                case 10:
                    Console.SetCursorPosition(_startLeftPosition+6, _startTopPosition);
                    Console.Write(_borderVisual);
                    break;
                case 11:
                    Console.SetCursorPosition(_startLeftPosition-1, _startTopPosition+1);
                    Console.Write(_borderVisual);
                    break;
                case 12:
                    Console.SetCursorPosition(_startLeftPosition+6, _startTopPosition+1);
                    Console.Write(_borderVisual);
                    break;
                case 13:
                    Console.SetCursorPosition(_startLeftPosition-1, _startTopPosition+2);
                    Console.Write(_borderVisual);
                    break;
                case 14:
                    Console.SetCursorPosition(_startLeftPosition+6, _startTopPosition+2);
                    Console.Write(_borderVisual);
                    Console.SetCursorPosition(_startLeftPosition-1, _startTopPosition+3);
                    startLeftPosition = _startLeftPosition - 2;
                    break;
                default:
                    break;
            }
        }
    }

    private void BlockSpawn(int cursorLeft, int cursorTop)
    {
        for (int i = 0; i < 3; i++)
        {
            Console.SetCursorPosition(cursorLeft, cursorTop);
            for (int k = 0; k < 3; k++)
            {
                Console.Write(_blockVisual);
            } 
            cursorTop++;
        }
    }

    private ConsoleColor _blockColor(int colorNumber)
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

    private int BlockChooseRandomColor(int colorNumber)
    {
        Random rnd = new Random();
        colorNumber = rnd.Next(0, 4);
        return colorNumber;
    }
}