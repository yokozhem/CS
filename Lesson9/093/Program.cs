//93: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

        int[,] matrixA = {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4},
            {5, 2, 6, 7}
        };

        int[,] matrixB = {
            {1, 5, 8, 5},
            {4, 9, 4, 2},
            {7, 2, 2, 6},
            {2, 3, 4, 7}
        };

        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int rowsB = matrixB.GetLength(0);
        int colsB = matrixB.GetLength(1);

        if (colsA != rowsB) {
            Console.WriteLine("Невозможно выполнить умножение матриц: количество столбцов первой матрицы не равно количеству строк второй матрицы.");
            return;
        }

        int[,] product = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++) {
            for (int j = 0; j < colsB; j++) {
                int sum = 0;
                for (int k = 0; k < colsA; k++) {
                    sum += matrixA[i, k] * matrixB[k, j];
                }
                product[i, j] = sum;
            }
        }

        Console.WriteLine("Произведение матриц:");
        PrintMatrix(product);
    

     void PrintMatrix(int[,] matrix) {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

