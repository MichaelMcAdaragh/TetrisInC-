namespace TetrisInC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            int[,] gameMatrix = game.CreateMatrix();
            game.DisplayMatrix(gameMatrix);

        }
    }
}
