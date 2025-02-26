namespace Coloruzzle;

public class Block
{
    private string _blockVisual = "\u2588\u2588";
    private int _colorNumber; //0 blue, 1 yellow, 2 red, 3 pink

    public Block(int cursorLeft, int cursorTop)
    {
        _colorNumber = BlockChooseRandomColor(_colorNumber);
        Console.ForegroundColor = _blockColor(_colorNumber);
        BlockSpawn(cursorLeft, cursorTop);
    }

    private void BlockSpawn(int cursorLeft, int cursorTop)
    {
        Console.ForegroundColor = _blockColor(_colorNumber);
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