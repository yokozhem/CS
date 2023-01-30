// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//24.Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int x=-5;
int y=6;
if(x>0 & y>0) System.Console.WriteLine("Точка находится в I четверти");
if(x<0 & y>0) System.Console.WriteLine("Точка находится во II четверти");
if(x<0 & y<0) System.Console.WriteLine("Точка находится в III четверти");
if(x>0 & y<0) System.Console.WriteLine("Точка находится в IV четверти");