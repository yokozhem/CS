// 65. Написать подпрограмму, поиска элемента в двумерном массиве, подпрограмма возвращает позицию числа. 
//Если элемент отсутствует, подпрограмма возвращает false, а если найдет, то true.


Random random = new Random(); 

void  PrintArray(int[,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($" {matr[i,j]} ");
        }
        System.Console.WriteLine();
    }

}

void FillArray(int[,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i,j]=new Random().Next(1,10); // [1;10)
    }
}   
}

bool FindNumber (int [,] matr, int number, out int x, out int y)
{
    x=-1;
    y=-1;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j]==number)
            {
                x=i;
                y=j;
                return true;
            }
        }
    }
    return false;
}

int[,] matrix=new int[3,4];
FillArray(matrix);
PrintArray(matrix);
int r,c;
if (FindNumber(matrix,10,out r,out c))
  System.Console.WriteLine($"row={r} column={c}");
else
  System.Console.WriteLine("Element not found");
