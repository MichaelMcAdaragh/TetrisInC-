using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisInC_
{
    // Block Struct
    public struct Block
    {
        public int x, y;

        public Block(int xCoordinate, int yCoordinate)
        {
            x = xCoordinate; y = yCoordinate;
        }
    }

    public class Tetramino      // Super Class of Tetraminos / Blank template for other pieces.
    {
        
        // Attributes
        public Block[] block = new Block[4]; // Create array of blocks to contain x,y coord's

        public int rotationState = 0;  // Rotation state starting at 12 o'clock


        // Methods
        public bool isValidMove(int coordinate, string direction)
        {
            bool inBounds = true;                                       // Defaults to true.

            if (direction == "left" && coordinate - 1 < 0)              // Check Left Bound
            {
                inBounds = false;                                           // Past Left Bound  
            }
            if (direction == "right" && coordinate + 1 > Game.Width)    // Check Right Bound
            {
                inBounds = false;                                           // Past Right Bound
            }
            if (direction == "down" && coordinate + 1 > Game.Height)    // Check Bottom Bound
            {
                inBounds = false;                                           // Past Bottom Bound.  
            }
            // If none of the checks were failed, inBounds is true and isValidMove is true.
            return inBounds;
        }

        public void Move(int[,] matrix, string direction)
        {
            int validCount;
            switch (direction)
            {
                case "left":

                    validCount = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (isValidMove(block[i].x, "left") == true)
                            validCount++;
                    }
                    if (validCount == 4)
                    {
                        for (int i = 0; i < 4; i++)       // for each point
                        {
                            matrix[block[i].x, block[i].y] = 0;       // turn off current point
                        }
                        for (int i = 0; i < 4; i++)       // for each point
                        {
                           block[i].x--;                       // decrement x coordinates.
                            matrix[block[i].x, block[i].y] = 1;       // turn on new points
                        }
                    }
                    Console.WriteLine($"{validCount}");
                    break;
                    
                case "right":

                    validCount = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (isValidMove(block[i].x, "right") == true)
                            validCount++;
                    }
                    if (validCount == 4)                  // if all four points are valid after move
                    {
                        for (int i = 0; i < 4; i++)       // for each point
                        {
                            matrix[block[i].x, block[i].y] = 0;       // turn off each current point
                        }
                        for (int i = 0; i < 4; i++)       // for each point
                        {
                            block[i].x++;                       // increment x coordinates.
                            matrix[block[i].x, block[i].y] = 1;       // turn on new points
                        }
                    }
                    Console.WriteLine($"{validCount}");
                    break;

                case "down":

                    validCount = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (isValidMove(block[i].y, "down") == true)
                            validCount++;
                        Console.WriteLine($"{validCount}");
                    }
                    if (validCount == 4)
                    {
                        for (int i = 0; i < 4; i++)       // for each point
                        {
                            matrix[block[i].x, block[i].y] = 0;       // turn off current point
                        }
                        for (int i = 0; i < 4; i++)       // for each point
                        {
                           block[i].y++;                       // decrement y coordinates.
                            matrix[block[i].x, block[i].y] = 1;       // turn on new points
                        }
                    }
                    Console.WriteLine($"{validCount}");
                    break;

                default:
                    throw new Exception("Move Method: Invalid Direction String.");
            }
        }
    }
}
