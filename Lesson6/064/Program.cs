// 64.В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты по значению.

void PrintArray (double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i,j],5}");
        }
        System.Console.WriteLine();
    }
}

void SubstitutionEvenIndices (double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0)
            {
                arr[i,j]=Math.Pow(arr[i,j],2);
            }
        }
    }
}


double[,] a=new double[3,4]
{
    {1,2,3,4},
    {1,2,3,4},
    {1,2,3,4}
};

PrintArray(a);
System.Console.WriteLine();
SubstitutionEvenIndices(a);
PrintArray(a);

