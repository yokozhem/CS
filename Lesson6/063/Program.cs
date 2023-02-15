//63. Создать подпрограмму Create2DArray(m,n), которая возвращает двумерный массив следующим правилом: 
//Aij = i+j, где i и j - индексы элементов массива, а m и n - размеры массива




void PrintArray (int[,]arr)
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

void CreationArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j]=i+j;
        }
    }
}

int[,] a= new int [10,10];
CreationArray(a);
PrintArray(a);