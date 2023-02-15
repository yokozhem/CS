//68a.  68A: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/* Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

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

int SumMinRow (int[,] arr)
{
    int minSum=int.MaxValue;
    int minRow=0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum=0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum=sum+arr[i,j];
             
            if (sum<minSum)
            {
                minSum=sum;
                minRow=i;
            }
        }
        
    }
    return minRow;
}



int [,] a=new int[4,4];
FillArray(a);
PrintArray(a);
System.Console.WriteLine($"Наименьшая сумма элементов в строке: {SumMinRow(a)}");


