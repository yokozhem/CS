//66. Написать подпрограмму, которая в квадратной матрице чисел находит сумму элементов главной диагонали

void PrintArray(int[,] arr) // Метод вывода массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i,j],6}");
        }
        System.Console.WriteLine();
    }
}
Random random= new Random(); // Инициировали метод рандом, для последующего использования в заполнении матрицы

void FillArray(int[,] arr) // Метод наполнения массива случайными числами от 0 до 10
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = random.Next(0,10);
        }
    }
}

int SumDiagonal (int[,]arr)
{
    int s=0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        s+=arr[i,i];
    }
    return s;

}

int[,] a= new int[4,4];

FillArray(a);
PrintArray(a);
System.Console.WriteLine();
System.Console.WriteLine(SumDiagonal(a));

