//69. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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

void SortRowtArray(int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
        {
            
            int[] row = new int[arr.GetLength(1)]; //Копируем строку в одномерный массив
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                row[j] = arr[i, j];
            }
            Array.Sort(row); //Делаем сортировку встроенным методом

            for (int j = 0; j < arr.GetLength(1); j++)// подменяем одномерным массивом строку в двумерном
            {
                arr[i, j] = row[j];
            }
        }
}

int [,] a=new int[4,4];
FillArray(a);
PrintArray(a);
System.Console.WriteLine();
SortRowtArray(a);
PrintArray(a);