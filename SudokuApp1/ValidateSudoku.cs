using System;
using System.Collections.Generic;

namespace SudokuApp1
{
    public class ValidateSudoku
    {
        //Sudoku numbers > 0
        public bool IsSudokuNumGreaterThanZero(int[][] sudoku)
        {
            for (int i = 0; i < sudoku.Length; i++)
            {
                for (int j = 0; j < sudoku[i].Length; j++)
                {
                    if (sudoku[i][j] <= 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        // NxN
        public bool IsRowsColumnsEqual(int[][] sudoku)
        {
            for (int i = 0; i < sudoku.Length; i++)
            {
                if (sudoku.Length != sudoku[i].Length)
                {
                    return false;
                }
            }
            return true;
        }



        public bool IsRowsDuplicate(int[][] sudoku)
        {
            for (int i = 0; i < sudoku.Length; i++)
            {
                for (int j = 0; j < sudoku[i].Length; j++)
                {
                    for (int k = j + 1; k < sudoku[i].Length; k++)
                    {
                        if (sudoku[i][j] == sudoku[i][k])
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }



        public bool IsColumnsDuplicate(int[][] sudoku)
        {

            for (int i = 0; i < sudoku.Length; i++)
            {
                for (int j = 0; j < sudoku[i].Length - 1; j++)
                {
                    for (int k = j + 1; k < sudoku[i].Length; k++)
                    {
                        if (sudoku[j][i] == sudoku[k][i])
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

       
        public bool FinalValidate(int[][] sudoku)
        {
            if (IsRowsDuplicate(sudoku) == true)
                return false;

            if (IsColumnsDuplicate(sudoku) == true)
                return false;

            if (IsRowsColumnsEqual(sudoku) == false)
                return false;

            if (IsSudokuNumGreaterThanZero(sudoku) == false)
                return false;

            return true;
        }
    }
}
