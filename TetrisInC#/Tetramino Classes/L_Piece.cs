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
            block[0].x = 4; block[0].y = 0;
            block[1].x = 4; block[1].y = 1;
            block[2].x = 4; block[2].y = 2;
            block[3].x = 5; block[3].y = 2;

            matrix[block[0].x, block[0].y] = 1;
            matrix[block[1].x, block[1].y] = 1;
            matrix[block[2].x, block[2].y] = 1;
            matrix[block[3].x, block[3].y] = 1;
        }

        // Inherits "Move Method" from Tetramino class
        
        // Rotate
    }
}
