using Raylib_cs;
using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalGameProject
{
    internal class Player
    {
        public Camera3D playerCamera = new Camera3D();
        Vector3 movementInput = new Vector3(0,0,0);
        Vector3 mouseInput = new Vector3(0, 0, 0);
        float playerSpeed = 5;
        float mouseSensitivity = .3f;
        bool jump = false;
        float jumpHeight = 4;
        

        public void InitCamera()
        {
            playerCamera.Position = new Vector3(0, 2, 1);
            playerCamera.Target = new Vector3(0.0f, 2.0f, 0.0f);
            playerCamera.Up = new Vector3(0, 1, 0);
            playerCamera.FovY = 100.0f;
            playerCamera.Projection = CameraProjection.Perspective;
        }
        
        public void Movement()
        {
            movementInput = new Vector3(0, 0, 0);
          
            
            if (Raylib.IsKeyDown(KeyboardKey.D) || Raylib.IsKeyDown(KeyboardKey.A) || Raylib.IsKeyDown(KeyboardKey.W) || Raylib.IsKeyDown(KeyboardKey.S))
            {
                movementInput.y += Raylib.IsKeyDown(KeyboardKey.D) * Raylib.GetFrameTime() * playerSpeed;
                movementInput.y -= Raylib.IsKeyDown(KeyboardKey.A) * Raylib.GetFrameTime() * playerSpeed;
                movementInput.x -= Raylib.IsKeyDown(KeyboardKey.S) * Raylib.GetFrameTime() * playerSpeed;
                movementInput.x += Raylib.IsKeyDown(KeyboardKey.W) * Raylib.GetFrameTime() * playerSpeed;
            }
            if (Raylib.IsKeyDown(KeyboardKey.LeftShift))
            {
                playerSpeed = 15;
            }
            else
            {
                playerSpeed = 6;
            }
            if (Raylib.IsKeyDown(KeyboardKey.Space) && jump == false)
            {
                movementInput.z = jumpHeight * Raylib.GetFrameTime();
            
            }
            mouseInput.x = Raylib.GetMouseDelta().X * mouseSensitivity;
            mouseInput.y = Raylib.GetMouseDelta().Y * mouseSensitivity;

            Raylib.UpdateCameraPro(ref playerCamera, movementInput, mouseInput, 0);
        }
        public void Draw()
        {
            Raylib.DrawCube(new Vector3 (2,2,1),10,10,10,Color.Blue);
        }


    }
}
