using System;
using System.Collections.Generic;

namespace SudokuApp1
{
    public class ValidateSudoku
    {

        public bool IsSudokuNumGreaterThanZeroLessThanNine(int[][] sudoku)
        {
            for (int i = 0; i < sudoku.Length; i++)
            {
                for (int j = 0; j < sudoku[i].Length; j++)
                {
                    if (sudoku[i][j] <= 0)
                    {
                        return false;
                    }
                    else if (sudoku[i][j] > 9)
                    {
                        return false;
                    }
                }
            }
            return true;
        }




        /*
        
        public bool IsRowsAreDuplicate(int[][] sudoku)              //Checks for duplicate rows
        {
           
            for (int i = 0; i < sudoku.Length; i++)
            {
                for (int j = 0; j < sudoku.Length-1; j++)
                {
                    if (sudoku[i][j] == sudoku[i][j+1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        
          
        public bool IsColumnsDuplicate(int[][] sudoku)           //Checks for duplicate columns
        {
            if (IsRowsColumnsEqual(sudoku) == false || sudoku.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < (sudoku.Length-1); i++)
            {
                for (int j = 0; j < sudoku.Length; j++)
                {
                    if (sudoku[i][j] == sudoku[i+1][j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        

        public bool IsRowsColumnsEqual(int[][] sudoku)               // NxN
        {
            int rows = sudoku.Length;
            int cols;

            for (int i = 0; i < sudoku.Length; i++)
            {
                cols = sudoku[i].Length;
            }

           

            for (int i = 0; i < sudoku.Length; i++)
            {
                cols = sudoku[i].Length;

                if (rows != cols)
                {
                    return false;
                }
               
            }
            return true;
        }


        public bool FinalValidate(int[][] sudoku)
        {
            if (IsColumnsDuplicate(sudoku) == false || IsRowsDuplicate(sudoku) == false || IsRowsColumnsEqual(sudoku) == false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        */

    }

}
