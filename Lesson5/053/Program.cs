//53. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы


//double k1,k2,b1,b2;
System.Console.Write("Введите значение k1: ");
double k1=double.Parse(Console.ReadLine());
System.Console.Write("Введите значение b1: ");
double b1=double.Parse(Console.ReadLine());
System.Console.Write("Введите значение k2: ");
double k2=double.Parse(Console.ReadLine());
System.Console.Write("Введите значение b2: ");
double b2=double.Parse(Console.ReadLine());

// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;
//System.Console.WriteLine($"Точка пересечения прямых имеет координаты {x} {y}");

System.Console.WriteLine("Точка пересечения прямых имеет координаты  " + IntersectionPointX(k1,k2,b1,b2)+ " , " +IntersectionPointY(k1,k2,b1,b2));

double IntersectionPointX(double k1,double k2, double b1, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}

double IntersectionPointY(double k1,double k2, double b1, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return y;
}
