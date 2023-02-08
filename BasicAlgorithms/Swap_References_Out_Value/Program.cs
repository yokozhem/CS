

// void Swap(int x, int y)// передача по значению value
// {
//     int t=x;
//     x=y;
//     y=t;
// }

void Swap(ref int x, ref int y)// передача по ссылке reference
{
    int t=x;
    x=y;
    y=t;
}

void Calculator (int a, int b,  out int sum, out int sub) //ссылочный модификатор который возвращает

{
    sum= a+b;
    sub = a - b;
}
int a=4; 
int b=5;
int s, sb;

Calculator(a,b, out s, out sb);
System.Console.WriteLine($"a={a} b={b}");

// int t=a;
// a=b;
// b=t;


// a=a+b;
// b=a-b;
// a=a-b;

Swap(ref a,ref b);
System.Console.WriteLine($"a={a} b={b}");



