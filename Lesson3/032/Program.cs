//32.Найти сумму чисел от 1 до А



int SumDigits(int n)
{
    int sum=0;
    for (int i = 1; i <= n; i++)
    {
        sum+=i;
    }
    return sum;
}
System.Console.WriteLine("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SumDigits(N));







// System.Console.WriteLine("Введите число: ");
// int n=Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i <= n; i++)
// {
//     sum += i;
// }

// System.Console.WriteLine(sum);