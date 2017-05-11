using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise2;

namespace MatrixTransformerTests
{
    [TestClass]
    public class MatrixTransformerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NonSquareMatrix()
        {
            //arrange
            int[,] matrix = new int[2, 3]
            {
                { 0, 1, 0},
                { 1, 1, 0}
            };
            MatrixTransformer matrixTransformer = new MatrixTransformer();

            //act
            matrixTransformer.MatrixCalculate(matrix);

        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Matrix2x2()
        {
            //arrange
            int[,] matrix = new int[2, 2]
            {
                { 0, 1},
                { 1, 1}
            };
            MatrixTransformer matrixTransformer = new MatrixTransformer();

            //act
            matrixTransformer.MatrixCalculate(matrix);

        }

        [TestMethod]
        public void Matrix3x3()
        {
            //arrange
            int[,] matrix = new int[3, 3]
            {
                { 0, 1, 2 },
                { 1, 1, 2 },
                { 2, 2, 2 }
            };

            int[,] resultMatrix = new int[2, 2]
            {
                {1, 2},
                {2, 1}
            };

            //act
            MatrixTransformer matrixTransformer = new MatrixTransformer();

            //assert
            CollectionAssert.AreEqual(matrixTransformer.MatrixCalculate(matrix), resultMatrix);
        }


        [TestMethod]
        public void Matrix4x4()
        {
            //arrange
            int[,] matrix = new int[4, 4]
            {
                { 0, 1, 2, 3},
                { 1, 1, 2, 3},
                { 2, 2, 2, 3},
                { 3, 3, 3, 3}
            };

            int[,] resultMatrix = new int[2, 2]
            {
                {3, 6},
                {6, 3}
            };

            //act
            MatrixTransformer matrixTransformer = new MatrixTransformer();

            //assert
            CollectionAssert.AreEqual(matrixTransformer.MatrixCalculate(matrix), resultMatrix);
        }


        [TestMethod]
        public void Matrix5x5()
        {
            //arrange
            int[,] matrix = new int[5, 5]
            {
                { 0, 1, 2, 3, 4 },
                { 1, 1, 2, 3, 4 },
                { 2, 2, 2, 3, 4 },
                { 3, 3, 3, 3, 4 },
                { 4, 4, 4, 4, 4 }
            };

            int[,] resultMatrix = new int[2, 2]
            {
                {8, 15},
                {15, 8}
            };

            //act
            MatrixTransformer matrixTransformer = new MatrixTransformer();

            //assert
            CollectionAssert.AreEqual(matrixTransformer.MatrixCalculate(matrix), resultMatrix);
        }

        [TestMethod]
        public void Matrix6x6()
        {
            //arrange
            int[,] matrix = new int[6, 6]
            {
                { 0, 1, 2, 3, 4, 5 },
                { 1, 1, 2, 3, 4, 5 },
                { 2, 2, 2, 3, 4, 5 },
                { 3, 3, 3, 3, 4, 5 },
                { 4, 4, 4, 4, 4, 5 },
                { 5, 5, 5, 5, 5, 5 }
            };

            int[,] resultMatrix = new int[2, 2]
            {
                {15, 28},
                {28, 15}
            };

            //act
            MatrixTransformer matrixTransformer = new MatrixTransformer();

            //assert
            CollectionAssert.AreEqual(matrixTransformer.MatrixCalculate(matrix), resultMatrix);
        }

        [TestMethod]
        public void Matrix3x3RandomValues()
        {
            //arrange
            int[,] matrix = new int[3, 3]
            {
                {9,3,1},
                {1,5,0},
                {7,2,6}
            };

            int[,] resultMatrix = new int[2, 2]
            {
                {3, 0},
                {2, 1}
            };

            //act
            MatrixTransformer matrixTransformer = new MatrixTransformer();

            //assert
            CollectionAssert.AreEqual(matrixTransformer.MatrixCalculate(matrix), resultMatrix);
        }
    }
}
