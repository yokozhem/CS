// 73. Найти сумму элементов от M до N, N и M заданы

int SumRang (int M, int N)
{   
   if(M==N) return M;
   else return M+SumRang(M+1,N);
    
}

System.Console.WriteLine(SumRang(5,10));
