using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueensSolution
{
    internal class NQueensSolver
    {
        internal void SolveNQueens(int[,] matrix, int size)
        {
            SolveNQueens(matrix, 0, size);
            Console.Read();
        }

        private void SolveNQueens(int[,] matrix, int col, int size)
        {
            if(col >= size)
            {
                PrintMatrix(matrix, size);
            }
            else
            {
                for(int row = 0; row < size; row++)
                {
                    if(IsQueenSafe(matrix, row, col, size))
                    {
                        matrix[row, col] = 1;

                        SolveNQueens(matrix, col + 1, size);

                        matrix[row, col] = 0;
                    }
                }
            }
        }

        private bool IsQueenSafe(int[,] matrix, int row, int col, int size)
        {
            for(int i=0;i<size;i++)
            {
                if (matrix[i, col] == 1)
                    return false;
            }
            for(int i=0;i<size;i++)
            {
                if (matrix[row, i] == 1)
                    return false;
            }
            for(int i=row, j= col;i>=0 && j>=0;i--,j--)
            {
                if (matrix[i, j] == 1)
                    return false;
            }
            for(int i=row,j=col;i<size && j>=0;i++,j--)
            {
                if (matrix[i, j] == 1)
                    return false;
            }

            return true;
        }

        private void PrintMatrix(int[,] matrix, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for(int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
