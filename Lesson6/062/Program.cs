// 62. В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j]). 
//Написать отдельную подпрограмму на вход которой подается массив, а на выходе измененный массив.



void PrintArray (int[,]arr) // Метод печати массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
         System.Console.Write($"{arr[i,j]} ");   
        }
        System.Console.WriteLine();
    }
}

void ChangDigits (int[,] arr)   // Метод замены четных элементов
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if(arr[i,j]%2==0)
        {
            arr[i,j]=-arr[i,j];
        }
        
    }
}

}

int[,] a= new int[3,4] //Инициировали массив
{   {1,2,3,4},
    {5,6,7,8},
    {9,10,11,12}
};

PrintArray(a);
System.Console.WriteLine();
ChangDigits(a);
PrintArray(a);