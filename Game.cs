using fruitgame;
using Raylib_cs;
public class Game
{
    // public int points = 0;
    // public bool ShouldAddPoints = false;
    // public void AddPoints(int pointValue)
    // {
    //     points += pointValue;
    //     ShouldAddPoints = false;
    // }
    public static void DrawSpawned(FruitSpawner fs)
    {
        foreach (Fruit theFruit in fs.spawnedFruits)
        {
            theFruit.Draw();
        }
    }
    public static void DrawInts(int points)
    {
        // Raylib.DrawText($"Score:{points}", 1000, 35, 20, Color.Black);
    }

    public void MouseBoundaries()
    {
    }
}