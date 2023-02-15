// 61.Показать двумерный массив размером m×n заполненный вещественными случайными числами
double[,] array= new double[3,4];
Random random = new Random();

void PrintArray(double[,] arr)
{
 for (int i = 0; i <arr.GetLength(0); i++)
 {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        System.Console.Write($"{arr[i,j], 6:F3}");
    }
    System.Console.WriteLine();
 }
}

void FillArray(double[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j]=new Random().NextDouble();
    }
   }
}

FillArray(array);
PrintArray(array);