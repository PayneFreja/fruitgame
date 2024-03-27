using Raylib_cs;

namespace fruitgame;

public class WaterMelon : Fruit
{
    public WaterMelon()
    {
        col = Color.DarkGreen;
        pointValue = 5;
        rect.Width = 80;
        rect.Height = 80;
    }
}
