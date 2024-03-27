using Raylib_cs;

public class Box
{
    public Rectangle rect;
    public Texture2D image;
    public Box()
    {
        rect = new Rectangle(350, 700, 500, 20);
    }

    public void Draw()
    {

        Raylib.DrawRectangleRec(rect, Color.Black);
    }

}
