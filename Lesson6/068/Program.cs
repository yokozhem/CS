//68. Написать программу, которая обменивает элементы первой строки и последней строки


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
void ChangeRows (int[,] arr) //Метод замены верхний и нижней строк
{
        for (int j = 0; j < arr.GetLength(1); j++)
            {
              int t=arr[0,j];
              arr[0,j]=arr[arr.GetLength(0)-1,j];
              arr[arr.GetLength(0)-1,j]=t;  
            }

}

int [,] a=new int[4,4];
FillArray(a);
PrintArray(a);
System.Console.WriteLine();
ChangeRows(a);
PrintArray(a);