using Raylib_cs;

namespace fruitgame;

public class PineApple : Fruit
{
    public PineApple()
    {
        col = Color.Yellow;
        pointValue = 4;
        rect.Width = 70;
        rect.Height = 70;
    }
}
