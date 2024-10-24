using Raylib_cs;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using MathLibrary;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Security;


namespace PersonalGameProject
{
    internal  class Game
    {
        
        
        Player player = new Player();
        Model barrel = new Model();
        Texture2D barrelpng = new Texture2D();
        Texture2D colorpallet = new Texture2D();
        Model floor = new Model();
        

        public void Start()
        {
          
            Raylib.SetTargetFPS(144);
            Raylib.DisableCursor();
            player.InitCamera();

            floor = Raylib.LoadModel(@"res\Models\floor.obj");
            barrel = Raylib.LoadModel(@"res\Models\barrel.obj");
            colorpallet = Raylib.LoadTexture(@"res\Models\colormap.png");
            Console.WriteLine(floor.MaterialCount);

           Raylib.SetMaterialTexture(ref barrel, 0,MaterialMapIndex.Albedo, ref colorpallet);
           Raylib.SetMaterialTexture(ref floor, 0,MaterialMapIndex.Albedo, ref colorpallet);
            
            
            
            
            
        }
        public void Run()
        {
            
            
            

            player.Movement();
            Raylib.BeginMode3D(player.playerCamera);
            
            Raylib.DrawModel(floor, new Vector3(0.02f, 0.02f, 0), 2, Color.White);
            
            player.Draw();
            Raylib.DrawGrid(200, 1);
           
            
            

            Raylib.EndMode3D();
            
            
        }
        public void End()
        {

        }

   
    }
}
