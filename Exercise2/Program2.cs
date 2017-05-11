using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        public static void printMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] matrix = new int[5,5]{{0,1,2,3,4},{1,1,2,3,4},{2,2,2,3,4},{3,3,3,3,4},{4,4,4,4,4}};

            printMatrix(matrix);

            MatrixTransformer tmp = new MatrixTransformer();
            var retMatrix = tmp.MatrixCalculate(matrix);
            printMatrix(retMatrix);

            Console.ReadKey();
        }
    }
}
