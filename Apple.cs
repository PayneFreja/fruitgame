using Raylib_cs;

namespace fruitgame;

public class Apple : Fruit
{
    public Apple()
    {
        col = Color.Green;
        pointValue = 3;
        rect.Width = 50;
        rect.Height = 50;
    }
}
