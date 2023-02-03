// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// 27. Найти расстояние между точками в пространстве 2D

double xa,xb,ya,yb, AB;
System.Console.WriteLine("Введите координаты первой точки");
xa=Convert.ToDouble(Console.ReadLine());
ya=Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите координаты второй точки");
xb=Convert.ToDouble(Console.ReadLine());
yb=Convert.ToDouble(Console.ReadLine());

AB=Math.Sqrt((Math.Pow((xb -xa) ,2))+ Math.Pow((yb-ya),2)); 
System.Console.WriteLine($"Расстояние ={AB}");