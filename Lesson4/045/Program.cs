// 45. Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечетных\четных чисел


int[] a=new int[5];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(100,1000);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");
int sp=0;
 int countEven=0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i]%2==0)
    {
        sp= sp+a[i];
        countEven++;
    }
    
}    
System.Console.WriteLine();
System.Console.WriteLine("-----------------------------");
System.Console.WriteLine($"Sum even digits = {sp}");
System.Console.WriteLine($"Nubmer even digits = {countEven}");

int sn=0;
int countOdd=0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i]%2!=0)
    {
        sn= sn+a[i];
        countOdd++;
    }
    
}    
System.Console.WriteLine("-----------------------------");
System.Console.WriteLine($"Sum odd digits = {sn}");
System.Console.WriteLine($"Number odd digits = {countOdd}");

