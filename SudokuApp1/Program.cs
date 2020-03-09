using System;
using System.Diagnostics;

namespace SudokuApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            int[][] goodSudoku1 = {
                new int[] {7,8,4,  1,5,9,  3,2,6},
                new int[] {5,3,9,  6,7,2,  8,4,1},
                new int[] {6,1,2,  4,3,8,  7,5,9},

                new int[] {9,2,8,  7,1,5,  4,6,3},
                new int[] {3,5,7,  8,4,6,  1,9,2},
                new int[] {4,6,1,  9,2,3,  5,8,7},

                new int[] {8,7,6,  3,9,4,  2,1,5},
                new int[] {2,4,3,  5,6,1,  9,7,8},
                new int[] {1,9,5,  2,8,7,  6,3,4}
            };


            int[][] goodSudoku2 = {
                new int[] {1,3,2,4},
                new int[] {4,2,1,3},
                new int[] {3,1,4,2},
                new int[] {2,4,3,1}
            };

            
            int[][] badSudoku1 =  {
                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9},

                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9},

                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9}
            };

            int[][] badSudoku2 = {
                new int[] {1,2,3,4,5},
                new int[] {1,2,3,4},
                new int[] {1,2,3,4},
                new int[] {1}
            };

            int[][] badSudoku3 = {
                new int[] {7,8,4,  0,5,1,  3,2,6},
                new int[] {5,3,1,  6,7,2,  8,4,0},
                new int[] {6,0,2,  4,3,8,  7,5,1},

                new int[] {1,2,8,  7,0,5,  4,6,3},
                new int[] {3,5,7,  8,4,6,  0,1,2},
                new int[] {4,6,0,  1,2,3,  5,8,7},

                new int[] {8,7,6,  3,1,4,  2,0,5},
                new int[] {2,4,3,  5,6,0,  1,7,8},
                new int[] {0,1,5,  2,8,7,  6,3,4}
            };
            int[][] badSudoku4 =  {
                new int[] {1,1,1, 1,1,1, 1,1,1},
                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9},

                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9},

                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9},
                new int[] {1,2,3, 4,5,6, 7,8,9}
            };

          
            int[][] badSudoku5 = {    
                new int[] {1, 2, 3},
                new int[] {5, 0, 8},

                new int[] {4, 1, 7}
            };

            ValidateSudoku validate = new ValidateSudoku();

           
            var isSudokuZero = validate.IsSudokuNumGreaterThanZero(goodSudoku2);
            Console.WriteLine($"Sudoku Numbers are Greater Than Zero: {isSudokuZero}");

            
            var rowColEqual = validate.IsRowsColumnsEqual(goodSudoku2);
            Console.WriteLine($"Rows and columns of Sudoku has equal length: {rowColEqual}");

          
            var rowValid = validate.IsRowsDuplicate(goodSudoku2);
            Console.WriteLine($"Rows are duplicate: {rowValid}");

           
            var colValid = validate.IsColumnsDuplicate(goodSudoku2);
            Console.WriteLine($"Columns are duplicate: {colValid} \n");
           

            var final = validate.FinalValidate(goodSudoku2);
            Console.WriteLine($"It's a good sudoku!: { final}");
            
        }

    }

}
