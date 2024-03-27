using Raylib_cs;

namespace fruitgame;

public class Cherry : Fruit
{
    public Cherry()
    {
        col = Color.Red;
        pointValue = 2;
        rect.Width = 40;
        rect.Height = 40;
    }
}
