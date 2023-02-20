// 72. Показать натуральные числа от M до N, N и M заданы

void ShowRange(int M, int N )
{   
    System.Console.Write($"{M,4}");
    if (M<N) ShowRange(M+1,N);
    
}


ShowRange(7,30);