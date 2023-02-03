// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


int N=1234;
int countert=0;// счетчик
int sum=0;// сумматор
while(N!=0)
{
    countert++;
    int d=N%10;
    sum=sum+d;
    //sum+=d
    N=N/10;
    //N/=10

}
System.Console.WriteLine(countert);
System.Console.WriteLine(sum);
