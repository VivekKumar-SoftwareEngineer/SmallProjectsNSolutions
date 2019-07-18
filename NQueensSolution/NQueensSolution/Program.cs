using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueensSolution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int size;
            Console.Write("Enter matrix size: ");
            size = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[size, size];
            NQueensSolver solve = new NQueensSolver();
            solve.SolveNQueens(matrix, size);
        }
    }
}
