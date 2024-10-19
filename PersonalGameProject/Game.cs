using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using MathLibrary;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;


namespace PersonalGameProject
{
    internal class Game
    {
        Player player = new Player();

        public void Start()
        {
            Raylib.SetTargetFPS(144);
            Raylib.DisableCursor();
            player.InitCamera();
        }
        public void Run()
        {

            player.Move();
            Raylib.BeginMode3D(player.playerCamera);
            Raylib.DrawGrid(200, 1);
           
            Raylib.DrawPlane(new Vector3(0.0f, 0.0f, 0.0f),new Vector2(32,32), Color.LightGray); // Draw ground
            Raylib.DrawCube(new Vector3 ( -16.0f, 2.5f, 0.0f ), 1.0f, 5.0f, 32.0f, Color.Blue);     // Draw a blue wall
            Raylib.DrawCube(new Vector3(16.0f, 2.5f, 0.0f), 1.0f, 5.0f, 32.0f, Color.Lime);      // Draw a green wall
            Raylib.DrawCube(new Vector3(0.0f, 2.5f, 16.0f), 32.0f, 5.0f, 1.0f, Color.Gold); // Draw a gold wall
            Raylib.DrawCube(new Vector3(0.0f, 2.5f, -16.0f), 32.0f, 5.0f, 1.0f, Color.Gold); // Oposite Gold wall
            

            Raylib.EndMode3D();
            Raylib.DrawText("Position: "+ player.playerCamera.Position, 10, 10, 30, Color.Black);
            Raylib.DrawText("Rotation: "+ player.playerCamera.Up , 10, 50, 30, Color.Black);
        }
        public void End()
        {

        }

   
    }
}
