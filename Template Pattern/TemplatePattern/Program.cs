using TemplatePattern.GameTemplate;

namespace TemplatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We have Game as the template which works for both Ludo and Chess

            //initiating a chess game
            var chessGame = new Chess();
            chessGame.Run();

            var ludoGame = new Ludo();
            ludoGame.Run(); 
        }
    }
}