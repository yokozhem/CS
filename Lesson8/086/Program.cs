// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.

System.Console.WriteLine("Введите текст: ");
string input = Console.ReadLine();

System.Console.WriteLine("Какой символ будем искать?");
char searchChar = Console.ReadKey().KeyChar;
Console.WriteLine();
int count = 0;
        foreach (char c in input) 
        {
            if (c == searchChar) 
            {
                count++;
            }
        }

        Console.WriteLine($"Символ '{searchChar}' встречается в строке {count} раз(а)");

