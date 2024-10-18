using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace PersonalGameProject
{
    internal class Game
    {
        public void Run()
        {
            Raylib.InitWindow(Raylib.GetScreenWidth(), Raylib.GetScreenHeight(), "Hello World");
            Vector2 deltaPosition = new Vector2(0, 0);
            Vector2 position = new Vector2();
            Raylib.SetTargetFPS(60);

            while (!Raylib.WindowShouldClose())
            {

                float deltatime = Raylib.GetFrameTime();
                int speed = 1000;
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);
                Raylib.DrawRectangle((int)position.X, (int)position.Y, 80, 80, Color.SkyBlue);
                Rectangle bullet = new Rectangle(position.X, position.Y, 10, 10);


                int up = Raylib.IsKeyDown(KeyboardKey.W);
                int down = Raylib.IsKeyDown(KeyboardKey.S);
                int left = Raylib.IsKeyDown(KeyboardKey.A);
                int right = Raylib.IsKeyDown(KeyboardKey.D);



                deltaPosition.Y -= up;
                deltaPosition.Y += down;
                deltaPosition.X -= left;
                deltaPosition.X += right;
                if (Raylib.IsKeyDown(KeyboardKey.Space))
                {
                    Raylib.DrawRectangleRec(bullet, Color.Black);


                }

                position.X = deltaPosition.X * deltatime * speed;

                position.Y = deltaPosition.Y * deltatime * speed;








                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();

        }


   
    }
}
