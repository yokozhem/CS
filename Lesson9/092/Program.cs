// 92. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
//что это невозможно (в случае, если матрица не квадратная).
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


int [,] a = Randome2DArray(4,4,0,9);

int rows = a.GetLength(0);
int cols = a.GetLength(1);
int[,] b = new int[cols, rows];
if (a.GetLength(0)!=a.GetLength(1))
    {       
        System.Console.WriteLine("Задан не квадратный массив");
    }
    else
    {
        for (int i = 0; i < rows; i++) 
        {
            for (int j = 0; j < cols; j++) 
            {
                    b[j, i] = a[i, j];
            }
        }
    }

PrintArray(a);
System.Console.WriteLine();
PrintArray(b);