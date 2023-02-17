// 70. Показать натуральные числа от 1 до N, N задано

void CountingNumbers(int i, int N)
{   
    System.Console.Write($"{i,4}");
    if (i<N) CountingNumbers(i+1,N);
    
}


CountingNumbers(1,10);