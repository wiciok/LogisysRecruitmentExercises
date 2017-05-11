using System;

namespace Exercise2
{
    public class MatrixTransformer
    {
        /** Method returns new 2x2 matrix
         *  calculated using input matrix NxN, N>2 
         *  to match pattern given as exercise requirement
         * */

        public int[,] MatrixCalculate(int[,] sourceMatrix)
        {
            /* check argument */
            if (sourceMatrix.GetLength(0) != sourceMatrix.GetLength(1))
                throw new ArgumentException("Matrix is not square!");

            int sourceMatrixSize = sourceMatrix.GetLength(0);
            if (sourceMatrixSize <= 2)
                throw new ArgumentOutOfRangeException(nameof(sourceMatrix), "Too small size of source matrix!");


            /* calculate green/orange section height and yellow/blue section width */
            int sectionSmallerDimensionWidth;
            if (sourceMatrixSize % 2 == 0)
                sectionSmallerDimensionWidth = sourceMatrixSize / 2 - 1;
            else
                sectionSmallerDimensionWidth = sourceMatrixSize / 2;


            int tmpSum;
            int offset;
            var resultMatrix = new int[2, 2];



            /* calculate sum of all elements in each section and assign it to resultMatrix */

            /* green section */

            tmpSum = 0;
            offset = 1;

            // outer loop - iterates over rows, inner loop - iterates over columns
            for (int i = 0; i < sectionSmallerDimensionWidth; i++)
            {
                for (int j = offset; j < sourceMatrixSize - offset; j++)
                    tmpSum += sourceMatrix[i, j];
                offset++;
            }
            resultMatrix[0, 0] = tmpSum;


            /* blue section */

            tmpSum = 0;
            offset = 1;

            // outer loop - iterates over columns, inner loop - iterates over rows
            for (int j = sourceMatrixSize - 1; j > sourceMatrixSize - 1 - sectionSmallerDimensionWidth; j--)
            {
                for (int i = offset; i < sourceMatrixSize - offset; i++)
                    tmpSum += sourceMatrix[i, j];
                offset++;
            }
            resultMatrix[0, 1] = tmpSum;


            /* orange section */

            tmpSum = 0;
            offset = 1;

            // outer loop - iterates over rows, inner loop - iterates over columns
            for (int i = sourceMatrixSize - 1; i > sourceMatrixSize - 1 - sectionSmallerDimensionWidth; i--)
            {
                for (int j = offset; j < sourceMatrixSize - offset; j++)
                    tmpSum += sourceMatrix[i, j];
                offset++;
            }
            resultMatrix[1, 0] = tmpSum;


            /* yellow section */

            tmpSum = 0;
            offset = 1;

            // outer loop - iterates over columns, inner loop - iterates over rows
            for (int j = 0; j < sectionSmallerDimensionWidth; j++)
            {
                for (int i = offset; i < sourceMatrixSize - offset; i++)
                    tmpSum += sourceMatrix[i, j];
                offset++;
            }
            resultMatrix[1, 1] = tmpSum;


            return resultMatrix;
        }
    }
}
