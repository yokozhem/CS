// 78. С клавиатуры вводится число N. 
//Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1. 
//Использовать рекурсию.

void PrintFibonacci(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{Fibonacci(i),5}");
    }
}

int Fibonacci(int n)
{
    if (n == 0)
    {
        return 0;
    }
    else if (n == 1)
    {
        return 1;
    }
    else
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
System.Console.WriteLine("Сколько первых чисел Фибоначчи вам распечатать?  ");
int N=Convert.ToInt32(Console.ReadLine());
PrintFibonacci(N);