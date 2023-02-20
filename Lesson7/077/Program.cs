// 77. Написать программу показывающие первые N для которых каждое следующее число 
//равно сумме двух предыдущих. Первые два элемента последовательности 0 и 1 

int Fib(int N)
{
    if (N==0) return 0;
        else
            if (N==1) return 1;
                else
                    return Fib(N-1)+Fib(N-2);
}

void PrintFib(int N)
{
    for (int i = 0; i < N; i++)
        {
        Console.Write($"{Fib(i),5}");   
        }
}

PrintFib(6);
