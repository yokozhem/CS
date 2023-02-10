//53. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы


double k1,k2,b1,b2;
System.Console.Write("Введите значение k1: ");
k1=double.Parse(Console.ReadLine());
System.Console.Write("Введите значение b1: ");
b1=double.Parse(Console.ReadLine());
System.Console.Write("Введите значение k2: ");
k2=double.Parse(Console.ReadLine());
System.Console.Write("Введите значение b2: ");
b2=double.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;


System.Console.WriteLine($"Точка пересеычения прямых имеет координаты {x} {y}");

