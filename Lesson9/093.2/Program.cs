// 93.2 В прямоугольной матрице найти строку с наименьшей суммой элементов.

int [,] Randome2DArray(int N, int M, int min, int max)
{
    int [,] a = new int [N,M];
    Random random = new Random();
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i,j]= random.Next(min,max+1);
        
        }   
        
    }
    return a;

}

void PrintArray(int [,]a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            System.Console.Write($"{a[i,j],5}");
        }
        System.Console.WriteLine();
    }
}

int FindMinRow(int[,]a)
{
    int minSum = int.MaxValue;
    int k = 0;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < a.GetLength(1); j++)
        {
            rowSum += a[i, j];
        }
        if (rowSum < minSum)
        {
            minSum = rowSum;
            k++;
        }
    }

    return k;
}

int [,] a = Randome2DArray(3,4,0,9);
PrintArray(a);
System.Console.WriteLine(FindMinRow(a));
