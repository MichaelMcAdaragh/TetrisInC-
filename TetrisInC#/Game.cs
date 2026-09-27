using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisInC_
{
    public class Game // "Tetrix" its a "Tetris Matrix"
    {
        // Game Attributes 
        private int _width, _height;

        // Properties
        public int Width { get; private set; }
        public int Height { get; private set; }
        
        // Constructors
        public Game()    // Default Standard New Game.
        {
            _width = 10;
            _height = 20;            
        }
        public Game(int width, int height)    // User Parameterized New Game.
        {
            _width = width;
            _height = height;
        }

        // Methods
        public int[,] CreateMatrix()                // Returns a new game matrix
        {
            var matrix = new int[_width, _height];
            return matrix;
        }

        public void DisplayMatrix(int[,] matrix)    // Displays Current Game Matrix On Terminal
        {
            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _width; j++)
                {
                    if (matrix[j, i] == 1)
                        Console.Write("[]");
                    else //if( matrix[j,i] == 0)
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
        
        // Check / Clear Completed Row
        // Score
        // Game Over
    }
}
