﻿using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using MathLibrary;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Security;


namespace PersonalGameProject
{
    internal class Game
    {
        Player player = new Player();
        Model Pistol = new Model();
        Material pistolMaterial = new Material();
        int material = 0;
        

        public void Start()
        {
            Raylib.SetTargetFPS(144);
            Raylib.DisableCursor();
            player.InitCamera();
            Pistol = Raylib.LoadModel(@"C:\Git Projects\PersonalRaylibProject\Models\Pistol\pistol.obj");
            
            
            
            
        }
        public void Run()
        {
            
            

            player.Movement();
            Raylib.BeginMode3D(player.playerCamera);
            Raylib.DrawModel(Pistol, new Vector3(1, 1, 0), 1,Color.Blank);
            player.Draw();
            Raylib.DrawGrid(200, 1);
            Raylib.DrawPlane(new Vector3(0.0f, 0.0f, 0.0f),new Vector2(32,32), Color.LightGray); // Draw ground
            Raylib.DrawCube(new Vector3 ( -16.5f, 2.5f, 0.0f ), 1.0f, 5.0f, 32.0f, Color.Blue);     // Draw a blue wall
            Raylib.DrawCube(new Vector3(16.5f, 2.5f, 0.0f), 1.0f, 5.0f, 32.0f, Color.Lime);      // Draw a green wall
            Raylib.DrawCube(new Vector3(0.0f, 2.5f, 16.5f), 32.0f, 5.0f, 1.0f, Color.Gold); // Draw a gold wall
            Raylib.DrawCube(new Vector3(0.0f, 2.5f, -16.5f), 32.0f, 5.0f, 1.0f, Color.Gold); // Oposite Gold wall
            
            

            Raylib.EndMode3D();
            Raylib.DrawText("Position: " + player.playerCamera.Position, 10, 10, 10,Color.Black);
            
        }
        public void End()
        {

        }

   
    }
}
