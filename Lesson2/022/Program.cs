// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//По двум заданным числам проверять является ли одно квадратом другого.

int a=3, b=9;
if(Math.Pow(a,2)==b || Math.Pow(b,2)==a)
{
    System.Console.WriteLine("Одно число является квадратом другого");
}
else
{
    System.Console.WriteLine("Ни одно из чисел не является квадратом другого");
}