using Raylib_cs;
namespace PersonalGameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Raylib.InitWindow(800, 400, "My game");
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
