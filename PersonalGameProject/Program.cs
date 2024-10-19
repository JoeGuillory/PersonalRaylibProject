using Raylib_cs;
namespace PersonalGameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Raylib.InitWindow(1200, 800, "My game");
            game.Start();

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);


                game.Run();


                Raylib.EndDrawing();

            }


            Raylib.CloseWindow();

        }
    }
}
