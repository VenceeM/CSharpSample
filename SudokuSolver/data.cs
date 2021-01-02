using System;

namespace SudokuSolver
{

    class Data
    {
        int[,] grid = new int[9, 9]
        {

            {4,9,0,1,5,7,0,0,0},
            {0,1,8,0,9,0,0,0,0},
            {7,5,0,2,8,4,1,0,6},
            {0,6,0,4,1,5,0,7,0},
            {1,0,0,7,0,0,4,0,0},
            {0,0,0,9,0,8,0,6,1},
            {0,0,7,5,0,0,0,1,3},
            {6,4,0,0,0,0,2,0,0},
            {5,0,1,0,7,0,0,8,0}

        };

        public void PrintGrid()
        {
            int row = grid.GetLength(0);
            int col = grid.GetLength(1);
            for(int x =0 ; x < row; x++)
            {
                for(int y= 0; y < col; y++)
                {
                    Console.Write(grid[x,y]);
                    Console.Write("-");
                }
                Console.Write(Environment.NewLine);
            }

            


        }

        public bool CheckIfPosible(int y, int x,int n)
        {
            for(int i =0; i < 9; i++)
            {
                if(grid[y,i] == n)
                {
                    return false;
                }
            }
            for(int i = 0; i < 9; i++)
            {
                if(grid[i,x] == n)
                {
                    return false;
                }
            }

            int xGrid = (x / 3) * 3;
            int yGrid = (y / 3) * 3;

            for(int i =0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(grid[yGrid + i,xGrid + j] == n)
                    {
                        return false;
                    }
            
                }
            }
            return true;
        }


        public void Solver()
        {
            for(int y =0 ; y < 9; y++)
            {
                for(int x = 0; x < 9 ; x++)
                {
                    if(grid[y,x] == 0)
                    {
                        for(int n =1; n < 10; n++)
                        {
                            if(CheckIfPosible(y,x,n))
                            {
                                grid[y,x]= n;
                                Solver();
                                grid[y,x] = 0;                            }
                        }return;
                    }
                }
            }
            PrintGrid();
        }


    }



}



