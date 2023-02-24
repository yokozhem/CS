// 99. Спирально заполнить двумерный массив:
//  1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7 

int n = 4;
int[,] matrix = new int[n, n];

int num = 1;
int startRow = 0, endRow = n - 1;
int startCol = 0, endCol = n - 1;

while (num <= n * n)
{
    // заполнение верхней строки
    for (int i = startCol; i <= endCol; i++)
        matrix[startRow, i] = num++;

    // заполнение правого столбца
    for (int i = startRow + 1; i <= endRow; i++)
        matrix[i, endCol] = num++;

    // заполнение нижней строки
    for (int i = endCol - 1; i >= startCol; i--)
        matrix[endRow, i] = num++;

    // заполнение левого столбца
    for (int i = endRow - 1; i >= startRow + 1; i--)
        matrix[i, startCol] = num++;

    // сужение границ
    startRow++; endRow--;
    startCol++; endCol--;
}

// вывод матрицы на консоль
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
