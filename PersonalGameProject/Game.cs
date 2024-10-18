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
        Vector3 mouseInput = new Vector3();
        Vector3 playerMovement = new Vector3();
           
        public void Start()
        {

            camera.Position = new Vector3(0, 2, 1);
            camera.Target = new Vector3(0.0f, 2.0f, 0.0f);
            camera.Up = new Vector3(0, 1, 0);
            camera.FovY = 60.0f;
            camera.Projection = CameraProjection.Perspective;

        }
        public void Run()
        {
            
            Raylib.DisableCursor();
            movementInput.y += Raylib.IsKeyDown(KeyboardKey.D);
            movementInput.y -= Raylib.IsKeyDown(KeyboardKey.A);
            movementInput.x -= Raylib.IsKeyDown(KeyboardKey.S);
            movementInput.x += Raylib.IsKeyDown(KeyboardKey.W);
            playerMovement.x = movementInput.x * Raylib.GetFrameTime();
            playerMovement.y = movementInput.y * Raylib.GetFrameTime() *0.02f;

            mouseInput = new Vector3(Raylib.GetMousePosition().X * Raylib.GetMouseDelta().X, Raylib.GetMousePosition().Y * Raylib.GetMouseDelta().Y, 0);
           
            Raylib.UpdateCameraPro(ref camera, playerMovement, mouseInput, 0);

            
            
            Raylib.BeginMode3D(camera);
            Raylib.DrawPlane(new Vector3(0.0f, 0.0f, 0.0f),new Vector2(32,32), Color.LightGray); // Draw ground
            Raylib.DrawCube(new Vector3 ( -16.0f, 2.5f, 0.0f ), 1.0f, 5.0f, 32.0f, Color.Blue);     // Draw a blue wall
            Raylib.DrawCube(new Vector3(16.0f, 2.5f, 0.0f), 1.0f, 5.0f, 32.0f, Color.Lime);      // Draw a green wall
            Raylib.DrawCube(new Vector3(0.0f, 2.5f, 16.0f), 32.0f, 5.0f, 1.0f, Color.Gold); // Draw a gold wall
            Raylib.DrawCube(new Vector3(0.0f, 2.5f, -16.0f), 32.0f, 5.0f, 1.0f, Color.Gold); // Oposite Gold wall
            Raylib.DrawCube(new Vector3(10,10,10),10, 10, 10, Color.Blue);

            Raylib.EndMode3D();
        }
        public void End()
        {

        }

   
    }
}
