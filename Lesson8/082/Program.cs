// 82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки
System.Console.WriteLine("Введите текст с разделением точкой");
string input=Console.ReadLine();
int index = input.IndexOf(".");


if (index == -1) {
            Console.WriteLine("Точка не найдена");
        } else 
        {
            Console.WriteLine($"Количество символов до точки: {index}");
        }