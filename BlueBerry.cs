using Raylib_cs;

namespace fruitgame;

public class BlueBerry : Fruit
{
    public BlueBerry()
    {
        col = Color.Blue;
        pointValue = 1;
        rect.Width = 30;
        rect.Height = 30;
    }
}

