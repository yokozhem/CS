// 45. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел


int[] a=new int[5];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(100,1000);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
int sp=0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i]%2==0)
    {
        sp= sp+a[i];
    }
    
}    
System.Console.WriteLine();
System.Console.WriteLine("-----------------------------");
System.Console.WriteLine($"Sum positive digits = {sp}");

int sn=0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i]%2!=0)
    {
        sn= sn+a[i];
    }
    
}    
System.Console.WriteLine("-----------------------------");
System.Console.WriteLine($"Sum negative digits = {sn}");