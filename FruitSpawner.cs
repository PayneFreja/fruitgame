namespace fruitgame;

using System.Runtime.CompilerServices;
using Raylib_cs;

public class FruitSpawner
{
    public List<Fruit> spawnedFruits = new();
    public int fruitToSpawn;
    public bool canSpawn = true;
    public Random generator = new Random();

    public void SpawnableFruits()
    {
        fruitToSpawn = generator.Next(0, 3);
    }

    public void Spawn()
    {
        if (canSpawn == true)
        {
            if (fruitToSpawn == 0)
            {
                spawnedFruits.Add(new BlueBerry());

            }
            else if (fruitToSpawn == 1)
            {
                spawnedFruits.Add(new Cherry());
            }
            else
            {
                spawnedFruits.Add(new Apple());
            }
            canSpawn = false;
        }
    }
    public void dropFruits()
    {
        foreach (Fruit thefruit in spawnedFruits)
        {
            thefruit.Dropped();
        }
    }
    public void moveFruits()
    {
        foreach (Fruit thefruit in spawnedFruits)
        {
            thefruit.Movement();
        }
    }
    public void MoveFruitsMouse()
    {
        foreach (Fruit thefruit in spawnedFruits)
        {
            thefruit.MoveMouse();
        }
    }
    public void StopMoveFruit()
    {
        foreach (Fruit thefruit in spawnedFruits)
        {
            thefruit.StopMovement();
        }
    }
    public void CheckCollisionFruits(Rectangle boxRect, FruitSpawner fs)
    {
        foreach (Fruit thefruit in spawnedFruits)
        {
            thefruit.CheckCollision(boxRect, fs);
        }
    }
    // public void CheckCollisionNoPair(BlueBerry bb, Cherry c, Fruit f)
    // {
    //     foreach (Fruit thefruit in spawnedFruits)
    //     {
    //         if (Raylib.CheckCollisionRecs(bb.rect, c.rect))
    //         {
    //             f.move = false;
    //             Console.WriteLine("funkar");
    //             // return true;
    //         }
    //         // else
    //         // {
    //         //     // return false;
    //         // }
    //     }
    // }
    public bool CheckCollisionBBC(Rectangle rect1, Rectangle rect2, Fruit f)
    {

        if (Raylib.CheckCollisionRecs(rect1, rect2))
        {

            Console.WriteLine("funkar");
            StopMoveFruit();
            return true;
        }
        else
        {

            return false;
        }

    }

    public void FruitCol(Rectangle bbRect, Rectangle cRect, Fruit f)
    {
        foreach (Fruit fruitA in spawnedFruits)
        {
            foreach (Fruit fruitB in spawnedFruits)
            {
                if (fruitA != fruitB)
                {
                    CheckCollisionBBC(fruitA.rect, fruitB.rect, f);
                }
            }
        }
    }
    // public void StopMoving(Rectangle rect1, Rectangle rect2, Fruit f)
    // {
    //     if (CheckCollisionBBC(rect1, rect2, f))
    //     {
    //         rect1.X = 100;
    //         Console.WriteLine("oljkm");

    //     }
    // }



    public void DoAll(BlueBerry bb, Cherry c, Apple a)
    {
        SpawnableFruits();
        Spawn();
    }
}