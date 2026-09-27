using TetrisInC_.Tetramino_Classes;

namespace TetrisInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();                  // Initialize game

            int[,] gameMatrix = game.NewMatrix();   // Create new game matrix
            var L = new L_Piece(gameMatrix);
            game.DisplayMatrix(gameMatrix);

            L.Move(gameMatrix, "left");
            game.DisplayMatrix(gameMatrix);
            
            L.Move(gameMatrix, "down");
            game.DisplayMatrix(gameMatrix);

            L.Move(gameMatrix, "right");
            game.DisplayMatrix(gameMatrix);
        }
    }
}
