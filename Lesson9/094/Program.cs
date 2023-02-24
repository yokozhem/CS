// 93. Составить частотный словарь элементов двумерного массива состоящих из чисел от 0 до 99.

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

int [,] a = Randome2DArray(10,15,0,100);
PrintArray(a);

Dictionary<int, int> dic=new Dictionary<int, int>();
foreach(int el in a)
  if (dic.ContainsKey(el))
     dic[el]++;
   else
     dic.Add(el,1);
foreach(var el in dic)
  System.Console.WriteLine($"{el.Key} встречается {el.Value} раз(а)");