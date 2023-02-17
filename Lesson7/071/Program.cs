// 71. Показать натуральные числа от N до 1, N задано

void CountRevers(int N, int i)
{   
    System.Console.Write($"{N,4}");
    if (i<N) CountRevers(N-1,i);
    
}


CountRevers(10,1);