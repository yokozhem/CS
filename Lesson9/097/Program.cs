
int[,,] a= new int[3,3,3];
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