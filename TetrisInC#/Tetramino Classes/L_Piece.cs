using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace TetrisInC_.Tetramino_Classes
{
    public class L_Piece : Tetramino
    {
        // L Tetramino



        //Constructor
        public L_Piece(int[,] matrix)
        {
            x[0] = 4; y[0] = 0;
            x[1] = 4; y[1] = 1;
            x[2] = 4; y[2] = 2;
            x[3] = 5; y[3] = 2;

            matrix[x[0], y[0]] = 1;
            matrix[x[1], y[1]] = 1;
            matrix[x[2], y[2]] = 1;
            matrix[x[3], y[3]] = 1;
        }

        // Inherits "Move Method" from Tetramino class
              
    }
}
