using Raylib_cs;
using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace PersonalGameProject
{
    internal class Player
    {
        public Camera3D playerCamera = new Camera3D();
        Vector3 movementInput = new Vector3(0,0,0);
        Vector3 mouseInput = new Vector3(0, 0, 0);
        float playerSpeed = 5;
        float mouseSensitivity = .3f;
        public Model playerModel = new Model();
        Texture2D playerTexture = new Texture2D();
        Matrix4 position = new Matrix4();

       

        public void InitPlayer()
        {
            
            playerModel = Raylib.LoadModel(@"res\Knight.glb");
            playerTexture = Raylib.LoadTexture(@"res\knight_texture.png");
            Raylib.SetMaterialTexture(ref playerModel,0, MaterialMapIndex.Albedo, ref playerTexture);
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
           
            
            mouseInput.x = Raylib.GetMouseDelta().X * mouseSensitivity;
            mouseInput.y = Raylib.GetMouseDelta().Y * mouseSensitivity;

            Raylib.UpdateCameraPro(ref playerCamera, movementInput, mouseInput, 0);
        }
        public void Draw()
        {
           
        }

       
    }
}
