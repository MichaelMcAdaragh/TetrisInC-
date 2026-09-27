using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisInC_
{
    public class GameMatrix
    {
        // Attributes / Properties
        private int _width;
        public int Width { get; private set; }
        
        private int _height;
        public int Height { get; private set; }
        
        // Constructors
        GameMatrix()    // Default Standard New Game.
        {
            var Matrix = new int[10, 20];
        }
        GameMatrix(int width, int height)    // User Parameterized New Game.
        {
            _width = width;
            _height = height;
            var Matrix = new int[Width, Height];
        }

        // Methods
        public void DisplayMatrix()
        {
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height)
                {
                    Console.Write("[]");
                }
                Console.WriteLine();
            }
        }
    }
}
