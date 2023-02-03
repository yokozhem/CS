// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//найти мак и мин числа

int N=1234;
int min=10, max=-1;
while(N!=0)
{
    int digit=N%10;
    if(digit>max) max=digit;
    if(digit<min) min=digit;
    N/=10;
}
System.Console.WriteLine($" min {min} & max {max}");