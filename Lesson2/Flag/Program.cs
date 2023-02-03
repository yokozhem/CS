// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


int N=12304;
bool flag=false;
while(N!=0)
{
    int d=N%10;
    if(d==0)
     flag=true;
    N/=10;
}
if(flag)
System.Console.WriteLine("В числе есть 0");
else
System.Console.WriteLine("В числе нет 0");