using NUnit.Framework;

namespace SudokuApp1.Test
{
    public class ValidateSudokuTests
    {
        ValidateSudoku validate = new ValidateSudoku();

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void IsSudokuNumGreaterThanZero_ReturnsFalse()
        {

            int[][] sudokuWithZero = {
                new int[] {7,8,4,  1,5,9,  3,2,6},
                new int[] {5,3,9,  6,7,2,  8,4,1},
                new int[] {6,1,2,  4,3,8,  7,5,9},

                new int[] {9,2,8,  7,1,5,  4,6,3},
                new int[] {3,5,7,  8,0,6,  1,9,2},
                new int[] {4,6,1,  9,2,3,  5,8,7},

                new int[] {8,7,6,  3,9,4,  2,1,5},
                new int[] {2,4,3,  5,6,1,  9,7,8},
                new int[] {1,9,5,  2,8,7,  6,3,4}
            };


            var result1 = validate.IsSudokuNumGreaterThanZero(sudokuWithZero);
            Assert.That(result1, Is.EqualTo(false));
        }

        [Test]
        public void IsSudokuNumGreaterThanZero_ReturnsTrue()
        {

            int[][] sudokuWithOutZero = {
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

            var result1 = validate.IsSudokuNumGreaterThanZero(sudokuWithOutZero);
            Assert.That(result1, Is.EqualTo(true));

        }

        [Test]
        public void IsRowsColumnsEqual_ReturnsTrue()
        {
            int[][] sudoku1 = {
                new int[] {1,3,2,4},
                new int[] {4,2,1,3},
                new int[] {3,1,4,2},
                new int[] {2,4,3,1}
            };

            var result1 = validate.IsRowsColumnsEqual(sudoku1);
            Assert.That(result1, Is.EqualTo(true));
        }


        [Test]
        public void IsRowsColumnsEqual_ReturnsFalse()
        {
            int[][] sudoku1 = {
                new int[] {1,3,2,4},
                new int[] {4,2,1,3},
                new int[] {3,1,2},
                new int[] {4,2,1,3},
            };

            var result2 = validate.IsRowsColumnsEqual(sudoku1);
            Assert.That(result2, Is.EqualTo(false));
        }


        [Test]
        public void IsRowsColumnsEqual_ReturnsFalse1()
        {
            int[][] sudoku1 = {
                new int[] {1,3,2,4},
                new int[] {4,2,1,3},
                new int[] {3,1,2,4},
                new int[] {4,2,1,3},
                new int[] {3,1,2,4}
            };

            var result3 = validate.IsRowsColumnsEqual(sudoku1);
            Assert.That(result3, Is.EqualTo(false));

        }



        [Test]
        public void IsRowsDuplicate_ReturnsTrue()
        {
            int[][] sudoku1 =  {
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


            var result1 = validate.IsRowsDuplicate(sudoku1);
            Assert.That(result1, Is.EqualTo(true));

        }


        [Test]
        public void IsRowsDuplicate_ReturnsFalse()
        {
            int[][] sudoku1 = {
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

            var result1 = validate.IsRowsDuplicate(sudoku1);
            Assert.That(result1, Is.EqualTo(false));
        }



        [Test]
        public void IsColumnsDuplicate_ReturnTrue()
        {
            int[][] sudoku1 =  {
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


            var result1 = validate.IsColumnsDuplicate(sudoku1);
            Assert.That(result1, Is.EqualTo(true));

        }


        [Test]
        public void IsColumnsDuplicate_ReturnFalse()
        {
            int[][] sudoku1 = {
                new int[] {1,3,2,4},
                new int[] {4,2,1,3},
                new int[] {3,1,4,2},
                new int[] {2,4,3,1}
            };


            var result1 = validate.IsColumnsDuplicate(sudoku1);
            Assert.That(result1, Is.EqualTo(false));

        }

    }
}