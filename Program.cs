﻿using fruitgame;
using Raylib_cs;

Raylib.InitWindow(1200, 800, "Fruit Game");

Raylib.SetTargetFPS(60);
// Fruit f = new();
Game g = new();
Box b = new();
BlueBerry bb = new();
Cherry c = new();
Apple a = new();
PineApple pa = new();
WaterMelon wm = new();
FruitSpawner fs = new();


void DrawAll()
{
    b.Draw();
    // Game.DrawInts(g.points);
    Game.DrawSpawned(fs);


}


while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing(); // börjar rita spelet
    Raylib.ClearBackground(Color.LightGray);
    // Console.WriteLine($"{f.move}");
    DrawAll();
    // f.MoveMouse();
    fs.moveFruits();
    fs.dropFruits();
    fs.MoveFruitsMouse();
    fs.CheckCollisionFruits(b.rect, fs);
    fs.DoAll(bb, c, a);
    fs.FruitCol(bb.rect, c.rect, fs);
    // fs.StopMoving(bb.rect, c.rect, f);
    // fs.CheckCollisionBBC(bb.rect, c.rect);
    // fs.CheckCollisionNoPair(bb, c, f);
    // f.ShouldAddPoints(g);
    Raylib.EndDrawing();
}
