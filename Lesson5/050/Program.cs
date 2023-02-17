// 50. Выяснить являются ли три числа сторонами треугольника


int a=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());
int c=int.Parse(Console.ReadLine());

Triangle();

void Triangle()
{
if(a+b>c && a+c>b && c+b>a)
{
    System.Console.WriteLine("Ваши числа являются сторонами треугольника");
}
else
{
    System.Console.WriteLine("Увы, но нет.");
}
}