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
        Camera3D camera = new Camera3D();
        Vector3 movementInput = new Vector3(0);
        Vector3 mouseInput = new Vector3(0,0,1);
        Vector3 playerMovement = new Vector3();
        float playerSpeed = 10;
           
        public void Start()
        {

            camera.Position = new Vector3(0, 2, 1);
            camera.Target = new Vector3(0.0f, 2.0f, 0.0f);
            camera.Up = new Vector3(0, 1, 0);
            camera.FovY = 60.0f;
            camera.Projection = CameraProjection.Perspective;
            Raylib.SetTargetFPS(10);
        }
        public void Run()
        {
            
            
            movementInput = new Vector3(0, 0, 0);
            if(Raylib.IsKeyDown(KeyboardKey.D) || Raylib.IsKeyDown(KeyboardKey.A))
            {
                movementInput.y += Raylib.IsKeyDown(KeyboardKey.D) * Raylib.GetFrameTime() * playerSpeed;
                movementInput.y -= Raylib.IsKeyDown(KeyboardKey.A) * Raylib.GetFrameTime() * playerSpeed;



            }
            if(Raylib.IsKeyDown(KeyboardKey.W) || Raylib.IsKeyDown(KeyboardKey.S))
            {
                movementInput.x -= Raylib.IsKeyDown(KeyboardKey.S) * Raylib.GetFrameTime() * playerSpeed;
                movementInput.x += Raylib.IsKeyDown(KeyboardKey.W) * Raylib.GetFrameTime() * playerSpeed;

            }
            mouseInput.x = Raylib.GetMouseDelta().X * .05f;
            mouseInput.y = Raylib.GetMouseDelta().Y * .05f;
            Console.WriteLine(mouseInput);
            




            mouseInput = new Vector3(Raylib.GetMousePosition().X * Raylib.GetMouseDelta().X, Raylib.GetMousePosition().Y * Raylib.GetMouseDelta().Y, 0);
           
            Raylib.UpdateCameraPro(ref camera, movementInput, mouseInput, 0);
            
            
            
            Raylib.BeginMode3D(camera);
            Raylib.DrawGrid(200, 1);
            Raylib.DrawPlane(new Vector3(0.0f, 0.0f, 0.0f),new Vector2(32,32), Color.LightGray); // Draw ground
            Raylib.DrawCube(new Vector3 ( -16.0f, 2.5f, 0.0f ), 1.0f, 5.0f, 32.0f, Color.Blue);     // Draw a blue wall
            Raylib.DrawCube(new Vector3(16.0f, 2.5f, 0.0f), 1.0f, 5.0f, 32.0f, Color.Lime);      // Draw a green wall
            Raylib.DrawCube(new Vector3(0.0f, 2.5f, 16.0f), 32.0f, 5.0f, 1.0f, Color.Gold); // Draw a gold wall
            Raylib.DrawCube(new Vector3(0.0f, 2.5f, -16.0f), 32.0f, 5.0f, 1.0f, Color.Gold); // Oposite Gold wall
            

            Raylib.EndMode3D();
            Raylib.DrawText("Position: "+ movementInput, 10, 10, 30, Color.Black);
            Raylib.DrawText("Rotation: "+ mouseInput , 10, 50, 30, Color.Black);
        }
        public void End()
        {

        }

   
    }
}
