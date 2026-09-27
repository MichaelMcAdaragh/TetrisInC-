using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisInC_
{
    public class Game // "Tetrix" its a "Tetris Matrix"
    {
        // Game Attributes 
        private static int _width, _height;

        // Properties - "static" makes these class properties that can be accesses via "Game.X"
        public static int Width
        {
            get { return _width; }
            private set { _width = value; }
        }
        public static int Height
        {
            get { return _height; }
            private set { _height = value; }
        }
        
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
        public int[,] NewMatrix()                // Returns a new game matrix
        {
            var matrix = new int[_width, _height];
            return matrix;
        }

        public void DisplayMatrix(int[,] matrix)    // Displays Current Game Matrix On Terminal
        {
            Console.WriteLine("\n\n\n----SCORE: 00000------");
            Console.WriteLine("----------------------");
            for (int i = 0; i < _height; i++)
            {
                Console.Write("|");
                for (int j = 0; j < _width; j++)
                {
                    if (matrix[j, i] == 1)
                        Console.Write("[]");
                    else //if( matrix[j,i] == 0)
                        Console.Write("  ");
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("----------------------");
        }
        
        // Check / Clear Completed Row
        // Score
        // Game Over
    }
}
