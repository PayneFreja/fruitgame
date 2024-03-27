using System.Runtime.InteropServices;
using Raylib_cs;
namespace fruitgame;

public class Fruit
{
    public Fruit()
    {
        rect = new Rectangle(600, 100, width, height);
    }

    public Rectangle rect;
    public Color col;


    public float fallSpeed = 10;
    public int pointValue;
    public int X;
    public int width;
    public int height;
    public bool move = false;
    private bool dropped = false;

    private bool triggerNewSpawn = true;

    public void MoveMouse()
    {
        if (dropped == false)
        {
            X = Raylib.GetMouseX();
            rect.X = X;
        }
    }

    public void Dropped()
    {
        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
        {
            move = true;
            dropped = true;
        }
    }
    public void Movement()
    {
        if (move == true)
        {
            rect.Y += fallSpeed;
        }
    }

    public bool CheckCollision(Rectangle boxRect, FruitSpawner fs)
    {

        if (Raylib.CheckCollisionRecs(rect, boxRect))
        {
            IsCollided(fs);
            // for (int i = 0; i < 1; i++)
            // {
            //     g.ShouldAddPoints = true;
            // }
            return true;
        }
        else
            return false;
    }

    public void IsCollided(FruitSpawner fs)
    {
        if (triggerNewSpawn == true)
        {
            triggerNewSpawn = false;
            fs.canSpawn = true;
        }
        move = false;
    }

    // public void ShouldAddPoints(Game g)
    // {
    //     if (g.ShouldAddPoints == true)
    //     {
    //         g.AddPoints(pointValue);

    //     }
    // }

    public void Draw()
    {
        Raylib.DrawRectangleRec(rect, col);
        // Console.WriteLine("Drawn");
    }
}
