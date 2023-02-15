// 67. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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
void MeanColumn (int[,] arr) //метод нахождения и вывода среднего значения в столбце
{
    
    double mean=0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum=0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum+=arr[i,j];
        }
         mean= sum/arr.GetLength(0);
        System.Console.WriteLine($"Mean of column {j}: {mean}");
    }
    
    
}

int [,] a=new int[4,4];
FillArray(a);
PrintArray(a);
System.Console.WriteLine();
MeanColumn(a);


