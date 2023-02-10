// 50. Выяснить являются ли три числа сторонами треугольника

int a,b,c;
a=int.Parse(Console.ReadLine());
b=int.Parse(Console.ReadLine());
c=int.Parse(Console.ReadLine());
    if(a+b>c && a+c>b && c+b>a)
{
    System.Console.WriteLine("Ваши числа являются сторонами треугольника");
}
else
{
    System.Console.WriteLine("Увы, но нет.");
}