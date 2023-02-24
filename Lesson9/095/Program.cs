//95. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] a= new int[2,2,2];
int num=12;

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        for (int k = 0; k < a.GetLength(2); k++)
        {
            a[i,j,k]=num;
            num++;
            Console.Write("{0}({1},{2},{3})\t", a[i, j, k], i, j, k);
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

