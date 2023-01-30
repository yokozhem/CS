// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// 21. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int day=7;
if(day==6 || day==7)
{
    System.Console.WriteLine("Выходной");
}
else
if(day>=1 && day<=5)System.Console.WriteLine("Рабочий день");
    else
        System.Console.WriteLine("Нет такого дня недели");